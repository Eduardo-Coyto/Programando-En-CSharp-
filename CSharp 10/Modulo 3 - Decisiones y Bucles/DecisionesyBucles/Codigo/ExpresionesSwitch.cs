using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesyBucles.Codigo
{
    internal class ExpresionesSwitch
    {
        public void CodigoDelCurso()
        {
            var lugar = 3;

            var mensaje = lugar switch
            {
                1 => "¡Quedaste en primer lugar!",
                2 => "¡Quedaste en segundo lugar!",
                3 => "¡Puedes vender tu medalla de bronce en una compraventa!",
                4 or 5 => "Casi casi lo lograste",
                _ => "¡Mejor suerte para la próxima!"
            };

            Console.WriteLine(mensaje);

            /*
             Patrones relacionales

            var temperatura = 35;

            var mensaje = temperatura switch 
            {
            
            "evaluo" entonces "mensaje"

             37 => "No tienes temperatura",
            > 37 => "Tienes fiebre",
            < 37 => "No tienes fiebre",
            _ => "nada"
            };
            Console.WriteLine(mensaje);
         
           
            Patrones relacionales + Patrones lógicos "and"

          var temperatura = 35;

          var mensaje = temperatura switch 
          {

          "evaluo" entonces "mensaje"

           37 => "No tienes temperatura",
          > 37 and < 39 => "Tienes fiebre",
          >= 39 and < 43 => "mama mia",
          < 37 => "No tienes fiebre",
          _ => "nada"
          };
            Console.WriteLine(mensaje);


            var hoy = DateTime.Today;

            var estacion = hoy.Month switch
            {
                3 or 4 or 5 => "Otoño",
                6 or 7 or 8 => "Invierno",
                9 or 10 or 11 => "Primavera",
                12 or 1 or 2 => "Veranito",
                _ => throw new ApplicationException("Mes incorrecto")
            };
            Console.WriteLine(Estacion);

          */


            /*
            
            Podemos saltarnos el asignar la variable y pasarle el resultado directamente al WriteLine:
            
            Console.WriteLine(lugar switch
            {
                1 => "¡Quedaste en primer lugar!",
                2 => "¡Quedaste en segundo lugar!",
                3 => "¡Puedes vender tu medalla de bronce en una compraventa!",
                4 or 5 => "Casi casi lo lograste",
                _ => "¡Mejor suerte para la próxima!"
            });
            
             */
        }
    }
}
