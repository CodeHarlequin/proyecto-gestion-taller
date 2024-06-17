using InfoGestion;
using ModeloVehiculos;
using Usuarios;

namespace ModeloInfoGestion
{
    public class Cita
    {
        #region CONSTANTES
        private const int DESCRIPCION_MAX = 300;
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
            set
            {
                _descripcion = ValidarDescripcion(value);
            }
        }

        public Vehiculo VehiculoReparar
        {
            get => _vehiculoReparar;
            set => _vehiculoReparar = value;
        }
        #endregion

        #region METODOS


        /// <returns>Devuelve la cadena sin espacios inecesarios</returns>
        private static string ValidarDescripcion(string cadena)
        {
            // Preparación de la cadena
            cadena = cadena.Trim();

            // Validación del rango maximo de la descripción
            if (cadena.Length > DESCRIPCION_MAX) throw new DescripcionErroneaException($"La descripción es mayor al rango máximo, (0 - {DESCRIPCION_MAX})");

            return cadena;
        }

        #endregion
    }

    #region EXCEPCIONES PERSONALIZADAS
    public class DescripcionErroneaException : Exception
    {
        public DescripcionErroneaException() : base("El formato de la descripción es incorrecta.") { }
        public DescripcionErroneaException(string message) : base(message) { }
    }

    #endregion
}