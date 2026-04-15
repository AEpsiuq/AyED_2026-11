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
            Console.Write("Ingresar peso: ");
            int peso = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar altura: ");
            double altura = Convert.ToInt32(Console.ReadLine());

            double IMC = peso / (altura * altura);


            if (IMC > 25)
            {
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Rango normal");
            }

        }
    }
}
