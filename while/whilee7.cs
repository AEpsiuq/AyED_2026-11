using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            int i = 1;

            while (i <= 5)
            {
                Console.Write("Ingresar nota: ");
                int nota = Convert.ToInt32(Console.ReadLine());

                acumulador = acumulador + nota;

                i++;
            }

            int promedio = acumulador / 5;

            Console.WriteLine("Promedio: " + promedio);

        }
    }
}

