using InfoGestion;
using ModeloVehiculos;
using Usuarios;

namespace ModeloInfoGestion
{
   public class Cita
   {
      #region CONSTANTES

      #endregion

      #region MIEMBROS
      private DateTime _fechaMasHora;

      // Datos complentacion de la cita
      private string _descripcion;

      // Datos de indentificacion de los objetos implicados
      private Cliente _solicitante;
      private Vehiculo _vehiculoReparar;
      #endregion

      #region CONSTRUCTORES
      public Cita(DateTime fecha, TimeSpan hora, string descripcion, Cliente solicitante, Vehiculo vehiculo)
      {
         FechaMasHora = fecha + hora;
         Solicitante = solicitante;
         VehiculoReparar = vehiculo;
         Descripcion = descripcion;
      }

      #endregion

      #region PROPIEDADES
      public DateTime FechaMasHora
      {
         get => _fechaMasHora;
         set => _fechaMasHora = value;
      }

      public Cliente Solicitante
      {
         get => _solicitante;
         set => _solicitante = value;
      }

      public string Descripcion
      {
         get => _descripcion;
         set => _descripcion = value;
      }

      public Vehiculo VehiculoReparar
      {
         get => _vehiculoReparar;
         set => _vehiculoReparar = value;
      }
      #endregion

      #region METODOS
      // TODO: Metodo de validacion de la descripcion
      #endregion
   }

   #region EXCEPCIONES PERSONALIZADAS

   #endregion
}