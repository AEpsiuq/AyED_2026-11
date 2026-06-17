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
            int saldo = 100;
            int apuesta;
            int dado1;
            int dado2;
            int suma;

            do
            {
                Console.WriteLine("Saldo actual: " + saldo);

                Console.Write("Ingrese apuesta (0 para salir): ");
                apuesta = Convert.ToInt32(Console.ReadLine());

                if (apuesta > 0)
                {
                    if (apuesta <= saldo)
                    {
                        Console.Write("Ingrese valor del dado 1 (1 a 6): ");
                        dado1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Ingrese valor del dado 2 (1 a 6): ");
                        dado2 = Convert.ToInt32(Console.ReadLine());

                        suma = dado1 + dado2;

                        if (suma == 7 || suma == 11)
                        {
                            Console.WriteLine("Ganaste");
                            saldo = saldo + apuesta;
                        }
                        else
                        {
                            Console.WriteLine("Perdiste");
                            saldo = saldo - apuesta;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No tienes saldo suficiente");
                    }
                }

            } while (apuesta != 0 && saldo > 0);

            Console.WriteLine("Saldo final: " + saldo);
        }
    }
}
