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
            Console.WriteLine("Ingresar una opcion de las siguientes calificaciones");
            Console.WriteLine("(1) A: Excelente");
            Console.WriteLine("(2) B: Bueno");
            Console.WriteLine("(3) C: Regular");
            Console.WriteLine("(4) D: Suficiente");
            Console.WriteLine("(5) F: Reprobado");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("La opcion elegida es: Excelente");
                    break;
                case 2:
                    Console.WriteLine("La opcion elegida es: Buena");
                    break;
                case 3:
                    Console.WriteLine("La opcion elegida es: Regular");
                    break;
                case 4:
                    Console.WriteLine("La opcion elegida es: Suficiente");
                    break;
                case 5:
                    Console.WriteLine("La opcion elegida es Desaprobado");
                    break;
            }

        }
    }
}
