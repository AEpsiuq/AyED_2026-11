using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiledowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar nota: ");
            int nota = int.Parse(Console.ReadLine());

            do
            {
                if (nota >= 1 && nota <= 10)
                {
                    Console.WriteLine("Nota: " + nota);
                }
                else
                {
                    Console.WriteLine("Error");
                    Console.Write("Ingresar nota nuevamente: ");
                    int notan = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nota: " + notan);
                }
            } while (nota >= 1 && nota <= 10);
            
        }
    }
}
