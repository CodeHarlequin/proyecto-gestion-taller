using GestionTaller.VistasFormularios.Propietario;
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

namespace GestionTaller
{
   public partial class fReparaciones : Form
   {
      public fReparaciones()
      {
         InitializeComponent();
      }

      private void fReparaciones_Load(object sender, EventArgs e)
      {
         // Se desabilitan los controles 
         DesabilitarBotonesAccion();

         // Rellena el data grid 
         ActualizarDataGridView();

         // Ocultar columnas inecesarios
         OcultarColumnasInecesarias();
      }

      private void dgvReparaciones_CellClick(object sender, DataGridViewCellEventArgs e)
      {
         // Recursos locales
         string valorCelda;

         // Inializaccion
         valorCelda = dgvReparaciones.SelectedRows[0].Cells["EstadoRep"].Value.ToString();
         DesabilitarBotonesAccion();

         // Comprobaciones
         // Depenidndo de la fila selecciona se habilita unos controles u otros
         if (valorCelda == Reparacion.Estado.Diagnostico.ToString())
            bPresupuesto.Enabled = true;

         if (valorCelda == Reparacion.Estado.Aprobacion_Cliente.ToString())
            bTrabajadores.Enabled = true;
      }

      private void bAcccion_Click(object sender, EventArgs e)
      {
         // Recursos locales
         Form formularioMostrar = null;
         Button botonClikado;
         Reparacion reparacionSeleccionada;

         // Inializacion
         botonClikado = (Button)sender;
         reparacionSeleccionada = LogicaNegocio.OptenerDatosReparacion(
            (int)dgvReparaciones.SelectedRows[0].Cells["CodigoRep"].Value);

         switch (botonClikado.Name)
         {
            case "bPresupuesto":
               formularioMostrar = new fPresupuesto();
               break;
            case "bTrabajadores":
               formularioMostrar = new fSelectTrabajadores();
               break;
         }

         switch (formularioMostrar)
         {
            case fPresupuesto formReparacion:
               formReparacion.RepModificar = reparacionSeleccionada;
               break;
               //case fSelectTrabajadores formMecanico:
               //   formMecanico.RepModificar = reparacionSeleccionada;
               //   break;
         }

         // Mostrar formulario
         formularioMostrar.ShowDialog();

         // Actualizar los datos del Datagrid
         if (formularioMostrar.DialogResult == DialogResult.OK)
            ActualizarDataGridView();
      }

      private void ActualizarDataGridView()
      {
         //dgvReparaciones.DataSource = LogicaNegocio.OptenerListaReparacaiones().ToList();
         dgvReparaciones.DataSource = LogicaNegocio.OptenerListaObjetos<Reparacion>().ToList();
      }

      private void OcultarColumnasInecesarias()
      {
         dgvReparaciones.Columns["VehiculoImplicado"].Visible = false;
         dgvReparaciones.Columns["JefeMecanico"].Visible = false;
         dgvReparaciones.Columns["InformacionAdicional"].Visible = false;
      }

      private void DesabilitarBotonesAccion()
      {
         bPresupuesto.Enabled = false;
         bTrabajadores.Enabled = false;
      }
   }
}