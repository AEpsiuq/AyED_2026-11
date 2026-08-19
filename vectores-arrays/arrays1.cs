using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturas = new double[7];
        
            double suma = 0;
            double mayor;
            double menor;

            for (int i = 0; i < 7; i++)
            {
                Console.Write("Ingresar la temperatura del día " + (i + 1) + ": ");
                temperaturas[i] = Convert.ToDouble(Console.ReadLine());

                suma = suma + temperaturas[i];
            }

            mayor = temperaturas[0];
            menor = temperaturas[0];

            for (int i = 1; i < 7; i++)
            {
                if (temperaturas[i] > mayor)
                {
                    mayor = temperaturas[i];
                }

                if (temperaturas[i] < menor)
                {
                    menor = temperaturas[i];
                }
            }

            double promedio = suma / 7;

            Console.WriteLine("Temperatura más alta: " + mayor);
            Console.WriteLine("Temperatura más baja: " + menor);
            Console.WriteLine("Promedio de la semana: " + promedio);

        }
    }
}
