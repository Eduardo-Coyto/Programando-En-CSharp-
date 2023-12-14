#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo
{
    internal class ValoresPorDefecto
    {
        public void CodigoDelCurso()
        {
         // por defecto es el número 0
            int edad = default;

            Console.WriteLine("Valor por defecto de int: ");
            Console.WriteLine(edad);

            edad = 8;

            // por defecto es false
            bool hoyEsDomingo = default;

            Console.WriteLine("Valor por defecto de bool: ");
            Console.WriteLine(hoyEsDomingo);

            // por defecto es 0
            decimal precio = default;

            Console.WriteLine("Valor por defecto de decimal: ");
            Console.WriteLine(precio);

            // por defecto es 01-Jan-01 12:00:00 AM
            DateTime fecha = default;

            Console.WriteLine("Valor por defecto de fecha: ");
            Console.WriteLine(fecha);

            // el valor por defecto del strig es null
            string nombre = null;

            Console.WriteLine("Valor por defecto de string: ");
            Console.WriteLine(nombre);
        }
    }
}
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.