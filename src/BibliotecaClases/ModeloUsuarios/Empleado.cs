using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios
{
   #region ENUMERACIÓN

   #endregion

   public class Empleado : Persona
   {
      #region CONSTANTES
      #endregion

      #region MIEMBROS
      //TipoCargo _cargoDesempeniar;
      string _especialidad;
      #endregion

      #region CONSTRUCTORES
      /// <summary>
      /// Constructor con el DNI y contraseña del Usuario
      /// </summary>
      /// <param name="dni">DNI del Usuario</param>
      /// <param name="contrasenia">Contraseña del Usuario</param>
      public Empleado(string dni, string contrasenia) : base(dni, contrasenia)
      {
         //_cargoDesempeniar = USUARIO_DEF;
      }

      /// <summary>
      /// Contructor con todos los datos del Usuario
      /// </summary>
      /// <param name="dni">DNI del Usuario</param>
      /// <param name="nombre">Nombre del Usuario</param>
      /// <param name="apellidos">Apellidos del Usuario</param>
      /// <param name="telefono">Teléfono del Usuario</param>
      /// <param name="contrasenia">Contraseña del Usuario</param>
      /// <param name="tipoCargo">Tipo de Usuario</param>
      public Empleado(string dni, string nombre, string apellidos, string telefono, string contrasenia, string especialidad)
         : base(dni, nombre, apellidos, telefono, contrasenia)
      {
         //Cargo = tipoCargo;
         Especialidad = especialidad;

      }
      #endregion

      #region PROPIEDADES
     

      public string Especialidad
      {
         get => _especialidad;
         set => _especialidad = value;
      }
      #endregion
   }
}
