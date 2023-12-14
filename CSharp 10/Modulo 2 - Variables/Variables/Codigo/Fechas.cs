using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo
{
    internal class Fechas
    {
        public void CodigoDelCurso()
        {

            DateTime ahora = DateTime.Now;

            // con **new** invoco un metodo especial del DateTime que me permite construirlo 2022/01/01 07:15:23 
            DateTime primerDiaDelAño = new DateTime(2022, 1, 1, 7, 15, 23);
            
            // agrego un día a la fecha de hoy
            DateTime mañana = DateTime.Now.AddDays(1);

            Console.WriteLine(ahora);
            Console.WriteLine(primerDiaDelAño);
            Console.WriteLine(mañana);

            //extraigo el día del año
            Console.WriteLine("El dia es:");
            Console.WriteLine(mañana.Day);

            //extraigo el año
            Console.WriteLine("El dia del año es:");
            Console.WriteLine(mañana.DayOfYear);

            //extraigo el día de la semana
            Console.WriteLine("El dia de la semana es:");
            Console.WriteLine(mañana.DayOfWeek);


        }
    }
}
