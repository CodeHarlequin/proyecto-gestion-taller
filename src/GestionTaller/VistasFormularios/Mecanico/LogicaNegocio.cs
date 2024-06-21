using BaseDatos;
using InfoGestion;
using ModeloVehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTaller.VistasFormularios.Mecanico
{
    public static class LogicaNegocio
    {
        public static Reparacion[] ObtenerListaReparaciones(string codEmpleado)
        {
            object[] listaObtenida;
            Reparacion[] listaDevolver = null;
            string consultaRealizar;

            // Inializacion 
            consultaRealizar = $"SELECT * FROM Reparaciones WHERE iCodigo_Reparacion IN (SELECT iCodigo_Reparacion FROM MecanicoReparacion WHERE cDni_Mecanico = '{codEmpleado}') AND vEstado = 'Reparacion'";

            // Proceso de optencion de los valores
            listaObtenida = ApiBaseDatos.OptenerListaObjetos(consultaRealizar);

            // Conversion del cada elemento de la lista al tipo adecuado
            if (listaObtenida != null)
                listaDevolver = listaObtenida.Select(obj => (Reparacion)obj).ToArray();

            // Devolucion de la lista
            return listaDevolver;
        }

        public static Reparacion ObtenerDatosReparacion(int codigoReparacion)
        {
            return (Reparacion)ApiBaseDatos.OptenerListaObjetos($"SELECT * FROM Reparaciones WHERE iCodigo_Reparacion = {codigoReparacion}")[0];
        }

        public static Vehiculo ObtenerDatosVehiculo(string numBastidor)
        {
            return (Vehiculo)ApiBaseDatos.OptenerListaObjetos($"SELECT * FROM Vehiculos WHERE cNBastidor = '{numBastidor}'")[0];
        }

        public static Operacion[] ObtenerListaOperaciones()
        {
            object[] listaObtenida;
            Operacion[] listaDevolver = null;
            string consultaRealizar;

            // Inializacion 
            consultaRealizar = $"SELECT * FROM Operaciones";

            // Proceso de optencion de los valores
            listaObtenida = ApiBaseDatos.OptenerListaObjetos(consultaRealizar);

            // Conversion del cada elemento de la lista al tipo adecuado
            if (listaObtenida != null)
                listaDevolver = listaObtenida.Select(obj => (Operacion)obj).ToArray();

            // Devolucion de la lista
            return listaDevolver;
        }

        internal static void AlmacenarOperacionesRealizadas(int codigoRep, Operacion[] listaOperaciones)
        {
            for (int indice = 0; indice < listaOperaciones.Length; indice++)
            {
                ApiBaseDatos.EjecutarInstruccion($"INSERT INTO OperacionReparacion(iCodigo_Reparacion, vNombre_Operacion) VALUES ({codigoRep}, '{listaOperaciones[indice].Nombre}')");
            }
        }

        internal static void ActualizarEstado(int codigoRep)
        {
            ApiBaseDatos.EjecutarInstruccion($"UPDATE Reparaciones SET vEstado = 'Completado' WHERE iCodigo_Reparacion = {codigoRep}");
        }
    }
}
