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
            Console.Write("Ingresar primer valor: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar segundo valor: ");
            int num2 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Ingresar tercer valor: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2 && num2 == num3 && num1 == num3)
            {
                Console.WriteLine("Equilatero");
            }
            else
            {
                if (num1 == num2 && num2 != num3 && num1 != num3)
                {
                    Console.WriteLine("Isosceles");
                }
                else
                {
                    if (num1 != num2 && num2 != num3)
                    {
                        Console.WriteLine("Escaleno");
                    }
                }
            }

        }
    }
}
