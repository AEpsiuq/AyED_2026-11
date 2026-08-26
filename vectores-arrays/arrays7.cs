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
            double[] tiempos = new double[6];

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Ingresar  tiempo del corredor " + (i + 1) + ": ");
                tiempos[i] = Convert.ToDouble(Console.ReadLine());
            }

            double mejor = tiempos[0];
            double peor = tiempos[0];

            int corredorMejor = 1;
            int corredorPeor = 1;

            for (int i = 1; i < 6; i++)
            {
                if (tiempos[i] < mejor)
                {
                    mejor = tiempos[i];
                    corredorMejor = i + 1;
                }

                if (tiempos[i] > peor)
                {
                    peor = tiempos[i];
                    corredorPeor = i + 1;
                }
            }

            Console.WriteLine("Ganador: corredor n°" + corredorMejor);
            Console.WriteLine("Mejor tiempo: " + mejor + " segundos");

            Console.WriteLine("Peor tiempo: corredor N°" + corredorPeor);
            Console.WriteLine("Peor tiempo: " + peor + " segundos");

        }
    }
}
