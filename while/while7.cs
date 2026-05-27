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
            Console.Write("Ingrese una temperatura: ");

            int temperatura = int.Parse(Console.ReadLine());

            while (temperatura > 24 )
            {
                temperatura = temperatura - 2;
                Console.WriteLine("Enfriando...Temperatura actual: " + temperatura + "°C.");

            }
        }
    }
}