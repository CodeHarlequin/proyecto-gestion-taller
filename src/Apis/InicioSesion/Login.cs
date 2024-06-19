using BaseDatos;
using GestConfTaller;
using Usuarios;

namespace InicioSesion
{
   public static class ApiLoguin
   {
      public static void Login<TClaPersona>(object usuarioVerificar) where TClaPersona : Persona
      {
         // Recursos locales
         Persona usuarioLoguear = (TClaPersona)usuarioVerificar;
         string consultaRealizar;

         try
         {
            // Construye la consulta a realizar 
            consultaRealizar = ConstruirConsulta(usuarioLoguear);

            // Ejecutar la consulta sobre la base de datos 
            usuarioLoguear = (TClaPersona)ApiBaseDatos.OptenerListaObjetos(consultaRealizar)[0];

            // Comprobara la contraseña del usaurio obtenido
            if (usuarioLoguear.Contrasenia != usuarioLoguear.Contrasenia)
               throw new ContraseniaIncorrectaException();

         }
         // En caso de devolver un array vacio no esposible acceder a la posicion 0 significara que el usuario no existe
         catch (Exception error) // La deteccion de otro error 
         {
            throw new Exception($"Login:{error.Message}");
         }
      }

      public static void LoginEspacial(Propietario propietarioValidar)
      {
         // Recursos locales
         Propietario propietarioOriginal;

         try
         {
            // Optener propietario original
            propietarioOriginal = DatosPropietario.OptenePropietario();

            // Validamos lso valores
            if ((propietarioValidar.Contrasenia != propietarioOriginal.Contrasenia) && (propietarioValidar.Usuario != propietarioOriginal.Usuario))
               throw new CredencialesIncorrectasException();
         }
         catch (Exception error) // La deteccion de otro error 
         {
            throw new Exception($"Login:{error.Message}");
         }
      }

      private static string ConstruirConsulta(Persona usuarioVerificar)
      {
         // Recursos locales
         string nombreTabla = "";
         string consultaDevolver = "";

         // Evaluacion del tipo de clase (Heredan de Persona)
         switch (usuarioVerificar)
         {
            case Cliente:
               nombreTabla = "Clientes ";
               break;
            case Empleado:
               nombreTabla = "Mecanicos";
               break;
         }

         // Se formatea la consulta a realizar
         consultaDevolver = $"SELECT * FROM {nombreTabla} " +
            $"WHERE cDni = '{usuarioVerificar.Dni}' AND vContrasenia = '{usuarioVerificar.Contrasenia}'";

         return consultaDevolver;
      }
   }

   public class ContraseniaIncorrectaException : Exception
   {
      public ContraseniaIncorrectaException() : base("La contrasela es incorrecta") { }
   }

   public class CredencialesIncorrectasException : Exception
   {
      public CredencialesIncorrectasException() : base("La contrasela o el usuario no son correctos") { }
   }
}