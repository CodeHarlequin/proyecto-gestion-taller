using BaseDatos;
using InfoGestion;
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

namespace GestionTaller.VistasFormularios.Mecanico
{
    public partial class fModificarReparacion : Form
    {
        private Reparacion _reparacion;

        public Reparacion ReparacionSeleccionada
        {
            get => _reparacion;
            set => _reparacion = value;
        }

        public fModificarReparacion()
        {
            InitializeComponent();
        }

        private void fModificarReparacion_Load(object sender, EventArgs e)
        {
            // Cargar los datos en los textbox
            CargarDatosVehiculo();

            // Cargar la lista de operaciones
            CargarListaOperaciones();

            // Marcar operaciones realizadas
            MarcarOperacionesYaRealizadas();
        }

        private void CargarDatosVehiculo()
        {
            // Recursos
            Vehiculo vehiculoSeleccionado;

            // Obtenemos los de la base de datos
            vehiculoSeleccionado = LogicaNegocio.ObtenerDatosVehiculo(ReparacionSeleccionada.VehiculoImplicado.NumBastidor);

            // Establecer los datos en el formulario
            tbNBastidor.Text = vehiculoSeleccionado.NumBastidor;
            tbMatricula.Text = vehiculoSeleccionado.Matricula;
            tbMarca.Text = vehiculoSeleccionado.Marca;
            tbModelo.Text = vehiculoSeleccionado.Modelo;
            tbTipo.Text = vehiculoSeleccionado.Tipo.ToString();
        }

        private void CargarListaOperaciones()
        {
            // Establecer los datos en el cheklistbox
            clbOperaciones.Items.AddRange(LogicaNegocio.ObtenerListaOperaciones().Select(op => op.Nombre).ToArray());
        }

        private void MarcarOperacionesYaRealizadas()
        {
            // Recursos locales
            string nombreOperacion;
            bool noHayOperaciones = false;

            // Se itera por cada check de la lista
            for (int indice = 0; indice < clbOperaciones.Items.Count && !noHayOperaciones; indice++)
            {
                try
                {
                    nombreOperacion = ReparacionSeleccionada.ListaOperaciones[indice].Nombre;

                    if (nombreOperacion == clbOperaciones.Items[indice].ToString())
                    {
                        clbOperaciones.SetItemChecked(indice, true);
                        clbOperaciones.SetItemCheckState(indice, CheckState.Indeterminate);                      
                    }
                }
                catch
                {
                    noHayOperaciones = true;
                }
            }
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            // Recursos locales
            string[] listaCheckSelecionados;
            string[] listaCheck;
            int indiceAux;
            CheckState estado = CheckState.Checked;
            Operacion[] listaOperaciones;


            // Iniaizacion
            // Optine la lista de check marcados
            listaCheck = clbOperaciones.CheckedItems.Cast<string>().ToArray();

            // Crea una nuva lista con aquellos check que se han marcado en el momento
            listaCheckSelecionados = Enumerable.Range(0, listaCheck.Length)
                .Where(indice => clbOperaciones.GetItemCheckState(indice) != CheckState.Indeterminate)
                .Select(indice => listaCheck[indice])
                .ToArray(); 

            // Estable c un tamaño al array
            listaOperaciones = new Operacion[listaCheckSelecionados.Length];


            for (int indice = 0; indice < listaCheckSelecionados.Length; indice++)
            {
                listaOperaciones[indice] = new Operacion(
                    listaCheckSelecionados[indice]
                    );
            }

            try
            {
                LogicaNegocio.AlmacenarOperacionesRealizadas(ReparacionSeleccionada.CodigoRep, listaOperaciones);     
            }
            catch { }

            this.Close();
        }

        private void clbOperaciones_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            bGuardar.Enabled = true;

            if (e.CurrentValue == CheckState.Indeterminate)
            {
                e.NewValue = e.CurrentValue;
            }
        }
    }
}
