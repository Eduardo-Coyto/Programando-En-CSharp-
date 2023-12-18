using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Codigo
{
    internal class Constructores
    {
        internal class Carro
        {
            /*
            Constructor:

            Por defecto las clases tienen un constructor sin parametros el cual nos permiten instanciar la clase que este lista para ser utilizada
            Los constructors no tienen un tipo de dato de salida, no estan supuestos a devolver ningun valor
            
            IMPORTANTE
            Su nombre es el mismo nombre que de la clase

            -> internal class Carro    nombre de la clase
            ->  internal Carro()       nombre del constructor 

            Puedo instanciar un constructor dentro de otro constructor a través del método this().... internal Carro() : this("marca por defecto")

            */
            internal Carro() : this("marca por defecto")
            {
                Console.WriteLine("Instanciando un carro");
            }

            internal Carro(string marca)
            {
                Console.WriteLine("Instanciando un carro con una marca");
                _marca = marca;
            }

            internal void Acelerar()
            {
                Acelerar(1);
            }

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

            internal void Detener() => Velocidad = 0;
        }
    
        public void CodigoDelCurso()
        {
            /* 
            Con new Carro() estamos invocando un tipo especial de función llamado constructor 
            Los constructores son aquellas funciones que se ejecutan al momento de instanciar una clase 
            */
            var carro1 = new Carro("Toyota");
            Console.WriteLine(carro1.Marca);

            Console.WriteLine("--------");

            var carro2 = new Carro();
            Console.WriteLine(carro2.Marca);
        }

    }
}
