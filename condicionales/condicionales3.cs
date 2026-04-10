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

            Console.Write("Ingresar numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine(numero + ": numero par");
            }
            else
            {
                Console.WriteLine(numero + ": numero impar");
            }
        }
    }
}
