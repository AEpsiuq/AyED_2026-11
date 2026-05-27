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
            int opcion = 0;

            while (opcion != 3)
            {
                Console.WriteLine("1 - Saludar");
                Console.WriteLine("2 - Despedirse");
                Console.WriteLine("3 - Salir");

                Console.Write("Ingresar una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Hola");
                        break;

                    case 2:
                        Console.WriteLine("Adiós");
                        break;

                    case 3:
                        Console.WriteLine("Programa finalizado");
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            }
        }
    }
}

