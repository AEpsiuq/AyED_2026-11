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
            Console.Write("Ingresar un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int i = 1;

            while (i <= 12)
            {
                Console.WriteLine(numero  + " x " + i + " = " + (numero * i));
                i++;
            }
        }
    }
}


