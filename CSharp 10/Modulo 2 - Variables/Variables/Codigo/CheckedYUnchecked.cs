using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo
{
    internal class CheckedYUnchecked
    {
        public void CodigoDelCurso()
        {
            // Con el operador checked verifico que la operación se ejecute en un entorno seguro y donde verifica si hay overflow
            checked
            {
                var maximo = int.MaxValue;
                var suma = maximo + 1;

                Console.WriteLine(maximo);
                Console.WriteLine(suma);
            }
        }
    }
}
