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
            int numero;

            Console.Write("ingresar un numero entero: ");
            numero = Convert.ToInt32(Console.ReadLine());


            if (numero > 1)
            {
                Console.Write("Factores primos: ");
                int cantidad = MostrarFactoresPrimos(numero);
                Console.WriteLine();
                Console.WriteLine("Cantidad total de factores primos: " + cantidad);
            }
            else
            {
                Console.WriteLine("El numero debe ser mayor que 1 ");
            }
        }
        static int MostrarFactoresPrimos(int numero)
        {
            int cantidadfact = 0;
            int divisor = 2;

            while (numero > 1)
            {
                if (numero % divisor == 0)
                {
                    Console.Write(divisor + " ");
                    numero = numero / divisor;
                    cantidadfact++;
                }
                else
                {
                    divisor++;
                }
            }
            return cantidadfact;
        }
    }
}
