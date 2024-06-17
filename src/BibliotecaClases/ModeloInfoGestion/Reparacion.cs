using ModeloVehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios;

namespace InfoGestion
{
   public class Reparacion
   {
      /*
       * Diagnostico - Al crear una una reparacion
       * Cotizacion - El propietario evalua un precio a la reparacion
       * Aprobacion_Cliente - El cliente esta de acuerdo con la reparacion a realizar
       * Reparacion
       * Completado
       */
      public enum Estado { Diagnostico, Cotizacion, Aprobacion_Cliente, Reparacion, Completado }

      #region CONSTANTES
      #endregion

      #region MIEMBROS
      private int _codigoRep;

      // Datos para indentificar a los responsables involucrados      
      private Vehiculo _vehiculoImplicado;
      private Empleado _jefeMecanico;
      private Empleado[] _listaMecanicos;

      // Datos que determinta la informacion de la resparacion
      private Estado _estadoRep;
      private Operacion[] _listaOperaciones;
      private string _infoAdicional;
      private float _presupuesto;

      // Fecha para idicar el inicio y el fin
      private DateTime? _fechaInicio;
      private DateTime? _fechaFin;
      #endregion

      #region CONSTRUCTORES
      // Utilizara para asignar personar a la reparacion
      public Reparacion(Vehiculo vehiculo, Empleado jefe, Empleado[] mecanicosEncargados)
      {
         VehiculoImplicado = vehiculo;
         JefeMecanico = jefe;
         ListaMecanicos = mecanicosEncargados;
      }

      // Utilizara al modificar una reparacion
      public Reparacion(Vehiculo vehiculo, Operacion[] operaciones, string infoAdicional)
      {
         VehiculoImplicado = vehiculo;
         ListaOperaciones = operaciones;
         InformacionAdicional = infoAdicional;
      }

      // Utilizado para optener toda la informacion de la reparaciones
      public Reparacion(int codigoRep, Vehiculo vehiculo, DateTime fechaInicio, DateTime fechaFin, Operacion[] operaciones, string estado, string infoAdicional, float presupuesto)
         : this(vehiculo, operaciones, infoAdicional)
      {
         Presupuesto = presupuesto;
         CodigoRep = codigoRep;
         FechaInicio = fechaInicio;
         FechaFin = fechaFin;
         EstadoRep = (Estado)Array.IndexOf(Enum.GetNames(typeof(Estado)), estado);
      }

      #endregion

      #region PROPIEDADES
      public int CodigoRep
      {
         get => _codigoRep;
         set => _codigoRep = value;
      }

      public Vehiculo VehiculoImplicado
      {
         get => _vehiculoImplicado;
         set => _vehiculoImplicado = value;
      }

      public Empleado JefeMecanico
      {
         get => _jefeMecanico;
         set => _jefeMecanico = value;
      }

      public Empleado[] ListaMecanicos
      {
         get => _listaMecanicos;
         set => _listaMecanicos = value;
      }

      public DateTime? FechaInicio
      {
         get => _fechaInicio;
         set => _fechaInicio = value;
      }

      public DateTime? FechaFin
      {
         get => _fechaFin;
         set => _fechaFin = value;
      }

      public Estado EstadoRep
      {
         get => _estadoRep;
         set
         {
            if (!Enum.IsDefined(typeof(Estado), value))
               throw new Exception();

            _estadoRep = value;
         }
      }

      public Operacion[] ListaOperaciones
      {
         get => _listaOperaciones;
         set => _listaOperaciones = value;
      }

      public string InformacionAdicional
      {
         get => _infoAdicional;
         set => _infoAdicional = value;
      }

      public float Presupuesto
      {
         get => _presupuesto;
         set => _presupuesto = value;
      }
      #endregion

      #region METODOS
      //public override string ToString()
      //{
      //   return $"{FechaInicio}, {FechaFin}, {Presu}"
      //}

      #endregion
   }

   #region EXCEPCIONES PERSONALIZADAS
   public class CodigoInvalidoException : Exception
   {
      public CodigoInvalidoException(string mensajeError) : base($"Codigo:  {mensajeError}") { }
   }
   #endregion
}
