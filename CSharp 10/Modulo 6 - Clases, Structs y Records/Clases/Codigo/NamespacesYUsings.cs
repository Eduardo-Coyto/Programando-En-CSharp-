using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Utilizo la directiva "using" para importar el namespace que esta la Caluculador o clase que quiera importar.

*/

namespace Clases.Codigo
/*
Los namespace es una forma de organizar nuestros tipos, como clases y enums
Se puden trabajar los namespace sin cuerpo y se sacan las {} y se agrega un ;

namespace se le agrega el nombre del proyecto, en este caso es Clases. Por defecto se le agrega Clases a cada tipo que se creen en el proyecto en el root del mismo.

Los namespace nos permiten tener dos clases con el mismo nombre en el mismo programa, siempre que se encuentren en namespaces diferentes. 
En este proyecto vamos a encontrar la Clase.Codigo Calculadora en el namespace Clases y además en otra carpeta Matemáticas con namespace Clases.Matematicas.
 */
{
    namespace Clases.Codigo.Matematicas
    {
        internal class Calculadora
        {
            public double CalcularPi()
            {
                return Math.PI;
            }
        }
    }

    internal class Calculadora
    {
        internal ResultadoDT CalcularDuploTriplo(int valor)
        {
            var resultado = new ResultadoDT();
            resultado.Valor = valor;
            resultado.Duplo = valor * 2;
            resultado.Triplo = valor * 3;
            return resultado;
        }
    }


    internal class NamespacesYUsings
    {
        public void CodigoDelCurso()
        {
            var calculadora = new Calculadora();

            var calculadora2 = new Clases.Codigo.Matematicas.Calculadora();
        }
    }
}
