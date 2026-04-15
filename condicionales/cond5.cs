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
            Console.Write("Ingrese el monto de la compra: ");
            int monto = Convert.ToInt32(Console.ReadLine());

            if (monto > 5000)
            {
                int descuento = monto * 15 / 100;
                int total = monto - descuento;

                Console.WriteLine("Descuento aplicado: " + descuento);
                Console.WriteLine("Total a pagar: " + total);
            }
            else
            {
                Console.WriteLine("Total a pagar: " + monto);
            }
        }
    }

}
            

