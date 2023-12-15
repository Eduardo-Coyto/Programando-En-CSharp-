using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo
{
    internal class Predicados
   
    {
        public void CodigoDelCurso()
        {
            bool EsPar(int n)
            {
                return n % 2 == 0;
            }

            Predicate<int> predicado = EsPar;
            /*
                La función Predicate es un Func que siempre retorna un boleano.
                Guardo la función EsPar en predicado.
            */
            var numero = 4;

            Console.WriteLine($"¿Es {numero} par? {predicado(numero)}");
            numero = 5;
            Console.WriteLine($"¿Es {numero} par? {predicado(numero)}");

        }
    }
}
