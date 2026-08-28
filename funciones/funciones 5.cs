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
            Console.Write("Ingrese la base: ");
            int baseNumero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el exponente: ");
            int exponente = Convert.ToInt32(Console.ReadLine());

            int resultado = Potencia(baseNumero, exponente);

            Console.WriteLine("El resultado es: " + resultado);
        }
        static int Potencia(int baseNumero, int exponente)
        {
            int resultado = 1;

            for (int i = 0; i < exponente; i++)
            {
                resultado = resultado * baseNumero;
            }

            return resultado;
        }
    }
}




