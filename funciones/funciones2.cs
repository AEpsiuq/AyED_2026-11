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
            Console.Write("Ingrese un número entero positivo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            ContarHasta(numero);
        }

        static void ContarHasta(int numero)
        {
            int contador = 1;

            while (contador <= numero)
            {
                Console.WriteLine(contador);
                contador++;
            }
        }
    }
}


