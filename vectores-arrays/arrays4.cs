using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] precios = new double[8];

            for (int i = 0; i < 8; i++)
            {
                Console.Write("Ingrese el precio del producto " + (i + 1) + ": ");
                precios[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Ingrese cuánto dinero tiene el cliente: ");
            double dinero = Convert.ToDouble(Console.ReadLine());

            int cantidad = 0;

            for (int i = 0; i < 8; i++)
            {
                if (precios[i] <= dinero)
                {
                    cantidad++;
                }
            }

            Console.WriteLine("Puede comprar " + cantidad + " productos.");
        }
    }
}
