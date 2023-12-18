using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Codigo
{
    internal class ClasesComoValoresDeSalida
    {
        internal class ResultadoDT
        {
            /* 
            Una forma de crear una propiedad de forma rápida es colocar prop + 2 veces tabulador 
            Modificadores de accesos, internal public....
            */
            internal int Valor { get; set; }
            public int Duplo { get; set; }
            public int Triplo { get; set; }
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

        public void CodigoDelCurso()
        {
            var calculadora = new Calculadora();

            var resultadoDT = calculadora.CalcularDuploTriplo(5);

            Console.WriteLine("El valor es " + resultadoDT.Valor);
            Console.WriteLine("El duplo es " + resultadoDT.Duplo);
            Console.WriteLine("El triplo es " + resultadoDT.Triplo);
        }
    }
}
