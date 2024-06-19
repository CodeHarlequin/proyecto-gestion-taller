using BaseDatos;
using InfoGestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios;

namespace GestionTaller.VistasFormularios.Propietario
{
   public static class LogicaNegocio
   {
      public static TObj[] OptenerListaObjetos<TObj>()
      {
         object[] listaObtenida;
         TObj[] listaDevolver = null;
         string consultaRealizar = "";

         // Inializacion 
         switch (typeof(TObj).Name)
         {
            case nameof(Reparacion): // iCodigo_Reparacion, cNBastidor, dFecha_Inicio, dFecha_Fin, vEstado, fPresupuesto
               consultaRealizar = "SELECT * FROM Reparaciones";
               break;
            case nameof(Empleado):
               consultaRealizar = "SELECT * FROM Mecanicos";
               break;
         }

         // Proceso de optencion de los valores
         listaObtenida = ApiBaseDatos.OptenerListaObjetos(consultaRealizar);

         // Conversion del cada elemento de la lista al tipo adecuado
         if (listaObtenida != null)
            listaDevolver = listaObtenida.Select(obj => (TObj)obj).ToArray();

         // Devolucion de la lista
         return listaDevolver;
      }

      public static Reparacion OptenerDatosReparacion(int codigoReparacion)
      {
         return (Reparacion)ApiBaseDatos.OptenerListaObjetos($"SELECT * FROM Reparaciones WHERE iCodigo_Reparacion = {codigoReparacion}")[0];
      }

      public static void ActualizarPresupuesto(Reparacion reparacionModificar)
      {
         ApiBaseDatos.EjecutarInstruccion($"UPDATE Reparaciones SET fPresupuesto = {reparacionModificar.Presupuesto} WHERE iCodigo_Reparacion = '{reparacionModificar.CodigoRep}'");
      }
   }
}
