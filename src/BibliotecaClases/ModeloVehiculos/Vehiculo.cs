using Usuarios;

namespace ModeloVehiculos
{
   public enum Tipo : byte { Turismo, Motocicleta, Motocarro, TraccionAnimal, Autobus, Tractocamion, Tractor, Mixto, Remolque }

   public class Vehiculo
   {
      // CONSTANTES
      #region CONSTANTES
      // NumBastidor
      private const int SIZE_NUMBASTIDOR = 17;

      // Matricula
      // Dependiendo de la matrícula,
      // puede variar el número de caracteres
      private const int MAX_MATRICULA = 8;
      private const int MIN_MATRICULA = 7;

      // Cadenas restantes
      private const int MAX_CADENA = 80;
      private const int MIN_CADENA = 2;

      #endregion

      // MIEMBROS 
      #region MIEMBROS
      // Claves primarias

      // El número de bastidor debe tener
      // obligatiriamente 17 digitos alfanumericos
      private string _numBastidor;
      private string _matricula;

      // Datos
      private string _marca;
      private string _modelo;
      private Tipo _tipo;
      private Cliente _propietario;
      #endregion

      // CONSTRUCTORES
      #region CONSTRUCTORES
      // PK
      public Vehiculo(string numbastidor, string matricula, Cliente propietario)
      {
         NumBastidor = numbastidor;
         Matricula = matricula;
         Propietario = propietario;
      }

      // Completo
      public Vehiculo(string numBastidor, string matricula, string marca, string modelo, Tipo tipo, Cliente propietario)
         : this(numBastidor, matricula, propietario)
      {
         Marca = marca;
         Modelo = modelo;
         Tipo = tipo;
      }
      #endregion

      // PROPIEDADES
      #region PROPIEDADES
      public string NumBastidor
      {
         get
         {
            return _numBastidor;
         }
         set
         {
            ValidarNumBastidor(value);
            _numBastidor = value;
         }
      }

      public string Matricula
      {
         get
         {
            return _matricula;
         }
         set
         {
            ValidarMatricula(value);
            _matricula = value;
         }
      }

      public string Marca
      {
         get
         {
            return _marca;
         }

         set
         {
            ValidarLongitudCadena(value, MAX_CADENA, MIN_CADENA);
            _marca = value;
         }
      }

      public string Modelo
      {
         get
         {
            return _modelo;
         }
         set
         {
            ValidarLongitudCadena(value, MAX_CADENA, MIN_CADENA);
            _modelo = value;
         }
      }

      public Tipo Tipo
      {
         get
         {
            return _tipo;
         }
         set
         {
            _tipo = value;
         }
      }

      public Cliente Propietario
      {
         get
         {
            return _propietario;
         }
         set
         {
            _propietario = value;
         }
      }
      #endregion

      // MÉTODOS
      #region MÉTODOS
      // VALIDACIÓN
      /// <summary>
      /// Preparación de la cadena, valida que no sea cadena vacía
      /// </summary>
      /// <param name="cadena"></param>
      /// <returns>Devuelve la cadena sin espacion y en mayusculas</returns>
      /// <exception cref="CadenaVaciaException"></exception>
      private static string PreparacionCadenas(string cadena)
      {
         if (string.IsNullOrEmpty(cadena)) throw new CadenaVaciaException();
         cadena = cadena.Trim().ToUpper();

         if (string.IsNullOrEmpty(cadena)) throw new CadenaVaciaException();

         return cadena;
      }

      /// <summary>
      /// Validación de matrícula
      /// </summary>
      /// <param name="matricula"></param>
      /// <returns>Devuelve la cadena sin espacion y en mayusculas</returns>
      private static string ValidarMatricula(string matricula)
      {
         try
         {
            // Preparación de la cadena
            matricula = PreparacionCadenas(matricula);

            // Validar maximo y mínimo
            if (matricula.Length < MIN_MATRICULA)
               throw new MinimoInferiorException($"La matrícula es inferior a {MIN_MATRICULA}");

            if (matricula.Length > MAX_MATRICULA)
               throw new MaximoSuperadoException($"La matrícula es superior a {MAX_MATRICULA}");
         }
         catch (Exception error)
         {
            throw new MatriculaErroneaException(error.Message);
         }

         return matricula;
      }

      /// <summary>
      /// Validación del número de bastidor
      /// </summary>
      /// <param name="numBastidor"></param>
      /// <returns>Devuelve la cadena sin espacion y en mayusculas</returns>
      /// <exception cref="ValorIncorrecto"></exception>
      private static string ValidarNumBastidor(string numBastidor)
      {
         try
         {
            // Preparación de la cadena
            numBastidor = PreparacionCadenas(numBastidor);

            // Validar maximo y mínimo
            if (numBastidor.Length != SIZE_NUMBASTIDOR)
               throw new ValorIncorrecto($"El número de bastidor no tiene el tamaño correcto {SIZE_NUMBASTIDOR}");
         }
         catch (Exception error)
         {
            throw new NumBastidorErroneoException(error.Message);
         }

         return numBastidor;
      }

      /// <summary>
      /// Validación personalizada en función de la cadena a validar
      /// </summary>
      /// <param name="cadena"></param>
      /// <returns>Cadena con sin espacions sobrantes</returns>
      private static string ValidarLongitudCadena(string cadena, int MAX, int MIN)
      {
         try
         {
            // Preparación de la cadena
            cadena = cadena.Trim();

            // Validación de maximos y mínimos
            if (cadena.Length < MIN) throw new MinimoInferiorException();
            if (cadena.Length > MAX) throw new MaximoSuperadoException();
         }
         catch (Exception error)
         {
            throw new CadenaErroneaException(error.Message);
         }

         return cadena;
      }

      #endregion
   }

   // EXCEPCIONES PERSONALIZADAS
   #region EXCEPCIONES PERSONALIZADAS

   public class CadenaErroneaException : Exception
   {
      public CadenaErroneaException() : base("Cadena Erronea") { }
      public CadenaErroneaException(string message) : base(message) { }
   }


   public class MatriculaErroneaException : Exception
   {
      public MatriculaErroneaException() : base("Matricula Erronea") { }
      public MatriculaErroneaException(string message) : base(message) { }
   }

   public class NumBastidorErroneoException : Exception
   {
      public NumBastidorErroneoException() : base("NumBastidor Erronea") { }
      public NumBastidorErroneoException(string message) : base(message) { }
   }


   public class CadenaVaciaException : Exception
   {
      public CadenaVaciaException() : base("Cadena vacía") { }
      public CadenaVaciaException(string message) : base(message) { }
   }

   public class MaximoSuperadoException : Exception
   {
      public MaximoSuperadoException() : base("El valor supera al máximo permitido") { }
      public MaximoSuperadoException(string message) : base(message) { }
   }

   public class MinimoInferiorException : Exception
   {
      public MinimoInferiorException() : base("El valor es inferior al mínimo permitido") { }
      public MinimoInferiorException(string message) : base(message) { }
   }

   public class ValorIncorrecto : Exception
   {
      public ValorIncorrecto() : base("El valor no es permitido") { }
      public ValorIncorrecto(string message) : base(message) { }
   }
   #endregion
}