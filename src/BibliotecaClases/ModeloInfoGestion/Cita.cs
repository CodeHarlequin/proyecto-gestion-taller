using Usuarios;

namespace ModeloInfoGestion
{
   public class Cita
   {
      #region MIEMBROS
      private DateTime _fechaMasHora;
      private float _presupuesto;
      private Cliente _solicitante;
      #endregion

      #region CONSTRUCTORES
      public Cita(DateTime FechaYHora, float preSolicitar, Cliente solicitante)
      {
         FechaMasHora = FechaYHora;
         Presupuesto = preSolicitar;
         Solicitante = solicitante;
      }  
      #endregion

      #region PROPIEDADES
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
      #endregion

      #region METODOS
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