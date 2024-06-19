using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios
{
   public class Propietario
   {
      private string _usuario;
      private string _contrasenia;

      public Propietario(string usuario, string contrasenia) 
      { 
         Usuario = usuario;
         Contrasenia = contrasenia;
      }

      public string Usuario 
      { 
         get => _usuario; 
         set => _usuario = value; 
      }

      public string Contrasenia
      {
         get => _contrasenia;
         set => _contrasenia = value;
      }
   }
}
