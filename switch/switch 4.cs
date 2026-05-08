using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_4
{
class Program
{
    static void Main(string[] args)
    {
        int contador = 0;
        int numero = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Ingrese un numero cualquiera: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 100)
            {
                contador = contador + 1;
            }
        }

        Console.WriteLine("Hubo " + contador + " valores mayores a 100");
    }
}
}
