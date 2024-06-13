using InfoGestion;
using ModeloVehiculos;
using Usuarios;

namespace ModeloInfoGestion
{
   public class Cita
   {
      public enum Estado { Pendiente, Confirmada }

      #region CONSTANTES
      private const byte CODIGO_MIN_LONG = 5;
      #endregion

      #region MIEMBROS
      private string _codigoIdentificacion;
      private DateTime _fechaMasHora;

      // Datos complentacion de la cita
      private float _presupuesto;
      private string _descripcion;
      private Estado _estadoCita;

      // Datos de indentificacion de los objetos implicados
      private Cliente _solicitante;
      private Vehiculo _vehiculoReparar;
      #endregion

      #region CONSTRUCTORES
      public Cita(DateTime FechaHora, string descripcionGeneral, Cliente solicitante, Vehiculo vehiculo)
      {
         FechaMasHora = FechaHora;
         Descripcion = descripcionGeneral;
         Solicitante = solicitante;
         VehiculoReparar = vehiculo;
         EstadoCita = Estado.Confirmada;
      }
      #endregion

      #region PROPIEDADES
      public string CodigoIdentificacion
      {
         get => _codigoIdentificacion;
         set
         {
            ValidarCodigoIdentificacion(value);
            _codigoIdentificacion = value;
         }
      }

      public DateTime FechaMasHora 
      { 
         get => _fechaMasHora;
         set
         {
            ValidarFecha(value);
            _fechaMasHora = value;
         }
      }

      public float Presupuesto 
      { 
         get => _presupuesto;
         set
         {
            ValidarPresupuesto(value);
            _presupuesto = value;
         }
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

      public Estado EstadoCita 
      {
         get => _estadoCita; 
         set => _estadoCita = value; 
      }
      #endregion

      #region METODOS
      private static void ValidarCodigoIdentificacion(string codigoValidar)
      {
         try
         {
            // Validar si el valor es nulo
            codigoValidar = CompDatos.ValidarValorEntrada(codigoValidar);

            // Validar limite de caracteres
            CompDatos.ValidarLimiteCaracteres(codigoValidar, CODIGO_MIN_LONG, CODIGO_MIN_LONG);
         }
         catch (Exception errorCap)
         {
            throw new CodigoInvalidoException(errorCap.Message);
         }
      }

      private static void ValidarFecha(DateTime fechaValidar)
      {
         try
         {
            // Validar que la fecha se a mayor a la actual
            if (fechaValidar < DateTime.Now)
               throw new Exception("Inferior al la fecha actual");
         }
         catch (Exception errorCap)
         {
            throw new FechaInvalidaException(errorCap.Message);
         }
      }

      private static void ValidarPresupuesto(float presupuestoValidar)
      {
         try
         {
            // Validar que no sea negativo
            if (presupuestoValidar < 0)
               throw new OverflowException("No puede contener un valor negativo");
         }
         catch (Exception errorCap)
         {
            throw new PresupuestoInvalidaException(errorCap.Message);
         }
      }
      #endregion
   }

   #region EXCEPCIONES PERSONALIZADAS
   public class FechaInvalidaException : Exception
   {
      public FechaInvalidaException(string mensajeError) : base($"Fecha:  {mensajeError}") { }
   }

   public class PresupuestoInvalidaException : Exception
   {
      public PresupuestoInvalidaException(string mensajeError) : base($"Presupuesto:  {mensajeError}") { }
   }
   #endregion
}