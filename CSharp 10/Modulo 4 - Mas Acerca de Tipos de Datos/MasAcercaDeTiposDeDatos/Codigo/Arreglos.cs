using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAcercaDeTiposDeDatos.Codigo
{
    internal class Arreglos
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Arreglo de char's

            /* Defino arreglo de char */
            char[]? vocales = new char[5];

            /* vocales = null; Los arreglos son tipo de referencia */

            vocales[0] = 'a'; // Primer elemento
            vocales[1] = 'e'; // Segundo elemento
            vocales[2] = 'i'; // Tercer elemento
            vocales[3] = 'o'; // Cuarto elemento
            vocales[4] = 'u'; // Quinto elemento

            var segundaVocal = vocales[1];

            Console.WriteLine(segundaVocal); // e

            //var unaVocalMagica = vocales[5]; // no hay sexto elemento

            foreach (var vocal in vocales)
            {
                Console.WriteLine(vocal);
            }

            // Ejemplo 2: Arreglo de enteros

            var primeros6Numeros = new int[] { 1, 2, 3, 4, 5, 6 };

            foreach (var numero in primeros6Numeros)
            {
                Console.Write($"{numero} ");
            }
        }
    }
    /*
     
    var vocales = new char ['a', 'e', 'i', 'o', 'u'];

    var segundaVocal = vocales[1];
    var ultimaVocal = vocales[^1];  con ^ me posisiono en el final del arreglo
    var penultimaVocal = vocales[^2];
     
    */
}

