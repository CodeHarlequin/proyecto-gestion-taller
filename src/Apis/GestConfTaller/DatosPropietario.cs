using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios;

namespace GestConfTaller
{
   public class DatosPropietario
   { 
      public const string NOMBRE = "PropieatarioTaller";
      public const string EXTENCION = ".p";
      
      public static Propietario OptenePropietario()
      {
         string registroDatos;
         Propietario propietarioDevolver = null;

         // Optiene los registros del fichero
         registroDatos = File.ReadAllLines($"..\\..\\..\\..\\Configuracion\\{NOMBRE}{EXTENCION}")[0];

         if (registroDatos != null)
         {
            propietarioDevolver = new Propietario(
               registroDatos.Split(";")[0], 
               registroDatos.Split(";")[1]);
         }


         return propietarioDevolver;
      }
   }
}
