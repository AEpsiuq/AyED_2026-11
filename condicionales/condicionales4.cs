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

            Console.Write("Ingresar nota: ");
            int nota = Convert.ToInt32(Console.ReadLine());
          
            if (nota >= 7 ) 
            {
                Console.WriteLine("Promocionando");
            }
            else
            {
                if (nota >= 4)
                {
                    Console.WriteLine("A finales");
                }
                else
                {
                    if(nota < 4)
                    {
                        Console.WriteLine("Recuperatorio");
                    }
                }
            }
        }
    }
}
