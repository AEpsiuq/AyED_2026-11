using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio;
            double acumulador = 0;
            double total;

            do
            {
                Console.WriteLine("Ingrsar precio: ");
                precio = Convert.ToDouble(Console.ReadLine());

                acumulador = acumulador + precio;

                if ( acumulador > 15000)
                {
                    double descuento = acumulador * 10 / 100;
                    total = acumulador - descuento;
                }
                else
                {
                    total = acumulador;
                }

                Console.WriteLine("Subtotal: " + acumulador);
                Console.WriteLine("Total final a pagar: " + total);

            } while (precio != 0);

        }
    }
}
