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

            Console.Write("Ingresar un número positivo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int menor = numero;

            while (numero >= 0)
            {
                if (numero < menor)
                {
                    menor = numero;
                }

                Console.Write("Ingrese otro número (negativo para terminar): ");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("El menor número es: " + menor);

        }
    }
}
