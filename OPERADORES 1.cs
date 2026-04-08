using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacionaritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar primer valor: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar segundo valor: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int suma = a + b;
            int resta = a - b;
            int multiplicacion = a * b;
            int division = a / b;

            Console.WriteLine("Suma: " + suma);

            Console.WriteLine("Resta: " + resta);

            Console.WriteLine("Multiplicacion: " + multiplicacion);

            Console.WriteLine("Division: " + division);

        }
    }
}
