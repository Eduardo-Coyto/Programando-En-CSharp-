using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAcercaDeTiposDeDatos.Codigo
{
    internal class Casteos
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Casteo explícito, de entero a double

            var cantidad1 = 7;
            var cantidad2 = 4;

            var division = (double)cantidad1 / cantidad2;

            Console.WriteLine("La división es " + division);

            // Ejemplo 2: Otro casteo explícito

            /* No siempre un número entero puede ser parseado a byte debido a que byte va de 0 a 255 e int va de -2mil millones hasta 2mil millones */

            byte byte1; // 0 hasta 255
            int int1 = 7; // -2 mil millones hasta 2 mil millones

            /* Es IMPORTANTE usar la función checked para comprobar el parseo en caso de desborde tendriamos un error de System.OverflowException*/
            checked
            {
                // casteo el entero a byte explícitamente.
                byte1 = (byte)int1;
            }

            Console.WriteLine(byte1);

            // Ejemplo 3: Casteo implícito, se da cuando no hay peligro en el casteo. Por ej, 1 byte siempre cabe dentro de un int

            byte byte2 = 11;
            int int2;

            int2 = byte2;

            Console.WriteLine(int2);
        }
    }
}
