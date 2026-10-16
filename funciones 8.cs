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
            int num1;
            int num2;
            int menor;
            int mayor;
            int cantidad = 0;

            Console.Write("Ingresar el primer numero extremo: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar el segundo numero extremo: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2)
            {
                menor = num1;
                mayor = num2;
            }
            else
            {
                menor = num2;
                mayor = num1;
            }

            Console.WriteLine("Numeros primos encontrados: ");

            for (int i = menor; i <= mayor; i++)
            {
                if (primo(i) == 1)
                {
                    Console.WriteLine(i);
                    cantidad++;
                }
            }
            Console.WriteLine("Cantidad de numeros primos: " + cantidad);
        }

        static int primo(int numero)
        {
            if (numero < 2)
            {
                return 0;
            }

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}







     
    




