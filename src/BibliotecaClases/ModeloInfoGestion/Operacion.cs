
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoGestion
{
   public class Operacion
   {
      #region CONSTANTES
      private const byte NOMBRE_MAX_LONG = 25;
      private const byte DESCRIP_MAX_LONG = 50;

      private const string CADENA_DEF = "No establecido";
      #endregion

      #region MIEMBROS
      private string _nombre;
      private string _descripcion;
      #endregion

      #region CONSTRUCTORES
      public Operacion(string nombre)
      {
         Nombre = nombre;
         Descripcion = CADENA_DEF;
      }

      public Operacion(string nombre, string descripcion) : this (nombre)
      {
         Descripcion = descripcion;
      }
      #endregion

      #region PROPIEDADES
      public string Nombre 
      { 
         get => _nombre;
         set
         {
            ValidarNombre(value);
            _nombre = value;
         }
      }

      public string Descripcion 
      { 
         get => _descripcion;
         set
         {
            ValidarDescripcion(value);
            _descripcion = value;
         }
      }

      #endregion

      #region METODOS
      private static void ValidarNombre(string nombreValidar)
      {
         try
         {
            // Nombre no puede ser null
            nombreValidar = CompDatos.ValidarValorEntrada(nombreValidar);

            // Limite de caracteres no puede superiro el limite establecido
            CompDatos.ValidarLimiteCaracteres(nombreValidar, null, NOMBRE_MAX_LONG);
         }
         catch (Exception errorCap)
         {
            throw new NombreInvalidoException(errorCap.Message);
         }
      }

      private static void ValidarDescripcion(string descripcionValidar)
      {
         try
         {
            // Descripcion no puede ser null
            descripcionValidar = CompDatos.ValidarValorEntrada(descripcionValidar);

            // Limite de caracteres no puede superiro el limite establecido
            CompDatos.ValidarLimiteCaracteres(descripcionValidar, null, DESCRIP_MAX_LONG);
         }
         catch (Exception errorCap)
         {
            throw new DescripcionInvalidoException(errorCap.Message);
         }
      }
      #endregion
   }

   #region EXCEPCIONES PERSONALIZADAS
   public class NombreInvalidoException : Exception
   {
      public NombreInvalidoException(string mensajeError) : base($"Nombre: {mensajeError}") { }
   }

   public class DescripcionInvalidoException : Exception
   {
      public DescripcionInvalidoException(string mensajeError) : base($"Descripcion: {mensajeError}") { }
   }
   #endregion
}
