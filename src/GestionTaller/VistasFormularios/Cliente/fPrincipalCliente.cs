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

namespace GestionTaller.VistasFormularios.Cliente
{
    public partial class fPrincipalCliente : Form
    {
        //// No olvidar Borrar
        //private Usuarios.Cliente CargarDatosPrueba()
        //{
        //    Usuarios.Cliente c = new Usuarios.Cliente("12345678Y", "Fran", "Gallardo", "333333333", "cC´s>23dasdñ");
        //    return c;
        //}

        #region Miembros y Constructores

        // Miembros
        private Usuarios.Cliente _propietario;

        // Propiedades
        public Usuarios.Cliente Propietario
        {
            get { return _propietario; }
            set { _propietario = value; }
        }

        // Constructor
        public fPrincipalCliente(Usuarios.Cliente propietario)
        {
            Propietario = propietario;
            InitializeComponent();
        }

        public fPrincipalCliente()
        {
            InitializeComponent();
        }

        #endregion

        private void Controlador_Click(object sender, EventArgs e)
        {
            // Recursos
            bool esValido = true;
            string MensajeError = "";
            Button Opcion = (Button)sender;
            // Propietario = CargarDatosPrueba();

            try
            {
                switch (Opcion.Name)
                {
                    case "bCita":
                        fCita formCita = new fCita(Propietario);
                        formCita.ShowDialog();
                        break;
                    case "bVehiculos":
                        fVehiculo formVehiculo = new fVehiculo(Propietario);
                        formVehiculo.ShowDialog();
                        break;
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
            }
        }



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
