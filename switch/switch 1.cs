using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar un numero del 1 al 4");
            Console.WriteLine(" 1 Primavera");
            Console.WriteLine(" 2 Verano");
            Console.WriteLine(" 3 Otoño");
            Console.WriteLine(" 4 Invierno");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine(" 1. Primavera");
                    break;
                case 2:
                    Console.WriteLine(" 2. Verano");
                    break;
                case 3:
                    Console.WriteLine(" 3. Otoño");
                    break;
                case 4:
                    Console.WriteLine(" 4. Invierno");
                    break;
                default:
                    Console.WriteLine("La opcion elegida no es valida");
                    break;
            }

        }
    
    }
}

