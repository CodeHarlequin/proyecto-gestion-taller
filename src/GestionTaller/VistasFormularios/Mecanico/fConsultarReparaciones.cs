using InfoGestion;
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

namespace GestionTaller.VistasFormularios.Mecanico
{
    public partial class fConsultarReparaciones : Form
    {
        private Empleado _mecanico;

        public Empleado MecanicoSeleccionado
        {
            get => _mecanico;
            set => _mecanico = value;
        }

        public fConsultarReparaciones()
        {
            InitializeComponent();
        }

        private void fConsultarReparaciones_Load(object sender, EventArgs e)
        {
            // Desactivamos el botón de modificar
            bModificar.Enabled = false;
            bCompletarReparacion.Enabled = false;

            // Cargamos la lista de consultas
            ActualizarDataGridView();

            // Ocultamos las columnas que no sean relevantes para el mecánico
            OcultarColumnasInecesarias();
        }

        private void dgvReparaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Empleado empleadoJefe;

            // Activar el boton de modificar
            bModificar.Enabled = true;

            // Habitar boton si es jefe
            empleadoJefe = (Empleado)dgvReparaciones.SelectedRows[0].Cells["JefeMecanico"].Value;
            bCompletarReparacion.Enabled = MecanicoSeleccionado.Dni == empleadoJefe.Dni;
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            // Recursos Locales
            fModificarReparacion formularioMostrar;
            Button botonModificar;
            Reparacion reparacionSelecionada;

            // Inicialización
            botonModificar = (Button)sender;
            reparacionSelecionada = LogicaNegocio.ObtenerDatosReparacion((int)dgvReparaciones.SelectedRows[0].Cells["CodigoRep"].Value);

            // Crear una nueva instancia del formulario de modificación
            formularioMostrar = new fModificarReparacion();

            // Pasar los datos de la reparacion seleccionada al formulario de modificación
            formularioMostrar.ReparacionSeleccionada = reparacionSelecionada;

            // Mostrar formulario para modificar la reparación
            formularioMostrar.ShowDialog();

            // Actualizar los datos del Datagrid al cerrar el formulario
            if (formularioMostrar.DialogResult == DialogResult.OK)
                ActualizarDataGridView();
        }

        private void ActualizarDataGridView()
        {
            // Obtenemos la lista de reparaciones de la base de datos
            dgvReparaciones.DataSource = LogicaNegocio.ObtenerListaReparaciones(MecanicoSeleccionado.Dni).ToList();
        }

        private void OcultarColumnasInecesarias()
        {
            dgvReparaciones.Columns["VehiculoImplicado"].Visible = false;
            dgvReparaciones.Columns["JefeMecanico"].Visible = false;
            dgvReparaciones.Columns["InformacionAdicional"].Visible = false;
        }

        private void bCompletarReparacion_Click(object sender, EventArgs e)
        {
            Reparacion reparacionSelecionada;

            // Inicialización
            reparacionSelecionada = LogicaNegocio.ObtenerDatosReparacion((int)dgvReparaciones.SelectedRows[0].Cells["CodigoRep"].Value);

            // Actualizar el estado de la reparación a completo
            LogicaNegocio.ActualizarEstado(reparacionSelecionada.CodigoRep);

            // Desactivar el botón 
            bCompletarReparacion.Enabled = false;

            // Actualizar los datos del DataGridView
            ActualizarDataGridView();
        } 
    }
}
