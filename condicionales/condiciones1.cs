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
            Console.Write("Ingresar velocidad del vehiculo: ");
            int velocidad = Convert.ToInt32(Console.ReadLine());

            if (velocidad > 120)
            {
                Console.WriteLine("Multa en camino: Exceso de velocidad");
            }
            else
            {
                Console.WriteLine("Conducción segura");
            }
        }
    }
}
