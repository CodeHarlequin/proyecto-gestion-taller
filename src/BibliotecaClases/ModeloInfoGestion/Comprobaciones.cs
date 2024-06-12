using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoGestion
{
   // Solo va a poder ser accededido dentro de su mismo namespace
   internal static class Comprobaciones
   {
      internal static string ValidarValorEntrada(string cadenaValidar)
      {
         // Preparacion de la cadena
         cadenaValidar = cadenaValidar.Trim();

         // Validacion si la cadena es nula
         if (string.IsNullOrEmpty(cadenaValidar))
            throw new ArgumentNullException("El valor puede ser una cadena vacia");

         // Devuelve la cadena validada y formateada
         return cadenaValidar;
      }

      internal static void ValidarLimiteCaracteres(string cadenaValidar, byte? nMin, byte? nMax)
      {
         if (nMin != null && cadenaValidar.Length < nMin)
            throw new OverflowException($"El numero de caracteres es inferior al limite: {nMin}");

         if (nMax != null && cadenaValidar.Length > nMax)
            throw new OverflowException($"El numero de caracteres es superior al limite: {nMax}");
      }
   }
}
