using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios
{
   public class Cliente : Persona
   {
      #region CONSTANTES

      #endregion

      #region MIEMBROS

      #endregion

      #region CONSTRUCTORES
      /// <summary>
      /// Constructor con el DNI y contraseña del Usuario
      /// </summary>
      /// <param name="dni">DNI del Usuario</param>
      /// <param name="contrasenia">Contraseña del Usuario</param>
      public Cliente(string dni, string contrasenia) : base(dni, contrasenia) { }

      /// <summary>
      /// Contructor con todos los datos del Usuario
      /// </summary>
      /// <param name="dni">DNI del Usuario</param>
      /// <param name="nombre">Nombre del Usuario</param>
      /// <param name="apellidos">Apellidos del Usuario</param>
      /// <param name="telefono">Teléfono del Usuario</param>
      /// <param name="contrasenia">Contraseña del Usuario</param>
      public Cliente(string dni, string nombre, string apellidos, string telefono, string contrasenia)
         : base(dni, nombre, apellidos, telefono, contrasenia) { }
      #endregion

      #region PROPIEDADES
      #endregion
   }
}
