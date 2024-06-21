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

namespace GestionTaller.VistasFormularios.Propietario
{
   public partial class fSelectTrabajadores : Form
   {
      private Reparacion _repModificar;
      private string _nombreJefeAnterior;

      public fSelectTrabajadores()
      {
         InitializeComponent();
      }

      public Reparacion RepModificar
      {
         get => _repModificar;
         set => _repModificar = value;
      }

      private void fSelectTrabajadores_Load(object sender, EventArgs e)
      {
         string[] infoeEmpleados;

         infoeEmpleados = LogicaNegocio.OptenerListaObjetos<Empleado>()
           .Select(em => $"{em.Dni}.{em.Nombre}.{em.Apellidos}").ToArray();

         RellanarDatosFormulario();

         // Se cargan las distintas listas
         cbJefe.Items.AddRange(infoeEmpleados);
         clbMecanicos.Items.AddRange(infoeEmpleados);
      }

      private void cbJefe_DropDown(object sender, EventArgs e)
      {
         _nombreJefeAnterior = cbJefe.SelectedItem != null
            ? cbJefe.SelectedItem.ToString()
            : null;
      }

      private void cbJefe_SelectedIndexChanged(object sender, EventArgs e)
      {
         // Recursos locales
         string nombreJefeSeleccionado;

         // Inicializacion
         nombreJefeSeleccionado = cbJefe.SelectedItem.ToString();

         // Acciones a realizar
         clbMecanicos.Items.Remove(nombreJefeSeleccionado);
         if (_nombreJefeAnterior != null) clbMecanicos.Items.Add(_nombreJefeAnterior);
      }

      private void bGuardar_Click(object sender, EventArgs e)
      {
         Empleado jefeEncargado;
         Empleado[] listaEmpleadoImplicados;

         try
         {
            // Asignacion del jefe a la reparacion
            jefeEncargado = OptenerJefeAsignado();
            LogicaNegocio.AsignarJefeReparacion(RepModificar, jefeEncargado);

            // Inserte en MecanicosRepara
            listaEmpleadoImplicados = OptenerEmpleadosAsignados();
            LogicaNegocio.AsignarEmpleadosEncargados(RepModificar, listaEmpleadoImplicados);
         }
         catch (Exception ex) { }
      }

      private Empleado[] OptenerEmpleadosAsignados()
      {
         Empleado[] listaEmpleadoAsignados;
         string[] datosDelEmpleado;

         listaEmpleadoAsignados = new Empleado[clbMecanicos.CheckedItems.Count];

         for (int indice = 0; indice < clbMecanicos.Items.Count; indice++)
         {
            datosDelEmpleado = clbMecanicos.Items[indice].ToString().Split(".");

            //listaEmpleadoAsignados[indice] = new Empleado(
            //   datosDelEmpleado[0], // Dni
            //   datosDelEmpleado[1], // Nombre
            //   datosDelEmpleado[2]  // Apellido
            //   );

         }

         return listaEmpleadoAsignados;
      }

      private Empleado OptenerJefeAsignado()
      {
         Empleado jefeAsignado = null;
         string[] datosDelEmpleado;

         // Validar que se alla seleccionado un empleado como jefe
         if (cbJefe.SelectedItem == null)
            throw new Exception("Es necesario asignar un jefe encargado de la reparacion");

         datosDelEmpleado = cbJefe.SelectedItem.ToString().Split(".");

         //jefeAsignado = new Empleado(
         //   datosDelEmpleado[0], // Dni
         //   datosDelEmpleado[1], // Nombre
         //   datosDelEmpleado[2]  // Apellido
         //   );

         return jefeAsignado;
      }

      private void RellanarDatosFormulario()
      {
         tbNBastidor.Text = RepModificar.VehiculoImplicado.NumBastidor;
         tbMatricula.Text = RepModificar.VehiculoImplicado.Matricula;
         tbMarca.Text = RepModificar.VehiculoImplicado.Marca;
         tbModelo.Text = RepModificar.VehiculoImplicado.Modelo;
         tbTipo.Text = RepModificar.VehiculoImplicado.Tipo.ToString();
      }
   }
}
