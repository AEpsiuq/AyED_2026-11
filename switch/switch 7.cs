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
            Console.WriteLine("Elegí un idioma: ");
            Console.WriteLine("1. Inglés");
            Console.WriteLine("2. Francés");
            Console.WriteLine("3. Alemán");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1 :
                    Console.WriteLine("Hellooo");
                    break;
                case 2 :
                    Console.WriteLine("Salut");
                    break;
                case 3:
                    Console.WriteLine("Halloooo");
                    break;
            }

        }
    
    }
}

