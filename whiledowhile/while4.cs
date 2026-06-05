using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while2
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int cantidad = 0;
            int mayor = 0;
            string opcion = "S";

            while (opcion != "N")
            {
                Console.Write("Ingrese monto de venta: ");
                int venta = Convert.ToInt32(Console.ReadLine());
                total = total + venta;
                cantidad++;
                if (venta > mayor)
                {
                    mayor = venta;
                }

                Console.Write("¿Desea continuar? (S/N): ");
                opcion = Console.ReadLine();
            }
            Console.WriteLine("Total recaudado: " + total);
            Console.WriteLine("Cantidad de ventas: " + cantidad);
            Console.WriteLine("Venta más alta: " + mayor);
        }
    }
}
    

