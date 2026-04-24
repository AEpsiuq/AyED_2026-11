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
            Console.Write("Ingresar saldo: ");
            int saldo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar monto a retirar: ");
            int retiro = Convert.ToInt32(Console.ReadLine());

            if (retiro > saldo)
            {
                Console.WriteLine("Fondos insuficientes");
            }
            else
            {
                if (retiro % 1000 == 0)
                {
                    Console.WriteLine("Retiro realizado");
                }
                else
                {
                    Console.WriteLine("Solo billetes de 1000");
                }
            }
        }
    }
}
