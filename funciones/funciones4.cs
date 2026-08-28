using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar un número entero mayor o igual a 0: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int resultado = Factorial(numero);

            Console.WriteLine("El factorial es: " + resultado);
        }
        static int Factorial(int numero)
        {
            int resultado = 1;

            for (int i = 1; i <= numero; i++)
            {
                resultado = resultado * i;
            }

            return resultado;
        }
    }
}


