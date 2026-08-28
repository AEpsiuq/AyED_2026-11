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
            Console.Write("Ingresar un número entero positivo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int resultado = SumarHasta(numero);

            Console.WriteLine("La suma es: " + resultado);
        }
        static int SumarHasta(int numero)
        {
            int suma = 0;
            int contador = 1;

            while (contador <= numero)
            {
                suma = suma + contador;

                contador++;
            }

            return suma;
        }
    }
}


