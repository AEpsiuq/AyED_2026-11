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

            Console.Write("Numeros que desea ingresar: ");
            cantidad = int.Parse(Console.ReadLine());

            int[] numeros = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingresar un numero:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            repetidos(numeros, cantidad);
        }
        static void repetidos(int[] numeros, int cantidad)
        {
            int mayor = 0;
            int repetidos;

            for (int i = 0; i < cantidad; i++)
            {
                repetidos = 0;
                for (int j = 0; j < cantidad; j++)
                {
                    if (numeros[i] == numeros[j])
                    {
                        repetidos++;
                    }
                }
                if (repetidos > mayor)
                {
                    mayor = repetidos;
                }
            }
            Console.WriteLine("Numeros mas repetidos::");

            for (int i = 0; i < cantidad; i++)
            {
                repetidos = 0;

                for (int j = 0; j < cantidad; j++)
                {
                    if (numeros[i] == numeros[j])
                    {
                        repetidos++;
                    }
                }
                if (repetidos == mayor)
                {
                    int encontrado = 0;

                    for (int j = 0; j < i; j++)
                    {
                        if (numeros[i] == numeros[j])
                        {
                            encontrado = 1;
                        }
                    }
                    if (encontrado == 0)
                    {
                        Console.WriteLine("numero: " + numeros[i]);
                        Console.WriteLine("veces que aparece: " + repetidos);
                    }
                }
            }
        }
    }
}




 