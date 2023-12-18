using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Codigo
{
    /*
    Los métodos de extensión obligatoriamente deben ser static. Es como le estuvieramos integrando métodos a una clase.
    */
    internal static class ExtensionesString
    {
        /* Para agregar funcionalidad al método string debo agregar "this" */
        internal static int ContarPalabras(this string? s, int valorPorDefecto = -1)
        {
            if (string.IsNullOrWhiteSpace(s)) // IsNullOrWhiteSpace nulo o vacio
            {
                return valorPorDefecto;
            }

            /* 
            Environment.NewLine permite definir el texto según la linea, o sea, 
            felipe
            gavilán
            son dos textos en lineas diferentes
            */
            var separadores = new string[] { " ", Environment.NewLine };

            // StringSplitOptions.RemoveEmptyEntries remover las entradas vacias
            var palabras = s.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

            return palabras.Length;
        }
    }

    internal class MetodosDeExtension
    {
        public void CodigoDelCurso()
        {
            var mensaje = @"Este es un mensaje, 

atentamente: felipe";

            // Podemos usar null para probar el valor por defecto
            //string? mensaje = null;

            // Usando método de extensión
            var cantidadPalabras = mensaje.ContarPalabras(valorPorDefecto: -2);

            // Sin usar método de extensión
            //var cantidadPalabras_V2 = ExtensionesString.ContarPalabras(mensaje);

            Console.WriteLine("Cantidad palabras " + cantidadPalabras);
        }
    }
}
