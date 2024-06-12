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
      public enum Estado { Activo, Finalizado }

      #region CONSTANTES
      private const byte CODIGO_MIN_LONG = 5;
      private const Estado ESTADO_DEF = Estado.Activo;
      #endregion

      #region MIEMBROS
      private string _codigoIdentificacion;

      // Datos para indentificar a los responsables involucrados      
      private Vehiculo _vehiculoImplicado;
      private Empleado _jefeMecanico;
      private Empleado[] _listaMecanicos;

      // Datos que determinta la informacion de la resparacion
      private Estado _estado;
      private Operacion[] _listaOperaciones;
      private string _infoAdicional;

      // Fecha para idicar el inicio y el fin
      private DateTime _fechaInicio;
      private DateTime _fechaFin;
      #endregion

      #region CONSTRUCTORES
      public Reparacion(string codigo, Vehiculo vehiculo)
      {
         CodigoIdentificacion = codigo;
         VehiculoImplicado = vehiculo;
         _estado = ESTADO_DEF;
      }

      public Reparacion(string codigo, Vehiculo vehiculo, Operacion[] operaciones, string descripcion)
         : this(codigo, vehiculo)
      {
         ListaOperaciones = operaciones;
         InformacionAdicional = descripcion;
      }

      public Reparacion(string codigo, Vehiculo vehiculo, Empleado jefe, Empleado[] mecanicosEncargados, string descripcion)
         : this (codigo, vehiculo)
      {
         JefeMecanico = jefe;
         ListaMecanicos = mecanicosEncargados;
         InformacionAdicional = descripcion;
      }
      #endregion

      #region PROPIEDADES
      public string CodigoIdentificacion 
      { 
         get => _codigoIdentificacion;
         set
         {
            ValidarCodigoIdentificacion(value);
            _codigoIdentificacion = value;
         }
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

      public Estado EstadoRep
      {
         get => _estado;
         set => _estado = value;
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
      
      public DateTime FechaInicio 
      { 
         get => _fechaInicio;
         set
         {
            ValidarFecha(value);
            _fechaInicio = value;
         }
      }

      public DateTime FechaFin 
      { 
         get => _fechaFin;
         set
         {
            ValidarFecha(value);
            _fechaFin = value;
         }
      }
      #endregion

      #region METODOS
      private static void ValidarCodigoIdentificacion(string codigoValidar)
      {
         try
         {
            // Validar si el valor es nulo
            codigoValidar = Comprobaciones.ValidarValorEntrada(codigoValidar);

            // Validar limite de caracteres
            Comprobaciones.ValidarLimiteCaracteres(codigoValidar, CODIGO_MIN_LONG, CODIGO_MIN_LONG);
         }
         catch (Exception errorCap) 
         {
            throw new CodigoInvalidoException(errorCap.Message);
         }
      }

      private static void ValidarFecha(DateTime fechaValidar)
      {
         try
         {
            // Validar que la fecha se a mayor a la actual
            if (fechaValidar < DateTime.Now)
               throw new Exception("Inferior al la fecha actual");
         }
         catch (Exception errorCap)
         {
            throw new FechaInvalidaException(errorCap.Message);
         }
      }
      #endregion
   }

   #region EXCEPCIONES PERSONALIZADAS
   public class CodigoInvalidoException : Exception
   {
      public CodigoInvalidoException(string mensajeError) : base($"Codigo:  {mensajeError}") { }
   }

   public class FechaInvalidaException : Exception
   {
      public FechaInvalidaException(string mensajeError) : base($"Fecha:  {mensajeError}") { }
   }
   #endregion
}
