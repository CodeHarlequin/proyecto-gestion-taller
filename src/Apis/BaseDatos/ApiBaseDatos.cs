using InfoGestion;
using ModeloInfoGestion;
using ModeloVehiculos;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Usuarios;

namespace BaseDatos
{
   public static class ApiBaseDatos
   {
      private const string CADENA_CONEXION =
         "Data Source=(localdb)\\MSSQLLocalDB; " + // Direccion del servidor
         "Initial Catalog=Taller; " + // Nombre de la base de datos 
         "Integrated Security=true"; // Utilizara el metodo de autenticacion de windows

      #region METODOS PUBLICOS
      /// <summary>
      /// Optener un listado de objetos
      /// </summary>
      /// <param name="queryEjecutar"></param>
      /// <returns></returns>
      public static object[] OptenerListaObjetos(string queryEjecutar)
      {
         List<object> listaObjetos;
         object objetoAlmacenar;
         DataSet datosOptenidos; // Contener los datos extradios por la consulta

         // Inializacion
         listaObjetos = new List<object>();
         datosOptenidos = OptenerDatosAlmacenados(queryEjecutar); // Se optien los datos de la base de datos

         // Se recorre el DataRowCollection optenido del la propieda Rows
         // Indice 0 ya que en principio unicamente se usara una tabla
         foreach (DataRow filaDatos in datosOptenidos.Tables[0].Rows)
         {
            // Construlle el objeto
            objetoAlmacenar = ConstruirObjeto(filaDatos);

            // Se almacena en la lista
            if (objetoAlmacenar != null)
            {
               listaObjetos.Add(objetoAlmacenar);
            }
         }

         // Internamente se trabaja con un list pero para mayor facilidad para los prograamodres que utilizan el metodo
         // se devuelve como un array
         return listaObjetos.ToArray();
      }

      public static void EjecutarInstruccion(string instruccion)
      {
         SqlConnection conexionDB = null;
         SqlCommand comandoEjecutar = null;

         try
         {
            conexionDB = EstablecerConexion();
            comandoEjecutar = new SqlCommand(instruccion, conexionDB);

            // Se habre la conexion con la base de datos
            conexionDB.Open();

            // Ejecuta la isntrucciones que no devuelven valores
            // INSERT | UPDATE | DELETE
            comandoEjecutar.ExecuteNonQuery();
         }
         catch (Exception error)
         {
            throw error;// Se reelanza el error
         }
         finally
         {
            // Cierra la conexion
            conexionDB.Close();
         }
      }
      #endregion

      #region METODOS PIRVADOS
      private static SqlConnection EstablecerConexion()
      {
         // Recursos locales
         SqlConnection conexion = null;

         try
         {
            conexion = new SqlConnection(CADENA_CONEXION);
         }
         catch (Exception)
         {
            throw new Exception("No se puede conecestar con la base de datos");
         }

         return conexion;
      }

      private static DataSet OptenerDatosAlmacenados(string instruccionEjecutar)
      {
         // Recuros locales
         DataSet datosExtraidos;
         SqlConnection conexionDB = null;
         SqlDataAdapter bridgeDB = null;
         string nombreTabla;

         // Inaliazacion
         datosExtraidos = new DataSet(); // Se reserva memoria
         nombreTabla = OptenerNombreTabla(instruccionEjecutar);

         // Validacion de la entrada
         if (string.IsNullOrEmpty(instruccionEjecutar))
            throw new ArgumentNullException("No se ha especificado una consulta");

         try
         {
            // Optiene la conexion con la base de datos
            conexionDB = EstablecerConexion();

            // Establece el puente entre la app y la base de datos
            bridgeDB = new SqlDataAdapter(instruccionEjecutar, conexionDB);

            // Carga los datos en el DataSet especificado
            bridgeDB.Fill(datosExtraidos, nombreTabla);
         }
         catch (Exception error)
         {
            throw error;
         }
         finally
         {
            // Cirra la conexion en hayao no errores
            conexionDB.Close();
         }

         return datosExtraidos;
      }

