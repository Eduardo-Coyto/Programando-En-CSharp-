using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo
{
    internal class ParametrosComoReferencia
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Usando ref para tipos de valor

            int cantidad = 5;

            void Duplicar(ref int n)
            {
                n *= 2;
                Console.WriteLine("El valor dentro de la función es: " + n);
            }

            /*
            Si quiero que la variable original tenga una alteración debe tener el prefijo "ref". 
            Por lo tanto, la variable ingresa a la función como parámentro pero sufre el cambio que se le ejecuta dentro de la función.
            */
            Console.WriteLine("El valor fuera de la función es: " + cantidad);
            Duplicar(ref cantidad);
            Console.WriteLine("El valor fuera de la función es: " + cantidad);

            // Ejemplo 2: Tipos de referencia
            /* 
            
            Los arrays son tipo de referencia y por lo tanto de forma automatica permite registrar los cambios
            foreach no me permite recorrer un arreglo y modificar los valores de los mismos. 
            Para realizar cambios en la colección debo usar for para recorrerlo y efectuar cambios. 
            
            */
            var numeros = new int[] { 1, 2, 3 };

            void DuplicarArreglo(int[] numeros)
            {
                for (int i = 0; i < numeros.Length; i++)
                {
                    numeros[i] *= 2;
                }
            }

            void ImprimirArreglo(int[] numeros)
            {
                foreach (var numero in numeros)
                {
                    Console.Write($"{numero} ");
                }
            }

            Console.Write("Valores del arreglo antes de la duplicación: ");
            ImprimirArreglo(numeros);

            Console.WriteLine();

            DuplicarArreglo(numeros);

            Console.Write("Valores del arreglo después de la duplicación: ");
            ImprimirArreglo(numeros);

            // Ejemplo 3: Y los strings?
            /*
            Los strings son imutables, por lo tanto cada vez que hago una operación sobre un strig estoy creando un nuevo string
            */

            void PonerEnMayúsculas(string nombre)
            {
                nombre = nombre.ToUpper(); // Esto lo que crea es un nuevo string
                Console.WriteLine("El valor dentro de la función es " + nombre);
            }

            var nombre = "Felipe";

            Console.WriteLine("El valor fuera de la función es " + nombre);
            PonerEnMayúsculas(nombre);
            Console.WriteLine("El valor fuera de la función es " + nombre);
        }
    }
}
