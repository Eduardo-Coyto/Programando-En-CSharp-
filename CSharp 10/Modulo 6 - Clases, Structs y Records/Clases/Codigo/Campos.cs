using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Codigo
/* con los namespace podemos organizar nuestras clases y los enums entre otros */
{
    /* 
    
    una clase nos permite definir un tipo de referencia que va a contener la data y funcionalidad que se quiera 
    La clase contiene miembros, los cuales pueden ser:

        *   campos
        *   metodos
        *   propiedades
        *   constructores
        *   indexadores
        *   operadores
        *   descontructores
        *   etc
    */
    internal class Campos
    /*
    Los campos son data que puede tener una clase y por convención son privados, sólo lo podemos usar dentro de nuestras clases
    */
    {
        // internal es uno de los modificadores de acceso el cual le permite ingresar a las variables.
       internal class Carro
        {
            // Por convención, los "campos" empiezan con guión bajo
            internal string _marca;
            internal int _año;
        }

        public void CodigoDelCurso()
        {
            /* Instanciar una clase significa usar el operador "new" para crear un nuevo valor a partir de la clase */
            var carro1 = new Carro(); // carro1 es el objeto creado a partir de la clase Carro()
            carro1._marca = "Toyota";
            carro1._año = 2003;

            ModificarMarca(carro1);
            Console.WriteLine(carro1._marca); // Toyota2

            var carro2 = new Carro();
            carro2._marca = "Hyundai";
            carro2._año = 2013;

            Console.WriteLine(carro2._marca); // Hyundai

            // Es un tipo de referencia
            carro2 = null;

            void ModificarMarca(Carro carro)
            {
                carro._marca += "2";
            }
        }
    }
}
