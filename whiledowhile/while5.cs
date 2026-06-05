using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while2
{
    class Program
    {
        static void Main(string[] args)
        {
            int positivos = 0;
            int negativos = 0;
            int ceros = 0;

            string entrada = "";
            while (entrada != "X" && entrada != "x")
            {
                Console.Write("Ingrese un número o X para salir: ");
                entrada = Console.ReadLine();

                if (entrada != "X" && entrada != "x")
                {
                    int num = Convert.ToInt32(entrada);
                    if (num > 0)
                    {
                        positivos++;
                    }
                    else
                    {
                        if (num < 0)
                        {
                            negativos++;  
                        }
                        else
                        {
                            ceros++;
                        }
                    }
                }
            }

            Console.WriteLine("Positivos: " + positivos);
            Console.WriteLine("Negativos: " + negativos);
            Console.WriteLine("Ceros: " + ceros);
        }
    }
}
    

