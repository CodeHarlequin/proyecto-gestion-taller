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
      public static TClase? ConstruirObjeto<TClase>(DataRow filaDatos, string nombreTabla) where TClase : class
      {
         TClase? objetoDevolver = null;

         switch (nombreTabla)
         {
            case "Cliente":
               objetoDevolver = CrearInstancia<Cliente>(filaDatos) as TClase;
               break;
            case "Empleado":
               objetoDevolver = CrearInstancia<Empleado>(filaDatos) as TClase;
               break;
         }

         return objetoDevolver;
      }

      public static TClase? CrearInstancia<TClase>(DataRow filaDatos) where TClase : class
      {
         // Recursos locales
         TClase? objetoDeInstancia = null;
         ConstructorInfo[] listaConstructores;
         ParameterInfo[] listaParametros;
         ParameterInfo parametro;
         object[] argumentos;
         bool puedeCrear = true;

         // Obtener todos los constructores de la clase
         listaConstructores = typeof(TClase).GetConstructors(); 

         foreach (ConstructorInfo constructor in listaConstructores)
         {
            // Obtener los parámetros del constructor
            listaParametros = constructor.GetParameters();

            // Preparar un array para almacenar los argumentos
            argumentos = new object[listaParametros.Length];

            for (int i = 0; i < listaParametros.Length; i++)
            {
               parametro = listaParametros[i];

               try
               {
                  // Asignar el valor del DataRow al array de argumentos
                  argumentos[i] = Convert.ChangeType(filaDatos[parametro.Name], parametro.ParameterType);
               }
               catch
               {
                  // Si hay un error al convertir el valor, no se puede crear usando este constructor
                  puedeCrear = false;
                  throw new Exception();
               }
            }

            if (puedeCrear)
            {
               // Crear una instancia con el constructor y los argumentos
               objetoDeInstancia = (TClase)constructor.Invoke(argumentos);
            }
         }

         return objetoDeInstancia;
      }
   }
}
