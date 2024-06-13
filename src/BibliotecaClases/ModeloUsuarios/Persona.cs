using System.Text.RegularExpressions;

namespace Usuarios
{
   public abstract class Persona
   {
      #region CONSTANTES
      private const string CADENA_DEF = "No establecido";

      private const byte NOMBRE_MAX_LONG = 25;
      private const byte APELLIDO_MAX_LONG = 50;
      private const byte TELEFONO_LONG = 9;
      private const byte CONTRASENIA_LONG = 8;
      #endregion

      #region MIEMBROS
      private string _dni;
      private string _nombre;
      private string _apellidos;
      private string _telefono;
      private string _contrasenia;
      #endregion

      #region CONSTRUCTORES
      public Persona(string dni, string contrasenia)
      {
         Dni = dni;
         Contrasenia = contrasenia;
         _nombre = _apellidos = _telefono = CADENA_DEF;
      }

      public Persona(string dni, string nombre, string apellidos, string telefono, string contrasenia) : this(dni, contrasenia)
      {
         Nombre = nombre;
         Apellidos = apellidos;
         Telefono = telefono;
      }
      #endregion

      #region PROPIEDADES
      public string Dni
      {
         get => _dni;
         set
         {
            ValidarDni(value);
            _dni = value;
         }
      }

      public string Nombre
      {
         get => _nombre;
         set
         {
            ValidarNombre(value);
            _nombre = value;
         }
      }

      public string Apellidos
      {
         get => _apellidos;
         set
         {
            ValidarApellidos(value);
            _apellidos = value;
         }
      }

      public string Telefono
      {
         get => _telefono;
         set
         {
            ValidarTelefono(value);
            _telefono = value;
         }
      }

      public string Contrasenia
      {
         get => _contrasenia;
         set
         {
            ValidarContrasenia(value);
            _contrasenia = value;
         }
      }
      #endregion

      #region METODOS
      private static void ValidarValorEntrada(string cadenaValidar)
      {
         if (string.IsNullOrEmpty(cadenaValidar))
            throw new ArgumentNullException("El valor puede ser una cadena vacia");
      }

      private static void ValidarLimiteCaracteres(string cadenaValidar, byte? nMin, byte? nMax)
      {
         if (nMin != null && cadenaValidar.Length < nMin)
            throw new OverflowException($"El numero de caracteres es inferior al limite: {nMin}");

         if (nMax != null && cadenaValidar.Length > nMax)
            throw new OverflowException($"El numero de caracteres es superior al limite: {nMax}");
      }

      private static void ValidarDni(string dniValidar)
      {
         try
         {
            // Dni no puede ser nulo
            ValidarValorEntrada(dniValidar);

            // Si el dni debe tener un formato adecuado
            if (!Regex.IsMatch(dniValidar, @"\b((\d{8})([A-Z]))"))
               throw new FormatException("No contine un formato no 00000000X");

         }
         catch (Exception errorCap)
         {
            throw new DniInvalidoException(errorCap.Message);
         }
      }

      private static void ValidarNombre(string nombreValidar)
      {
         try
         {
            // Nombre no puede ser null
            ValidarValorEntrada(nombreValidar);

            // Limite de caracteres no puede superiro el limite establecido
            ValidarLimiteCaracteres(nombreValidar, null, NOMBRE_MAX_LONG);
         }
         catch (Exception errorCap)
         {
            throw new NombreInvalidoException(errorCap.Message);
         }
      }

      private static void ValidarApellidos(string apellidosValidar)
      {
         try
         {
            // Nombre no puede ser null
            ValidarValorEntrada(apellidosValidar);

            // Limite de caracteres no puede superiro el limite establecido
            ValidarLimiteCaracteres(apellidosValidar, null, APELLIDO_MAX_LONG);
         }
         catch (Exception errorCap)
         {
            throw new ApellidosInvalidosException(errorCap.Message);
         }
      }

      private static void ValidarTelefono(string telefonoValidar)
      {
         try
         {
            // Telefono no puede ser una cadena null
            ValidarValorEntrada(telefonoValidar);

            // Debera tener obligatoriamente 9 caracteres
            ValidarLimiteCaracteres(telefonoValidar, TELEFONO_LONG, TELEFONO_LONG);
         }
         catch (Exception errorCap)
         {
            throw new TelefonoIvalidoException(errorCap.Message);
         }
      }

      private static void ValidarContrasenia(string contraseniaValidar)
      {
         try
         {
            // Contraseña no puede ser una cadena null
            ValidarValorEntrada(contraseniaValidar);

            // Debera tener obligatoriamente un numero de caracteres o mas
            ValidarLimiteCaracteres(contraseniaValidar, CONTRASENIA_LONG, null);

            // Debera incluir almenos una letra, un caracteres numerico y simbolos
            if (!(contraseniaValidar.Any(char.IsLetter) && contraseniaValidar.Any(char.IsDigit) && contraseniaValidar.Any(char.IsSymbol)))
               throw new FormatException("Debera incluir letras simbolos y dijitos numericos");
         }
         catch (Exception errorCap)
         {
            throw new ContraseniaInvalidaException(errorCap.Message);
         }
      }

      #endregion
   }

   #region EXCEPCIONES PERSONALIZADAS

   public class DniInvalidoException : Exception
   {
      public DniInvalidoException(string mensajeError) : base($"Dni: {mensajeError}") { }
   }

   public class NombreInvalidoException : Exception
   {
      public NombreInvalidoException(string mensajeError) : base($"Nombre: {mensajeError}") { }
   }

   public class ApellidosInvalidosException : Exception
   {
      public ApellidosInvalidosException(string mensajeError) : base($"Dni: {mensajeError}") { }
   }

   public class TelefonoIvalidoException : Exception
   {
      public TelefonoIvalidoException(string mensajeError) : base($"Telefono: {mensajeError}") { }
   }

   public class ContraseniaInvalidaException : Exception
   {
      public ContraseniaInvalidaException(string mensajeError) : base($"Contrasenia: {mensajeError}") { }
   }
   #endregion
}