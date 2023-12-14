using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo
{
    internal class OperacionesUnarias
    {
        public void CodigoDelCurso()
        {
            var cantidad1 = 7;
            var cantidad2 = 5;
            
            //Expresion unaria para multiplicar * -1
            var cantidad1PorMenos1 = -cantidad1; // (-1) * cantidad1

            //Console.WriteLine(cantidad1PorMenos1);

            /*
            
            Hay una importante diferencia entre  "cantidad1++" y "++cantidad1"
             
            Si ++cantidad1 es parte de una expresión perimero sumo 1 y después evaluo la expresión. 
            
            En este caso  "var suma = cantidad1++ + cantidad2;" Evaluar la expresión significa primero sumo cantidad1 + cantidad 2 y al resultado le sumo 1
             
            En este caso  "var suma = ++cantidad1 + cantidad2;" Evaluar la expresión significa que el resultado de la suma es cantidad1 + cantidad 2. El operador ++ solo le suma 1 a la variable "cantidad1" pero no influye en la operación suma

             */
            // equivale a cantidad1 = cantidad1 + 1
            cantidad1++;

            // equivale a cantidad1 = cantidad1 - 1
            cantidad1--;

            //++cantidad1; // cantidad1 = cantidad1 + 1
            //--cantidad1; // cantidad1 = cantidad1 - 1

            /*
            
            Acá representa la diferencia entre "cantidad1++" y "++cantidad1". Tener en cuenta que son expresiones y resultados
            totalmente diferentes
            
            */
            // Ojo: Lo ideal es dividir estas operaciones en varias líneas para que sea más legible
            var suma = cantidad1++ + cantidad2; // 7 + 5 = 12
            // operación 1 => suma = cantidad1 + cantidad2;
            // operación 2 => cantidad1 = cantidad1 + 1

            var suma2 = ++cantidad1 + cantidad2; // 8 + 5 = 13
            // operación 1 => cantidad1 = cantidad1 + 1
            // operación 2 => suma = cantidad1 + cantidad2;

            Console.WriteLine("suma es " + suma); 
            Console.WriteLine("cantidad1 es " + cantidad1);


        }
    }
}
