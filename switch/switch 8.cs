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
            int acumulador = 0;
            int contador = 0;

            for (int i = 1; i <= 7; i++)
            {
                Console.Write("Ingrese temperatura del día " + i + ": ");
                int temp = Convert.ToInt32(Console.ReadLine());

                acumulador = acumulador + temp;

                if (temp < 0)
                {
                    contador++;
                }
            }

            Console.WriteLine("Suma total de temperaturas: " + acumulador);
            Console.WriteLine("Temperaturas menores a 0: " + contador);
        }
    }

}
    
