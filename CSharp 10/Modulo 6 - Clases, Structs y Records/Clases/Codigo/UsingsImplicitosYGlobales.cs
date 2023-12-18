//global using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Codigo
{
    internal class UsingsImplicitosYGlobales
    /*
    using implicitos son clases agregadas automaticamente en la clase de la aplicación.

    using globales son using que se van a propagar por toda la aplicación.
    Debo a ir al proyecto con extensión .csproj debo agregar la siguiente sentencia:

    <ItemGroup>
         <Using Include="Clases" />         //En Include va el nombre del namespace
    </ItemGroup>

    Otra forma de hacerlo es utilizando la instancia global using (namespace) en cualquiera de las clases y luego se propaga.
    */
    {
        public void CodigoDelCurso()
        {
            // Podemos usar la clase Console pues hay un using implícito de System.
            Console.WriteLine("¿Dónde está el using System;?");

            var calculadora = new Calculadora();
        }
    }
}
