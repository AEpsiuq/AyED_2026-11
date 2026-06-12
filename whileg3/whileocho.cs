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
            int edad = 0;
            int suma = 0;
            int cantidad = 0;
            int mayores = 0;
            int menores = 0;

            while (edad >= 0)
            {
                Console.Write("ingresar edad (-1 para finalizar): ");
                edad = Convert.ToInt32(Console.ReadLine());

                if (edad >= 0)
                {
                    suma = suma + edad;
                    cantidad++;

                    if (edad >= 18)
                    {
                        mayores++;
                    }
                    else
                    {
                        menores++;
                    }
                }
            }

            double promedio = suma * 1.0 / cantidad;

            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Mayores de edad: " + mayores);
            Console.WriteLine("Menores de edad: " + menores);
        }
    }
}
