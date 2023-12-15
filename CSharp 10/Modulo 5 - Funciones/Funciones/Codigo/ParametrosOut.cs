using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo
{
    internal class ParametrosOut
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: introducción a out
            /*
            Otra forma de pasar un valor como referencia a una función es utilizando "out". La diferencia entre out y ref es que out te permite
            utilizar varibales que aún no han sido inicializadas. El parámetro out debe ser usado dentro de una función como no inicializado.
            El parámetro "out" te permite extraer de los valores de la función.
            */

            // variable cantidad sin inicializar    
            int cantidad;

            void DuplicarYTriplicar(int operando, out int resultadoDuplo, out int resultadoTriplo)
            {
                resultadoDuplo = operando * 2;
                resultadoTriplo = operando * 3;
            }

            // variable sin inicializar
            int resultadoDuplo, resultadoTriplo;

            DuplicarYTriplicar(3, out resultadoDuplo, out resultadoTriplo);
            Console.WriteLine("El doble es: " + resultadoDuplo);
            Console.WriteLine("El triple es: " + resultadoTriplo);

            // Ejemplo 2: TryParse

            int numero;
            string numeroString = "7";

            // con la función TryParse se va a intentar parsear el numeroString y en caso de ser exitoso el parseo se le asigna a la variable out el valor de la variable paseada.
            if (int.TryParse(numeroString, out numero))
            {
                Console.WriteLine("El número es " + numero);
            }
            else
            {
                Console.WriteLine("Formato incorrecto");
            }
        }
    }
}
