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

            int mayor = 0;
            int segundoMayor = 0;

            int existeSegundo = 0;

            Console.Write("Ingresar la cantidad de numeros: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write("Ingresar un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                {
                    mayor = numero;
                }
                else
                {
                    if (numero > mayor)
                    {
                        segundoMayor = mayor;
                        mayor = numero;
                        existeSegundo = 1;
                    }
                    else
                    {
                        if (numero < mayor)
                        {
                            if (existeSegundo == 0 || numero > segundoMayor)
                            {
                                segundoMayor = numero;
                                existeSegundo = 1;
                            }
                        }
                    }
                }
            }

            if (existeSegundo == 1)
            {
                Console.WriteLine("El mayor numero es: " + mayor);
                Console.WriteLine("El segundo numero más grande es: " + segundoMayor);
            }
            else
            {
                Console.WriteLine("No existe un segundo numero diferente al mayor.");
            }
        }
        static int ObtenerMayor(int mayor, int numero)
        {
            if (numero > mayor)
            {
                return numero;
            }
            return mayor;
        }
    }
}




