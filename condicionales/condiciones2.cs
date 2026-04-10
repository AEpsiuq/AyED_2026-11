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
            string nombre;

            Console.WriteLine("El club de la Pelea ");

            Console.Write("Ingresar nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingresar edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad > 18)
            {
                Console.WriteLine("Bienvenido al club, " + nombre);
            }
            else
            {
                Console.WriteLine("Lo siento, eres muy polluelo para esto");
            }
        }
    }
}
