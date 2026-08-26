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
            int[] edades = new int[12];

            int menores = 0;
            int adultos = 0;
            int mayores = 0;

            for (int i = 0; i < 12; i++)
            {
                Console.Write("Ingresar edad del vecino: " + (i + 1) + ": ");
                edades[i] = Convert.ToInt32(Console.ReadLine());

                if (edades[i] < 18)
                {
                    menores++;
                }
                else if (edades[i] >= 65)
                {
                    mayores++;
                }
                else
                {
                    adultos++;
                }
            }

            Console.WriteLine("Menores de edad: " + menores);
            Console.WriteLine("Adultos: " + adultos);
            Console.WriteLine("Adultos mayores: " + mayores);

        }
    }
}
