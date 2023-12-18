using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Codigo
{
    internal class ClasesParciales
    {
        internal partial class Calculadora
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

        /*
        Podemos utilizar clases parciales para tener los miembros de una clase en distintos archivos.
        Para poder utilizar las clases con distintos namespace se debe utilizando "partial". Requisito estar en el mismo namespace

        De esta forma puedo usar las propiedades de cada una de las clases en un mismo procedimiento.
        */
        internal partial class Calculadora
        {
            public double CalcularPi()
            {
                return Math.PI;
            }
        }

        public void CodigoDelCurso()
        {
            var calculadora = new Calculadora();
            var pi = calculadora.CalcularPi();
            var resultadoDT = calculadora.CalcularDuploTriplo(5);
        }
    }
}
