using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAcercaDeTiposDeDatos.Codigo
{   
    /* Enums es un valor especial que te permite agrupar un conjunto de constantes numéricas */
    internal class Enums
    {
        public void CodigoDelCurso()
        {
            // aca puedo variar entre EstatusVenta.PendienteDePago, EstatusVenta.Exitoso, EstatusVenta.Cancelada
            var estatusDeLaVentaDeUnaCamisa = EstatusVenta.Exitoso;

            switch (estatusDeLaVentaDeUnaCamisa)
            {
                case EstatusVenta.Exitoso:
                    Console.WriteLine("La venta fue exitosa");
                    break;
                case EstatusVenta.PendienteDePago:
                    Console.WriteLine("El cliente debe de pagar");
                    break;
                case EstatusVenta.Cancelada:
                    Console.WriteLine("¿Qué hice para merecer esto?");
                    break;
                default:
                    Console.WriteLine("Estatus desconocido");
                    break;
            }

            // Ejemplo 2: Casteos

            int estatus = (int)estatusDeLaVentaDeUnaCamisa;
            Console.WriteLine(estatus); // 1

            int estatus3 = 3;
            var estatus3Nombre = (EstatusVenta)estatus3;
            Console.WriteLine(estatus3Nombre); // Cancelada
        }
    }
}
