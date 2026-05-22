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
            int numero = 1;
            int acumulador = 0;

            while (numero != 0)
            {
                Console.Write("Ingrese un número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                acumulador = acumulador + numero;
            }

            Console.WriteLine("El total acumulado es de: " + acumulador);
        }
    }

}

