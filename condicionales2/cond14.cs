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
            Console.Write("Ingresar sueldo: ");
            int sueldo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar años de antiguedad: ");
            int años = Convert.ToInt32(Console.ReadLine());

            if (años > 10)
            {
                double aumento = sueldo * 0.20;
                double total = sueldo + aumento;

                Console.WriteLine("Su sueldo es: " + total);
            }
            else
            {
                if (años <= 10)
                {
                    int aumentobajo = sueldo * 5 / 100;
                    int totalb = sueldo + aumentobajo;

                    Console.WriteLine("Nuevo sueldo: " + totalb);

                }
            }
        }
    }

}
            

