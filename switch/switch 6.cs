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
            Console.WriteLine("Carta de menu:");
            Console.WriteLine("(S)ándwich");
            Console.WriteLine("(P)izza");
            Console.WriteLine("(H)amburguesa");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "S" :
                    Console.WriteLine("Costo de sandwich: $4000 ");
                    break;
                case "P" :
                    Console.WriteLine("Costo de pizza: $10.000");
                    break;
                case "H":
                    Console.WriteLine("Costo de hamburguesa: $4000");
                    break;
                default:
                    Console.WriteLine("Producto no encontrado...");
                    break;
            }

        }
    
    }
}

