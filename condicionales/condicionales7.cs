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
            Console.Write("Ingresar temperatura actual: ");

            int temperatura = Convert.ToInt32(Console.ReadLine());


            if ( temperatura < 0)
            {
                Console.WriteLine("Peligro de congelmiento");
            }
            else
            {
                if (temperatura <= 15)
                {
                    Console.WriteLine("Mucho frio");
                }
                else
                {
                    if (temperatura > 15)
                    {
                        Console.WriteLine("Clima agradable");
                    }
                }
                  
            }
        }
    }

            
}
