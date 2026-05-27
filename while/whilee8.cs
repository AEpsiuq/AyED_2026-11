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
            Console.Write("Ingrese temperatura inicial: ");
            int temperaturea = Convert.ToInt32(Console.ReadLine());

            while (temperaturea > 24)
            {
                temperaturea = temperaturea - 2;

                Console.WriteLine("Enfriando... Temperatura actual: " + temperaturea + "°C");
            }

            Console.WriteLine("Temperatura ideal alcanzada");
        }
    }
}

