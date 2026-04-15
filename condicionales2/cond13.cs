using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string genero;

            Console.Write("Inmgresar genero: ");
            genero = Console.ReadLine();

            Console.Write("Inmgresar edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (genero == "F")
            {
                if (edad >= 60)
                {
                    Console.WriteLine("Puede iniciar el tramite jubilatorio");
                }
            }
            else
            {
                if (genero == "M")
                {
                    if (edad >= 65)
                    {
                        Console.WriteLine("Puede iniciar el tramite jubilatorio");
                    }
                }
            }
        }                    
    }
}
