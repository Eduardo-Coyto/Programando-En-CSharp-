using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Ejercicios
{
    /*
    Implementa un algoritmo que te permita determinar el número más grande dentro de un arreglo de enteros. 
    Debes asignar el resultado a la variable resultado. Si el arreglo numeros tiene cero elementos, pues debes asignarle null a resultado.

    Tu código va debajo del comentario y encima del return.
     */

    public class NumeroMayor
    {
        public int? DeterminarElNumeroMayor(int[] numeros)
        {
            // Tu código debajo de esta línea

            int? resultado = 0;

            /* Verifico si el arreglo trae elementos */
            if (numeros.Length == 0)
            {
                return null;
            }

            /* cargo el primer número como la posible solución y realizo iteración para comprobar si el siguiente numero es mayor */
            resultado = numeros[0];
            foreach (int numero in numeros)
            {
                if (numero > resultado)
                {
                    resultado = numero;
                }
            }

            return resultado;
        }
    }
}
