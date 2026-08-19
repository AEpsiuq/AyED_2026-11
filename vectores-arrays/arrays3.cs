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
            string[] asistencias = new string[20];
            int ausente = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Ingresar si el alumno esta ausente (A) o presente (P): " + (i + 1) + ": ");
                asistencias[i] = Console.ReadLine();

                if (asistencias[i] == "A")
                {
                    ausente++;
                }
            }

            Console.WriteLine("Total de inasistencias: " + ausente);

            if (ausente > 6)
            {
                Console.WriteLine("El alumno quedo libre por inasistencias...");
            }
            else
            {
                Console.WriteLine("Regular");
            }
        }
    }
}
