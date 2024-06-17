using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
   public static class DiccionarioCampos
   {
      public static string OptenerNombreColumna(ConstructorInfo constructor, ParameterInfo parametro)
      {
         // Recursoso locales
         string nombreColumna = "";
         string nombreClase;
         string nombreParam;

         // Inicalizacion
         nombreParam = parametro.Name;
         nombreClase = constructor.DeclaringType.Name;

         switch (nombreClase)
         {
            // Optiene el nombre de la columna de la base de datos apartir del nombre
            // del parametro indicado 
            case "Cliente":
               nombreColumna = camposTablaClientes.GetValueOrDefault(nombreParam);
               break;
            case "Empleado":
               nombreColumna = camposTablaEmpleados.GetValueOrDefault(nombreParam);
               break;
            case "Vehiculo":
               nombreColumna = camposTablaVehiculos.GetValueOrDefault(nombreParam);
               break;
            case "Cita":
               nombreColumna = camposTablaReservas.GetValueOrDefault(nombreParam);
               break;
            case "Reparacion":
               nombreColumna = camposTablaReparaciones.GetValueOrDefault(nombreParam);
               break;
            case "Operacion":
               nombreColumna = camposTablaOperaciones.GetValueOrDefault(nombreParam);
               break;
         }

         return nombreColumna;
      }

      //
      // EQUIVALENCIA NOMBRE PARAMETRO CON EL NOMBRE DE LA COLUMNA EN BD
      //

      // Nombre del paramatro | Nombre del la columna

      private static Dictionary<string, string> camposTablaClientes = new Dictionary<string, string>
      {
         { "dni" , "cDni" },
         { "nombre" , "vNombre" },
         { "apellidos", "vApellidos"},
         { "telefono", "cTelefono" },
         { "contrasenia", "vContrasenia" }
      };

      private static Dictionary<string, string> camposTablaEmpleados = new Dictionary<string, string>
      {
         { "dni" , "cDni" },
         { "nombre" , "vNombre" },
         { "apellidos", "vApellidos"},
         { "telefono", "cTelefono" },
         { "contrasenia", "vContrasenia" },
         { "especialidad", "vEspecialidad" }
      };

      private static Dictionary<string, string> camposTablaVehiculos = new Dictionary<string, string>
      {
         { "numBastidor" , "cNBastidor" },
         { "matricula" , "cMatricula" },
         { "marca", "vMarca"},
         { "modelo", "vModelo" },
         { "tipo", "vTipo" },
         { "propietario", "cDni_Propietario"}
      };

      private static Dictionary<string, string> camposTablaReservas = new Dictionary<string, string>
      {
         { "presupuesto" , "fPresupuesto" },
         { "fecha", "dFecha"},
         { "hora", "tHora" },
         { "solicitante", "cDni_Cliente" },
         { "vehiculo", "cNBastidor"}
      };

      public static Dictionary<string, string> camposTablaReparaciones = new Dictionary<string, string>
      {
         { "codigoRep", "iCodigo_Reparacion" },
         { "fechaInicio", "dFecha_Inicio" },
         { "fechaFin", "dFecha_Fin" },
         { "estado", "vEstado" },
         { "operaciones", "iCodigo_Reparacion" },
         { "infoAdicional", "vObservaciones" },
         { "presupuesto", "fPresupuesto" },
         { "jefe", "cDni_JefeMecanico" },
         { "mecanicosEncargados", "iCodigo_Reparacion" }, // Permite indentificar los empleado que una reparacion en concreto
         { "vehiculo", "cNBastidor" }
      };

      public static Dictionary<string, string> camposTablaOperaciones = new Dictionary<string, string>
      {
         { "nombre", "vNombre" },
         { "descripcion", "vDescripcion" }
      };
   }
}
