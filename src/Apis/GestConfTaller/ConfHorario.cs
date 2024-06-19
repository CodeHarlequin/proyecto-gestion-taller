namespace GestConfTaller
{
   public static class ConfHorario
   {
      // Organizacion del fichero
      // Domingo, Lunes, ..., Sabado

      public const string NOMBRE = "Horario";
      public const string EXTENCION = ".h";

      public static void OptenerHorario(int nDiaSemana, out string hInicio, out string hCierre)
      {
         // Recursos locales
         string[] registroAlmacenado;
         string registro;

         // Optiene los registros del fichero
         registroAlmacenado = File.ReadAllLines($"..\\..\\..\\..\\src\\Configuracion\\{NOMBRE}{EXTENCION}");

         // Nos quedamos con el que corresponde con el dia de la semana
         registro = registroAlmacenado[nDiaSemana];

         // Se extrae los valores
         hInicio = registro.Split(';')[0];
         hCierre = registro.Split(';')[1];
      }
   }
}