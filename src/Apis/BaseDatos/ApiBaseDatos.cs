using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Usuarios;

namespace BaseDatos
{
   public class ApiBaseDatos
   {
      private const string CADENA_CONEXION =
         "Data Source=(localdb)\\MSSQLLocalDB; " + // Direccion del servidor
         "Initial Catalog=Taller; " + // Nombre de la base de datos 
         "Integrated Security=true"; // Utilizara el metodo de autenticacion de windows

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

         // Inaliazacion
         datosExtraidos = new DataSet(); // Se reserva memoria

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
            bridgeDB.Fill(datosExtraidos);
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

      /// <summary>
      /// Optener un listado de objetos de la clase Participantes
      /// </summary>
      /// <param name="queryEjecutar"></param>
      /// <returns></returns>
      public static TClase[] OptenerListaObjetos<TClase>(string queryEjecutar) where TClase : class
      {
         // Recursos locales
         List<TClase> listaObjetos;
         DataSet datosOptenidos; // Contener los datos extradios por la consulta
         string nombreTablaDatos;

         // Inializacion
         datosOptenidos = OptenerDatosAlmacenados(queryEjecutar); // Se optien los datos de la base de datos
         nombreTablaDatos = OptenerNombreTabla(queryEjecutar);
         listaObjetos = new List<TClase>();
         
         // Se recorre el DataRowCollection optenido del la propieda Rows
         foreach (DataRow filaDatos in datosOptenidos.Tables[nombreTablaDatos].Rows)
         {
            listaObjetos.Add(CreacionObjetos.ConstruirObjeto<TClase>(filaDatos, nombreTablaDatos));
         }

         // Internamente se trabaja con un list pero para mayor facilidad para los prograamodres que utilizan el metodo
         // se devuelve como un array
         return listaObjetos.ToArray();
      }

      public static string OptenerNombreTabla(string consulta)
      {
         return Regex.Match(consulta, @"\bFROM\s+(\w+)\b").Value;
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
   }
}
