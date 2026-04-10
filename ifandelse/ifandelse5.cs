using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_and_elsse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar una opción (1, 2 o 3): ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("El camino del Jedi sigue");
            }
            else
            {
                if (opcion == 2)
                {
                    Console.WriteLine("Un cazarecompensas eres");
                }
                else
                {
                    if (opcion == 3)
                    {
                        Console.WriteLine("El Lado Oscuro se apodera de ti");
                    }
                    else
                    {
                        Console.WriteLine("Error en la Fuerza: opción inválida");
                    }
                }
            }
        }
    
    }
}
