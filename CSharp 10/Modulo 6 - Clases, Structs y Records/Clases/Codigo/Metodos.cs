using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Codigo
{

    /*
    Un "metodo" es una función simple dentro de una clase.
    Todo método es una función pero toda función no es un método

    Existen otros tipos de función que podemos usar dentro de una clase
    */
    internal class Metodos
    {
        internal class Carro
        {
            // Por convención, los campos empiezan con guión bajo
            private string _marca;

            internal string Marca
            {
                get { return _marca.ToUpper(); }
                set { _marca = value; }
            }

            internal int Año { get; set; } = 1990;

            internal int Velocidad { get; private set; } = 20;
            private int VelocidadMaxima => 120;
            internal string NombreComercial => $"{Marca} ({Año})";

            /*
            No es necesario pasarle parametros a la función Acelerar porque ya estoy dentro de la clase
            Acelerar es un método de Carro
            */
            internal void Acelerar()
            {
                Acelerar(1);
            }

            /*
            
            Podemos realizar SOBRECARGAS, dos métodos pueden tener el mismo nombre pero con parámetros distintos
            
            Los métodos Acelerar tienen signaturas distintas. Signaturas son el nombre del "método" mas sus "parámetros" 

            Importante, con tener un tipo de salida diferente no es suficiente para que se configure la SOBRECARGA. 

            Por ej.. internal decimal Acelerar(){
                
            }

            */
            internal void Acelerar(int incremento)
            {
                if (Velocidad >= VelocidadMaxima)
                {
                    Console.WriteLine("La velocidad máxima ya ha sido alcanzada");
                    return;
                }
                else if (Velocidad + incremento > VelocidadMaxima)
                {
                    incremento = VelocidadMaxima - Velocidad;
                }

                Velocidad += incremento;
            }


            /* con el método Detener realizo lo mismo que en el anterior pero como es de una sola linea puedo usar la expresión lambda */
            internal void Detener() => Velocidad = 0;
        }

        public void CodigoDelCurso()
        {
            var carro1 = new Carro();
            carro1.Marca = "Toyota";
            carro1.Año = 2003;


            Console.WriteLine($"{carro1.NombreComercial}; velocidad = {carro1.Velocidad}");

            //carro1.Acelerar();
            carro1.Detener();

            Console.WriteLine($"{carro1.NombreComercial}; velocidad = {carro1.Velocidad}");
        }
    }
}
