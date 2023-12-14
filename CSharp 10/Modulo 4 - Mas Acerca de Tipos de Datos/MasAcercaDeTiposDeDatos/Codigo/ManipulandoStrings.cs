using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAcercaDeTiposDeDatos.Codigo
{
    internal class ManipulandoStrings
    {
        public void CodigoDelCurso()
        {
            var nombre = "Felipe";

             /* las funciones ToUpper y ToLower no modifican el valor de la variable original */
            var nombreEnMayúsculas = nombre.ToUpper(); // FELIPE

            var nombreEnMinúsculas = nombre.ToLower(); // felipe

            var longitud = nombre.Length; // 6

            Console.Write("¿Desea terminar el programa? (y/n) ");
            var entradaUsuario = Console.ReadLine();

            /* 
             
            Función Trim es para eliminar los espacios en blanco al principio y al final del string. Además tiene la funcionalidad de eliminar otros string.
             
            El elemento "?" en entradaUsuario? verifica que no sea una variable nula 
             
            */

            if (entradaUsuario?.ToLower().Trim() == "y")
            {
                Console.WriteLine("Terminando el programa");
            }
            else
            {
                Console.WriteLine("El programa no va a terminar");
            }

            var mensaje = "123Hola, ¿Cómo estás?87";
            char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var mensajeArreglado = mensaje.Trim(numeros);
            Console.WriteLine(mensajeArreglado);

            long monto1 = 123;
            long monto2 = 4;
            long monto3 = 123456789L;
            long monto4 = 1234567890L;

            /* Función PadLeft es para rellenar hasta que tenga una cierta cantidad de caracteres con el valor que quiera */

            Console.WriteLine(monto1.ToString().PadLeft(10, '0'));
            Console.WriteLine(monto2.ToString().PadLeft(10, '0'));
            Console.WriteLine(monto3.ToString().PadLeft(10, '0'));
            Console.WriteLine(monto4.ToString().PadLeft(10, '0'));
        }
    }
}
