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
            int[] notas = new int[10];
     
            int aprobados = 0;
            int desaprobados = 0;
            int suma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingresar nota del alumnado: " + (i + 1) + ": ");
                notas[i] = Convert.ToInt32(Console.ReadLine());

                suma = suma + notas[i];

                if (notas[i] >= 6)
                {
                    aprobados++;
                }
                else
                {
                    desaprobados++;
                }
            }

            double promedio = suma / 10.0;

            Console.WriteLine("Aprobados: " + aprobados);
            Console.WriteLine("Desaprobados: " + desaprobados);
            Console.WriteLine("Promedio: " + promedio);

        }
    }
}
