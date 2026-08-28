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
            Console.WriteLine("Ingresar un numero entero positivo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            ContarRegresivo(numero);
        }
        static void ContarRegresivo(int numero)
        {
            while (numero >= 1)
            {
                numero--;
                Console.WriteLine(numero);
            }
        }
    
    }
}
