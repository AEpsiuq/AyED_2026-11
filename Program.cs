using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario_y_cine
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variablee

            string nombre;
            string juego;
            string consola;

            Console.WriteLine("Hola");
            Console.Write("Como te llamas?: ");
            nombre = Console.ReadLine();

            Console.Write("Cual es tu juego favorito?: ");
            juego = Console.ReadLine();

            Console.Write("En que consola se juega?: ");
            consola = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + ". Tu juego favorito es " + juego + " y se juega en " + consola + ".");

        }
    }
}