      private static string OptenerNombreTabla(string consulta)
      {
         return Regex.Match(consulta, @"\bFROM\s+(\w+)\b").Groups[1].Value;
      }

      /*
       * Se indicara el nombre de la tabla proveniente de los datos y la clase 
       * la cual realiza la funcion de modelo de datos
       */
      private static object? ConstruirObjeto(DataRow filaDatos)
      {
         // Recursos locales
         object? objetoDevolver = null;
         Type tipoObjetoDevolver = null;
         string nombreTabla;

         // Inializacion
         nombreTabla = filaDatos.Table.TableName;

         // Se crea una instacia de una de las clases dependiendo del nombre indicado
         switch (nombreTabla)
         {
            case "Clientes":
               tipoObjetoDevolver = typeof(Cliente);
               break;
            case "Mecanicos":
               tipoObjetoDevolver = typeof(Empleado);
               break;
            case "Vehiculos":
               tipoObjetoDevolver = typeof(Vehiculo);
               break;
            case "Reservas":
               tipoObjetoDevolver = typeof(Cita);
               break;
            case "Reparaciones":
               tipoObjetoDevolver = typeof(Reparacion);
               break;
            case "Operaciones":
               tipoObjetoDevolver = typeof(Operacion);
               break;
         }

         //objetoDevolver = CreacionObjetos.CrearInstancia<Empleado>(filaDatos);
         objetoDevolver = CreacionObjetos.CrearInstancia(tipoObjetoDevolver, filaDatos);

         // Devolver objeto creado
         return objetoDevolver;
      }

      /*
       * En caso de que la clase que se este instanciando en su constructor tenga un 
       * parametro de tipo objeto de una clase especificada se debera indicar a 
       * continuacion la instruccion sql a transmitir para reconstruir dicho objeto
       */
      internal static object OptenerObjetoPorTipo(Type tipoObjeto, string valorAFiltrar)
      {
         // Recursos locales
         string consultaRealizar = "";
         object objetoDevolver = null;
         bool esArrayObjetos;
         Type tipoReal;

         // Inializacion
         esArrayObjetos = tipoObjeto.IsArray;
         // tipoObjeto.Name no devuelve el nombre del tipo subyacente sino algo más complejo
         // Cliente[]
         tipoReal = esArrayObjetos ? tipoObjeto.GetElementType() : tipoObjeto;

         // Usar el tipo real en el switch para obtener el nombre del tipo subyacente
         switch (tipoReal.Name)
         {
            case nameof(Cliente):
               consultaRealizar = $"SELECT * FROM Clientes WHERE cDni = '{valorAFiltrar}'";
               break;

            case nameof(Empleado):
               consultaRealizar = $"SELECT * FROM Mecanicos WHERE cDni = '{valorAFiltrar}'";

               // Empleados que participan en reparaciones
               if (esArrayObjetos) consultaRealizar = $"SELECT * FROM Mecanicos WHERE cDni IN " +
                     $"( SELECT cDni_Mecanico FROM MecanicoReparacion WHERE iCodigo_Reparacion = {valorAFiltrar} )";
               break;

            case nameof(Vehiculo):
               consultaRealizar = $"SELECT * FROM Vehiculos WHERE cNBastidor = '{valorAFiltrar}'";
               break;

            case nameof(Operacion):
               if (esArrayObjetos) consultaRealizar = $"SELECT * FROM Operaciones WHERE vNombre IN " +
                     $"( SELECT vNombre FROM OperacionReparacion WHERE iCodigo_Reparacion = {valorAFiltrar} )";
               break;
         }

         // Obtine una instacia del objeto base a la consulta a realizar 
         objetoDevolver = esArrayObjetos ? OptenerListaObjetos(consultaRealizar) : OptenerListaObjetos(consultaRealizar)[0];

         return objetoDevolver;
      }
      #endregion
   }
}
