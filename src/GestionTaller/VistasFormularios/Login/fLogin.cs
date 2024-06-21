using GestionTaller.VistasFormularios.Mecanico;
using InicioSesion;
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
   public partial class fLogin : Form
   {
      enum TipoUsuario : byte { Cliente, Empleado, Propietario }

      public fLogin()
      {
         InitializeComponent();
      }

      private void fLogin_Load(object sender, EventArgs e)
      {
         DesabilitarControlesInicio();

         cbTipoUsuario.Items.AddRange(Enum.GetNames(typeof(TipoUsuario)));
      }

      private void cbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
      {
         const string MASCARA_DNI = "00000000-L";


         switch (cbTipoUsuario.SelectedItem)
         {
            case nameof(TipoUsuario.Cliente):
            case nameof(TipoUsuario.Empleado):
               mtbUsuario.Mask = MASCARA_DNI;
               break;
            case nameof(TipoUsuario.Propietario):
               mtbUsuario.Mask = "";
               break;
         }

         mtbUsuario.Enabled = true;
         tbContrasenia.Enabled = true;
      }

      private void bLogin_Click(object sender, EventArgs e)
      {
         Persona usuarioLoguear = null;
         Form formularioMostrar = null;
         bool esCorrecto = true;

         try
         {
            switch (cbTipoUsuario.SelectedItem)
            {
               case nameof(TipoUsuario.Cliente):
                  usuarioLoguear = new Cliente(mtbUsuario.Text, tbContrasenia.Text);
                  ApiLoguin.Login<Cliente>(usuarioLoguear);
                  break;
               case nameof(TipoUsuario.Empleado):
                  usuarioLoguear = new Empleado(mtbUsuario.Text, tbContrasenia.Text);
                  ApiLoguin.Login<Empleado>(usuarioLoguear);
                  break;
               case nameof(TipoUsuario.Propietario):
                  ApiLoguin.LoginEspacial(new Propietario(mtbUsuario.Text, tbContrasenia.Text));
                  break;
            }
         }
         catch (Exception errorCap)
         {
            esCorrecto = false;
            infoError.SetError(bLogin, errorCap.Message);
         }

         if (esCorrecto)
         {
            switch (cbTipoUsuario.SelectedItem)
            {
               case nameof(TipoUsuario.Cliente):
                  formularioMostrar = new fCita((Cliente)usuarioLoguear);
                  break;
               case nameof(TipoUsuario.Empleado):
                  formularioMostrar = new fConsultarReparaciones((Empleado)usuarioLoguear);
                  break;
               case nameof(TipoUsuario.Propietario):
                  formularioMostrar = new fReparaciones();
                  break;
            }

            this.Hide();

            formularioMostrar.ShowDialog();

            this.Close();
         }
      }

      private void DesabilitarControlesInicio()
      {
         mtbUsuario.Enabled = false;
         tbContrasenia.Enabled = false;
         bLogin.Enabled = false;
      }

      private void tbNoNulos_TextChanged(object sender, EventArgs e)
      {
         bLogin.Enabled = !string.IsNullOrEmpty(mtbUsuario.Text) && !string.IsNullOrEmpty(tbContrasenia.Text);
      }
   }
}
