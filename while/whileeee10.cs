using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar el primer número: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar el segundo número: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int resultado = 0;
            int i = 1;

            while (i <= b)
            {
                resultado = resultado + a;
                i++;
            }

            Console.WriteLine("Resultado: " + resultado);
        }
    }
}


