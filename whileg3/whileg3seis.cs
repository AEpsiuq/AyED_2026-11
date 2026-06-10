using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileg3
{
    class Program
    {
        static void Main(string[] args)
        {

            double precio;
            double subtotal = 0;

            Console.Write("Ingresar precio (0 para finalizar): ");
            precio = Convert.ToDouble(Console.ReadLine());

            while (precio != 0)
            {
                subtotal = subtotal + precio;

                Console.Write("Ingresar precio (0 para finalizar): ");
                precio = Convert.ToDouble(Console.ReadLine());
            }

            double descuento = 0;
            double total;

            if (subtotal > 15000)
            {
                descuento = subtotal * 0.10;
            }

            total = subtotal - descuento;

            Console.WriteLine("Subtotal: $" + subtotal);
            Console.WriteLine("Descuento: $" + descuento);
            Console.WriteLine("Total: $" + total);
        }
    }
}
