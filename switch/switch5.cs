using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_switch
{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el valor que se va a evaluar: ");
        int valor = int.Parse(Console.ReadLine());
        int contador = 0;
        int resto = 0;

        for (int x = 1; x <= valor; x++)
        {
            resto = valor % x;

            if (resto == 0)
            {
                contador++;
            }
        }
        if (contador>2)
        {
            Console.WriteLine(valor + " no es un numero primo");
        }
        else if (contador == 2)
        {
            Console.WriteLine(valor + " es un numero primo");
        }
        else
        {
            Console.WriteLine(valor + " no es un valor valido");
        }
    }
    }
}

