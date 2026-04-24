using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingresar promedio: ");
            int promedio = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar distancia (km): ");
            int distancia = Convert.ToInt32(Console.ReadLine());

            if (promedio > 8)
            {
                Console.WriteLine("Beca concedida");
            }
            else
            {
                if (distancia > 50)
                {
                    Console.WriteLine("Beca concedida");
                }
                else
                {
                    Console.WriteLine("No obtiene la beca");
                }
            }
        
        }
    }
}
