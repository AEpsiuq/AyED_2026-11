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
            Console.Write("Ingrese distancia (años luz): ");
            int distancia = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese combustible (litros): ");
            int combustible = Convert.ToInt32(Console.ReadLine());

            int necesario = distancia * 12;

            if (combustible >= necesario)
            {
                Console.WriteLine("Cálculos precisos. Saltando al hiperespacio");
            }
            else
            {
                int falta = necesario - combustible;
                Console.WriteLine("Peligro: Combustible insuficiente. Faltan " + falta + " litros");
            }
        }
    
    }
}
