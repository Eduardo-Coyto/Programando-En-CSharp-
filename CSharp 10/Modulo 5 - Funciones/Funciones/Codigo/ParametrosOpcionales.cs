using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo
{
    internal class ParametrosOpcionales
    {
        public void CodigoDeLCurso()
        {
            // Ejemplo 1: Ejemplo sencillo
            /*

            En caso de que no se envíe el parámetro enMayúsculas, por defecto le pongo true

            Los parámetros opcionales deben aparecer después de los parámetros requeridos.
            
            */
            void ImprimirEnConsola(string mensaje, bool enMayúsculas = true)
            {
                if (enMayúsculas)
                {
                    mensaje = mensaje.ToUpper();
                }

                Console.WriteLine(mensaje);
            }

            var nombre = "Felipe";
            ImprimirEnConsola(nombre);

            // Ejemplo 2: Usando constantes
            /*
            Es buena práctica declarar como const una variable que va a ser reutilizada en varios lugares.
            */
            const bool mayúsculas = true;
            void ImprimirEnConsola2(string mensaje, bool enMayúsculas = mayúsculas)
            {
                if (enMayúsculas)
                {
                    mensaje = mensaje.ToUpper();
                }

                Console.WriteLine(mensaje);
            }

            // Ejemplo 3: Usando default
            /*
            Usar por defecto el valor del tipo de dato.... Por ej, el valor por defecto del bool es false
            */

            void ImprimirEnConsola3(string mensaje, bool enMayúsculas = default)
            {
                if (enMayúsculas)
                {
                    mensaje = mensaje.ToUpper();
                }

                Console.WriteLine(mensaje);
            }

            ImprimirEnConsola3("Claudia");
        }
    }
}
