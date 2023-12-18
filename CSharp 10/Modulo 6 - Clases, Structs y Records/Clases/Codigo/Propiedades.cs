using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Codigo
{
    internal class Propiedades
    {
        internal class Carro
        {
            // Por convención, los campos empiezan con guión bajo
            private string _marca;

            /* 
                con internal habilito a usar dentro del proyecto al campo de _marca 
                internal es una propiedad y lo identificamos porque usa get y set. Hay que tener en cuenta que no siempre lo usan.
            */
            internal string Marca
            {
                get { return _marca.ToUpper(); }
                set { _marca = value; }
            }

            internal int Año { get; set; } = 1990;

            /* con la función private set solo puedo modificar la variable velocidad desde dentro de la clase. */
            internal int Velocidad { get; private set; } = 20;

            /* con la función lambda es lo mismo que aplicar solo la función get de la propiedad */
            internal string NombreComercial => $"{Marca} ({Año})";
        }

        public void CodigoDelCurso()
        {
            var carro1 = new Carro();
            carro1.Marca = "Toyota";
            carro1.Año = 2003;

            ModificarMarca(carro1);
            //carro1.Velocidad = 25;
            Console.WriteLine($"{carro1.NombreComercial}; velocidad = {carro1.Velocidad}");

            var carro2 = new Carro();
            carro2.Marca = "Hyundai";
            carro2.Año = 2013;

            Console.WriteLine(carro2.Marca);

            // Es un tipo de referencia
            carro2 = null;

            void ModificarMarca(Carro carro)
            {
                carro.Marca += "2";
            }
        }

        // Ejemplo 2: Patron de varias propiedades

        /*
        Para cambiar a switch debo ir al if hacer crtl + . y convertir a switch
        */
        var carro = new Carro("Toyota");
        carro.Año = 1995;

        if(carro is { Marca: "Toyota" or "Hyundai", Año: > 2010 })
        {
            Console.WriteLine("Buen auto");
        } else if (carro is { Marca: "Mercedes", Velocidad: > 25 })
{
    Console.WriteLine("Vas rápido en tu Mercedes");
}
else if (carro is { Año: < 2000 })
{
    Console.WriteLine("Vehícluo viejo");
}

switch (carro)
{
    case
    {
        Marca: "Toyota" or "Hyundai", Año: > 2010
    }:
        Console.WriteLine("Buen auto");
        break;

    case
    {
        Marca: "Mercedes", Velocidad: > 25
    }:
        Console.WriteLine("Vas rápido en tu Mercedes");
        break;
    case
    {
        Año: < 2000
    }:
        Console.WriteLine("Vehícluo viejo");
        break;

}
    }
}
