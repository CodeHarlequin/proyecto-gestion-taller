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

namespace GestionTaller.VistasFormularios.Propietario
{
   public partial class fPresupuesto : Form
   {
      private Reparacion _repModificar;

      public fPresupuesto()
      {
         InitializeComponent();
      }

      public Reparacion RepModificar
      {
         get => _repModificar;
         set => _repModificar = value;
      }

      private void fPresupuesto_Load(object sender, EventArgs e)
      {
         RellanarDatosFormulario();
      }

      private void bGuardar_Click(object sender, EventArgs e)
      {
         // Recursos locales
         bool esCorrecto = true;

         try
         {
            // Actualiza el presupuesto de cierta reparacion
            RepModificar.Presupuesto = (float)nudPresupuesto.Value;
            LogicaNegocio.ActualizarPresupuesto(RepModificar);
         }
         catch (Exception errorCap)
         {
            esCorrecto = false;
            informarError.SetError(bGuardar, errorCap.Message);
         }

         if (esCorrecto)
         {
            // Indica que la operacion a sido exitosa
            this.DialogResult = DialogResult.OK;
            // Se cierra el formularaio
            this.Close();
         }
      }

      private void RellanarDatosFormulario()
      {
         tbNBastidor.Text = RepModificar.VehiculoImplicado.NumBastidor;
         tbMatricula.Text = RepModificar.VehiculoImplicado.Matricula;
         tbMarca.Text = RepModificar.VehiculoImplicado.Marca;
         tbModelo.Text = RepModificar.VehiculoImplicado.Modelo;
         tbTipo.Text = RepModificar.VehiculoImplicado.Tipo.ToString();
         tbDescripcion.Text = RepModificar.InformacionAdicional;
      }
   }
}
