using BaseDatos;
using GestionTaller.VistasFormularios.Cliente;
using ModeloInfoGestion;
using ModeloVehiculos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuarios;

namespace GestionTaller
{
    public partial class fCita : Form
    {

        #region Miembros
        // Miembros
        private Cliente _propietario;

        // Constructor
        public fCita()
        {
            InitializeComponent();
        }

        public fCita(Cliente propietario)
        {
            Propietario = propietario;
            InitializeComponent();
        }

        // Propiedades
        public Cliente Propietario
        {
            get
            {
                return _propietario;
            }
            set
            {
                _propietario = value;
            }
        }

        #endregion

        #region Controladores y eventos

        private void fCita_Load(object sender, EventArgs e)
        {
            // Recursos
            bool esValido = true;
            string MensajeError = "";

            try
            {
                CargarListaVehiculos();
            }
            catch (Exception error)
            {
                esValido = false;
                MensajeError = error.Message;
            }
            finally
            {
                if (!esValido) MostrarError(MensajeError);
            }
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            // Recursos
            bool esValido = true;
            string MensajeError = "";

            try
            {
                // En caso de que el usuario lo quiera, se guardarán los cambios
                if(VentanaConfirmacion($"¿Desea añadir una reserva del el vehículo del propietario {Propietario.Nombre}?") == DialogResult.Yes)
                {
                    GuardarCambios();

                    MostrarMensaje($"La cita para el vehículo {dgvListaVehiculos.CurrentCell.Value.ToString()} ha sido añadida correctamente");

                    LimpiarControles();
                }
            }
            catch (Exception error)
            {
                esValido = false;
                MensajeError = error.Message;
            }
            finally
            {
                if (!esValido) MostrarError(MensajeError);
            }
        }


        #endregion

        #region Funcionalidades de los eventos

        /// <summary>
        /// Carga el contenido al DataRowView
        /// </summary>
        private void CargarListaVehiculos()
        {
            dgvListaVehiculos.DataSource = LogicaNegocio.ObtenerListaVehiculos(Propietario.Dni);
        }

        private void GuardarCambios()
        {
            // Recursos
            // Conversión a sus valores correspondientes
            // para añadirlas al objeto NuevaCita
            DateTime fecha = DateTime.Parse(dtpFecha.Text);
            TimeSpan hora = TimeSpan.Parse(mtbHora.Text);

            // Dar el formato correcto a la fecha, para que a la hora de hacer el insert, no haya errores con el formato
            string fechaString = LogicaNegocio.FormatearFecha(dtpFecha.Value.Year.ToString(), dtpFecha.Value.Month.ToString(), dtpFecha.Value.Day.ToString());

            // Instanciación del objeto Vehículo seleccionado
            Vehiculo VehiculoSeleccionado = LogicaNegocio.ObtenerVehiculo(Propietario.Dni, dgvListaVehiculos.CurrentCell.Value.ToString());

            // Instanciación del Objeto Cita
            Cita NuevaCita = new Cita(fecha, hora, tbDescripcion.Text, Propietario, VehiculoSeleccionado);

            // Hace el insert con los datos seleccionados
            LogicaNegocio.InsertarReserva(fechaString.ToString(), hora.ToString(), NuevaCita.Descripcion, Propietario.Dni, VehiculoSeleccionado.NumBastidor);





        }

        private void LimpiarControles()
        {
            tbDescripcion.Text = "";
            dtpFecha.Value = DateTime.Now;
            mtbHora.Text = string.Empty;

        }

        #endregion

        #region UI
        public static void MostrarMensaje(string cadena)
        {
            MessageBox.Show($"{cadena}", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MostrarError(string error)
        {
            MessageBox.Show($"Error: {error}", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult VentanaConfirmacion(string cadena)
        {
            // Recursos
            DialogResult resultado = DialogResult.Yes;

            // Mensaje
            resultado = MessageBox.Show(cadena, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return resultado;
        }

        #endregion

    }
}
