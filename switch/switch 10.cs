using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int divisor = 0;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    divisor = i;
                    break;
                }
            }

            if (divisor == 0)
            {
                Console.WriteLine("Es primo");
            }
            else
            {
                Console.WriteLine("No es primo");
                Console.WriteLine("Primer divisor encontrado: " + divisor);
            }
        }
    }
}
