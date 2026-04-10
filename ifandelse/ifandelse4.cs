using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_and_elsse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar cantidad de droides: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            int precio = 2000;
            int total = cantidad * precio;

            if (cantidad >= 3)
            {
                int descuento = total * 20 / 100;
                int precio_final = total - descuento;

                Console.WriteLine("Total original: " + total);
                Console.WriteLine("Descuento: " + descuento);
                Console.WriteLine("Precio final: " + precio_final);
            }
            else
            {
                Console.WriteLine("Total: " + total);
            }
        }
    
    }
}
