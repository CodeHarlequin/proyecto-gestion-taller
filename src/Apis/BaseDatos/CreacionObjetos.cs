using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Usuarios;

namespace BaseDatos
{
   public static class CreacionObjetos
   {
      public static object? CrearInstancia(Type tipoObjeto, DataRow filaDatos)
      {
         // Recursos locales
         object? objetoDeInstancia = null;
         ConstructorInfo[] listaConstructores;
         ConstructorInfo constructor;
         object[] argumentos;
         bool objetoConstruido;

         // Inializacion
         objetoConstruido = false;
         listaConstructores = tipoObjeto.GetConstructors()
            .Where(cons => cons.GetParameters().Length == filaDatos.Table.Columns.Count)
            .ToArray(); // Cargar la lista de costructores con el mismo numero de columnas

         // Probamos todos los constructores de una determinada clase
         for (int indice = 0; indice < listaConstructores.Length && !objetoConstruido; indice++)
         {
            constructor = listaConstructores[indice];

            try
            {
               // Optien el listado de argumetos que se le pasara al constructor
               argumentos = ObtenerArgumentosParaConstructor(constructor, filaDatos);

               // Intenta invocar el constructror con los valores optenidos
               objetoDeInstancia = constructor.Invoke(argumentos);
               objetoConstruido = true;
            }
            catch
            {
               // Si se prodce una excepcion es por que los valores no son los correctos
               // por lo que no es el constructor adecuado
            }
         }

         return objetoDeInstancia;
      }

      private static object[] ObtenerArgumentosParaConstructor(ConstructorInfo constructor, DataRow filaDatos)
      {
         // Recursos locales
         ParameterInfo[] listaParametros;
         ParameterInfo parametro;
         object[] listaArgumentos;
         object valorArgumento;
         string nombreColumna;

         // Inializacion
         listaParametros = constructor.GetParameters();
         listaArgumentos = new object[listaParametros.Length];

         for (int indice = 0; indice < listaParametros.Length; indice++)
         {
            // Almacena de forma temporal el parametro por el que operar
            parametro = listaParametros[indice];

            // Optiene el nombre de la columna donde se aloja el dato en la tabla
            nombreColumna = DiccionarioCampos.OptenerNombreColumna(constructor, parametro);

            // Optien el valor que se tomara como argumento
            valorArgumento = ObtenerValorParaArgumento(parametro, filaDatos, nombreColumna);

            try
            {
               // Realiza la conversion del valor al tipo esperado por el parametro
               listaArgumentos[indice] = parametro.ParameterType.IsArray
                  ? ConversionManualTipoArray(valorArgumento, parametro.ParameterType)
                  : Convert.ChangeType(valorArgumento, parametro.ParameterType);
            }
            catch (Exception)
            {
               throw;
            }
         }

         return listaArgumentos;
      }

      private static object ObtenerValorParaArgumento(ParameterInfo parametro, DataRow filaDatos, string nombreColumna)
      {
         // Recursos locales
         object valorOptenido;
         Type tipoParametro;

         // Inializacion
         tipoParametro = parametro.ParameterType;

         try
         {
            // Optine el valor contendio en una determinada columna
            valorOptenido = filaDatos[nombreColumna];

            // En caso de ser de que el parametro admita un valor de tipo objeto
            if (tipoParametro.IsClass && tipoParametro != typeof(string))
            {
               valorOptenido = ApiBaseDatos.OptenerObjetoPorTipo(tipoParametro, valorOptenido.ToString());
            }
         }
         catch (Exception)
         {
            throw;
         }

         return valorOptenido;
      }

      private static object ConversionManualTipoArray(object valorArgumento, Type tipoArrayEsperado)
      {
         // Recursos locales
         Array valorArray;
         Array arrayConvertido = null;

         // Obtener el tipo de los elementos del array
         // Operacion[] => Operacion
         tipoArrayEsperado = tipoArrayEsperado.GetElementType();

         // Convertir el valorArgumento a un array
         valorArray = (Array)valorArgumento;

         // Evitar realizar ejecuciones inecesarias
         if (valorArray != null)
         {
            // Crear un nuevo array del tipo indicado
            arrayConvertido = Array.CreateInstance(tipoArrayEsperado, valorArray.Length);

            for (int indice = 0; indice < valorArray.Length; indice++)
            {
               // Convertir cada elemento del array al tipo de elemento esperado
               arrayConvertido.SetValue(Convert.ChangeType(valorArray.GetValue(indice), tipoArrayEsperado), indice);
            }
         }

         // Devuelve el array con el tipo adecuado
         return arrayConvertido;
      }
   }
}
