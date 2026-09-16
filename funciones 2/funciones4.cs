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
            int cantidad;
            int numero;

            int positivos = 0;
            int negativos = 0;
            int ceros = 0;

            int sumap = 0;
            int suman = 0;

            Console.Write("Ingresar cantidad de numeros: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write("Ingresar un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    positivos++;
                    sumap = sumap + numero;

                }
                else if (numero == 0)
                {
                    ceros++;
                }
                else
                {
                    negativos++;
                    suman = suman + numero;
                }
            }

            double promediop = CalcularPromedio(sumap, positivos);
            double promedion = CalcularPromedio(suman, negativos);


            Console.WriteLine("Cantidad de numeros positivos: " + positivos);
            Console.WriteLine("Cantidad de numeros negativos: " + negativos);
            Console.WriteLine("Cantidad de numeros que son 0: " + ceros);

            Console.WriteLine("Promedio de numeros positivos: " + promediop);
            Console.WriteLine("Promedio de numeros negativos: " + promedion);
        }

        static double CalcularPromedio(int suma, int cantidad)
        {
            return (double)suma / cantidad;
        }
    }
}

      