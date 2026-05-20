using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiledowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar un numero: ");
            int numero = int.Parse(Console.ReadLine());
            int contador = 0;

            Console.WriteLine("Comienza la cuenta regresiva: ");

            while (numero > -1)
            {
                Console.WriteLine("Numero: " + numero);
                numero--;
                contador++;
            }
            Console.WriteLine("Numeros contados: " + contador);
        }
    }
}
