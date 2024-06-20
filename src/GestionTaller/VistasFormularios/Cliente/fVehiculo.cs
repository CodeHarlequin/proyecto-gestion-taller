using BaseDatos;
using GestionTaller.VistasFormularios.Cliente;
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
    public partial class fVehiculo : Form
    {


        #region Miembros y Constructores

        // Miembros
        private Cliente _propietario;

        // Propiedades
        public Cliente Propietario
        {
            get { return _propietario; }
            set { _propietario = value; }
        }

        // Constructor
        /// <summary>
        /// Constructor del Formulario para la adición de vehículos
        /// </summary>
        /// <param name="propietario">Propietario del vehículo, debe ser tipo Cliente</param>
        public fVehiculo(Cliente propietario)
        {
            Propietario = propietario;
            InitializeComponent();
        }
        public fVehiculo()
        {
            InitializeComponent();
        }
        #endregion

        #region Controladores

        private void fVehiculo_Load(object sender, EventArgs e)
        {
            // Recursos
            bool esValido = true;
            string MensajeError = "";

            try
            {
                // Carga el contenido del enum al CB
                CargarCBTipo();
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
            // Recursos Locales
            Button Opcion = (Button)sender;
            string MensajeError = "";
            bool esValido = true;

            try
            {
                // En caso de que el usuario acepte,
                // se insertarán los datos
                if(VentanaConfirmacion("¿Seguro que desea añadir el vehículo?") == DialogResult.Yes)
                {
                    GuardadoDatos();
                    MostrarMensaje($"El Vehículo del propietario {Propietario.Nombre} ha sido agregado correctamente.");
                }

            }
            catch(Exception error)
            {
                esValido = false;
                MensajeError = error.Message;
            }
            finally
            {
                if (!esValido) MostrarError(MensajeError);
                LimpiarControles();
            }
        }

        #endregion

        #region Funcionalidades Botones y Objetos

        private void GuardadoDatos()
        {
            // Recursos         
            // Vehiculo a guardar/Insertar
            Vehiculo NuevoVehiculo = new Vehiculo(tbNBastidor.Text, tbMatricula.Text, tbModelo.Text ,tbMarca.Text, cbTipoVehiculo.Text, Propietario);

            // Insercción de los datos
            LogicaNegocio.EjecutarInserccion
                ("Vehiculos", 
                NuevoVehiculo.NumBastidor, NuevoVehiculo.Matricula, NuevoVehiculo.Marca,
                NuevoVehiculo.Modelo ,NuevoVehiculo.Tipo.ToString(), Propietario.Dni);                   
        }

        #endregion

        #region Cargar Datos CB y Modificar Valores
        // Carga CB
        public void CargarCBTipo()
        {
            // Limpiar CB
            cbTipoVehiculo.Items.Clear();

            // Insercción de los datos
            string[] ListaTiposVehiculos = Enum.GetNames(typeof(TipoVehi));

            // Añadir el contenido del Array al CB de Tipos
            cbTipoVehiculo.Items.AddRange(ListaTiposVehiculos);


        }

        private void LimpiarControles()
        {
            tbMatricula.Text = "";
            tbMarca.Text = "";
            tbModelo.Text = "";
            tbNBastidor.Text = "";
            cbTipoVehiculo.Text = "";
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
