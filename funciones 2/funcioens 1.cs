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
            Console.Write("Ingresar cantidad de numeros: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            int suma = 0;
            int par = 0;
            int impar = 0;

            int mayor = 0;
            int menor = 0;

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write("Ingresar un numero entero: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                suma = suma + numero;

                if ( numero % 2 == 0 )
                {
                    par++;
                }
                else
                {
                    impar++;
                }

                if (i == 1)
                {
                    mayor = numero;
                    menor = numero;
                }
                else
                {
                    if (numero > mayor)
                    {
                        mayor = numero;
                    }
                    if (numero < menor)
                    {
                        menor = numero;
                    }
                }
            }
            double promedio = (double) suma / cantidad;

            Console.WriteLine("El promedio es: " + promedio);
            Console.WriteLine("Cantidad de numeros pares: " + par);
            Console.WriteLine("Cantidad de numeros impares: " + impar);
            Console.WriteLine("El numero mayor de los " + cantidad + " numeros es : " + mayor);
            Console.WriteLine("El numero menor de los " + cantidad + " numeros es : " + menor);
          
        }
    }
}
