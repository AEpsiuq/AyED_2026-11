using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcioness2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            int numero;
            int mayor = 0;
            int menor = 0;
            int suma = 0;
            int pares = 0;
            int impares = 0;

            Console.Write("Ingrese la cantidad de números: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write("Ingrese un número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                {
                    mayor = numero;
                    menor = numero;
                }
                else
                {
                    mayor = ObtenerMayor(mayor, numero);
                    menor = ObtenerMenor(menor, numero);
                }

                suma = suma + numero;
                pares = pares + ContarPar(numero);
                impares = impares + ContarImpar(numero);
            }

            double promedio = CalcularPromedio(suma, cantidad);

            Console.WriteLine("Mayor: " + mayor);
            Console.WriteLine("Menor: " + menor);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Cantidad de pares: " + pares);
            Console.WriteLine("Cantidad de impares: " + impares);
        }
        static int ObtenerMayor(int mayor, int numero)
        {
            if (numero > mayor)
            {
                mayor = numero;
            }

            return mayor;
        }

        static int ObtenerMenor(int menor, int numero)
        {
            if (numero < menor)
            {
                menor = numero;
            }

            return menor;
        }
        static int ContarPar(int numero)
        {
            if (numero % 2 == 0)
            {
                return 1;
            }

            return 0;
        }
        static int ContarImpar(int numero)
        {
            if (numero % 2 != 0)
            {
                return 1;
            }

            return 0;
        }
        static double CalcularPromedio(int suma, int cantidad)
        {
            return (double)suma / cantidad;
        }
    }
}
     

