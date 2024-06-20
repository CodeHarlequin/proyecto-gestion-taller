using BaseDatos;
using ModeloVehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTaller.VistasFormularios.Cliente
{
    public static class LogicaNegocio
    {
        /// <summary>
        /// Insercción a una tabla determinada
        /// </summary>
        /// <param name="tabla">Tabla que querramos insertar</param>
        /// <param name="numb">Datos</param>
        /// <param name="matricula">Datos</param>
        /// <param name="marca">Datos</param>
        /// <param name="modelo">Datos</param>
        /// <param name="tipo">Datos</param>
        /// <param name="dni">Datos</param>
        public static void EjecutarInserccion(string tabla, string numb, string matricula, string marca, string modelo, string tipo, string dni)
        {
            string instruccion = $"INSERT INTO {tabla} VALUES ('{numb}', '{matricula}', '{marca}', '{modelo}', '{tipo}', '{dni}')";

            ApiBaseDatos.EjecutarInstruccion(instruccion);
        }

        public static Vehiculo[] ObtenerListaVehiculos(string dni)
        {
            // Recursos locales 
            string instruccion = $"SELECT * FROM Vehiculos WHERE cDni_Propietario = '{dni}'";

            // Inicializar Lista
            object[] ListaVehiculosClienteOBJ = ApiBaseDatos.OptenerListaObjetos(instruccion);

            // Conversión a Cliente
            Vehiculo[] ListaVehiculosCliente = ListaVehiculosClienteOBJ.OfType<Vehiculo>().ToArray();

            return ListaVehiculosCliente;
        }

        public static Vehiculo ObtenerVehiculo(string dni, string numB)
        {
            string instruccion = $"SELECT * FROM Vehiculos WHERE cDni_Propietario = '{dni}' AND cNBastidor = '{numB}'";
            // Inicializar Lista
            object[] ListaVehiculosClienteOBJ = ApiBaseDatos.OptenerListaObjetos(instruccion);

            // Conversión a Cliente
            Vehiculo[] ListaVehiculosCliente = ListaVehiculosClienteOBJ.OfType<Vehiculo>().ToArray();

            return ListaVehiculosCliente[0];

        }

        public static void InsertarReserva(string fecha, string hora, string descripcion, string dni, string numbastidor)
        {
            ApiBaseDatos.EjecutarInstruccion(
            $"INSERT INTO Reservas " +
            $"(dFecha, tHora, vDescripcion, cDni_Cliente, cNBastidor) VALUES " +
            $"('{fecha}', '{hora}', '{descripcion}', '{dni}', '{numbastidor}')");
        }
        public static string FormatearFecha(string anio, string mes, string dia)
        {
            return anio + "-" + mes + "-" + dia;
        }
    }
}
