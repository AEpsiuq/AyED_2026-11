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
            string pelicula;


            Console.WriteLine("Hola");
            Console.Write("Como te llamas?: ");

            nombre = Console.ReadLine();

            Console.Write("Cual es tu peli favorita?: ");

            pelicula = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + ". Tu pelicula preferida " + pelicula + " es una porqueria ");

        }
    }
}
