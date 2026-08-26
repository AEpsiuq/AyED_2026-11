using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            double[] precios = new double[10];

            double total = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese precio del producto " + (i + 1) + ": ");
                precios[i] = Convert.ToDouble(Console.ReadLine());

                total = total + precios[i];
            }

            Console.Write("Ingrese la posición del producto a devolver (1 a 10): ");
            int posicion = Convert.ToInt32(Console.ReadLine());

            double precioDevuelto = precios[posicion - 1];

            total = total - precioDevuelto;

            Console.WriteLine("Precio del producto devuelto: $" + precioDevuelto);
            Console.WriteLine("Nuevo total: $" + total);


        }
    }
}
