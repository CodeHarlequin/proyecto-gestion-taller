using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios
{
   #region ENUMERACIÓN
   /// <summary>
   /// Enumeración para el tipo de usuario del taller
   /// </summary>
   public enum TipoCargo : byte { Jeje, Mecanico };
   #endregion

   public class Empleado : Persona
   {
      #region CONSTANTES
      private const TipoCargo USUARIO_DEF = TipoCargo.Mecanico;
      #endregion

      #region MIEMBROS
      TipoCargo _cargoDesempeniar;
      #endregion

      #region CONSTRUCTORES
      /// <summary>
      /// Constructor con el DNI y contraseña del Usuario
      /// </summary>
      /// <param name="dni">DNI del Usuario</param>
      /// <param name="contrasenia">Contraseña del Usuario</param>
      public Empleado(string dni, string contrasenia) : base(dni, contrasenia)
      {
         _cargoDesempeniar = USUARIO_DEF;
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
      public Empleado(string dni, string nombre, string apellidos, string telefono, string contrasenia, TipoCargo tipoCargo) 
         : base(dni, nombre, apellidos, telefono, contrasenia)
      {
         Cargo = tipoCargo;
      }
      #endregion

      #region PROPIEDADES
      /// <summary>
      /// Tipo de Usuario del Taller
      /// </summary>
      public TipoCargo Cargo
      {
         get => _cargoDesempeniar;
         set => _cargoDesempeniar = value;
      }
      #endregion
   }
}
