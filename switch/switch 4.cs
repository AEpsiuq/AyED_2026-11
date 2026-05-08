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

            int contador = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Ingresar un número: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num > 100)
                {
                    contador++;
                }
            }

            Console.WriteLine("Cantidad mayores a 100: " + contador);
        }
    }
}

    