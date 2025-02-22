﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo
{
    internal class FuncionMain
    {

        /*
        La función Main es el punto de entrada a nuestro software y es la función que se va a correr al compliar el mismo.
        */
        public int CodigoDelCurso(string[] args) // el argumento args trae la cantidad de elementos de la consola
        {
            Console.WriteLine($"Recibiendo {args.Length} argumentos de la consola");

            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }

            return 20;
        }
    }
}
