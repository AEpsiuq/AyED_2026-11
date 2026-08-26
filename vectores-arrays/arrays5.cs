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
            int[] numeros = new int[15];

            for (int i = 0; i < 15; i++)
            {
                Console.Write("Ingrese el número " + (i + 1) + ": ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Ingresa el número que desea buscar: ");
            int buscado = Convert.ToInt32(Console.ReadLine());

            bool encontrado = false;

            for (int i = 0; i < 15; i++)
            {
                if (numeros[i] == buscado)
                {
                    encontrado = true;
                }
            }

            if (encontrado == true)
            {
                Console.WriteLine("El número fue vendido.");
            }
            else
            {
                Console.WriteLine("El número todavía no fue vendido.");
            }

        }
    }
}
