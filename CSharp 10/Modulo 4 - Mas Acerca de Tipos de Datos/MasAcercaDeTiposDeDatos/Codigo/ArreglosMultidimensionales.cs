using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAcercaDeTiposDeDatos.Codigo
{
    internal class ArreglosMultidimensionales
    {
        public void CodigoDelCurso()
        {
            /* int[,] con esto defino arreglo bidimensional */
            int[,] matriz = new int[2, 2];

            //Console.WriteLine(matriz.Rank); // 2   Con esto obtengo la dimensión del arreglo

            matriz[0, 0] = 1; // primera fila, primera columna
            matriz[0, 1] = 2; // primera fila, segunda columna
            matriz[1, 0] = 3; // segunda fila, primera columna
            matriz[1, 1] = 4; // segunda fila, segunda columna

            var elemento01 = matriz[0, 1]; // 2 Con esto accedo al elemento de la matriz que es 2

            int[,] matriz2 = new int[,]
            {
                {5,6 }, // primera fila
                {7, -5 }, // segunda fila
                {8, 9 } // tercera fila
            };

            for (int fila = 0; fila < matriz2.GetLength(0); fila++) /* GetLength me permite obtener la cantidad de elementos que cada dimension puede tener, o sea, la cantidad de filas */
            {
                for (int columna = 0; columna < matriz2.GetLength(1); columna++) /* GetLength me permite obtener la cantidad de elementos que cada dimension puede tener, o sea, la cantidad de columnas */
                {
                    Console.Write($"{matriz2[fila, columna]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
