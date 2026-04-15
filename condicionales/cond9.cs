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

            Console.Write("Ingresar edad del primer hermano: ");
            int edad1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar edad del segundo hermano: ");
            int edad2 = Convert.ToInt32(Console.ReadLine());

            if (edad1 > edad2)
            {
                int diferencia = edad1 - edad2;
                Console.WriteLine("El primer hermano es mayor por " + diferencia + " años");
            }
            else
            {
                if (edad2 > edad1)
                {
                    int diferencia = edad2 - edad1;
                    Console.WriteLine("El segundo hermano es mayor por " + diferencia + " años");
                }
                else
                {
                    Console.WriteLine("Ambos tienen la misma edad");
                }
            }
        }
    }
}
