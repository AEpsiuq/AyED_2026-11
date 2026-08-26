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
            int[] respuestas = new int[25];

            int cantidad1 = 0;
            int cantidad2 = 0;
            int cantidad3 = 0;
            int cantidad4 = 0;
            int cantidad5 = 0;

            for (int i = 0; i < 25; i++)
            {
                Console.Write("Ingresar calificacion dl cliente: " + (i + 1) + " (1 a 5): ");
                respuestas[i] = Convert.ToInt32(Console.ReadLine());

                if (respuestas[i] == 1)
                {
                    cantidad1++;
                }
                else if (respuestas[i] == 2)
                {
                    cantidad2++;
                }
                else if (respuestas[i] == 3)
                {
                    cantidad3++;
                }
                else if (respuestas[i] == 4)
                {
                    cantidad4++;
                }
                else if (respuestas[i] == 5)
                {
                    cantidad5++;
                }
            }

            Console.WriteLine("Cantidad de respuestas 1: " + cantidad1);
            Console.WriteLine("Cantidad de respuestas 2: " + cantidad2);
            Console.WriteLine("Cantidad de respuestas 3: " + cantidad3);
            Console.WriteLine("Cantidad de respuestas 4: " + cantidad4);
            Console.WriteLine("Cantidad de respuestas 5: " + cantidad5);

        }
    }
}
