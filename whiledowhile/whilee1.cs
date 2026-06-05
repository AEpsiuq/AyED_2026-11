using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            int saldo = 10000;

            Console.WriteLine("Bienvenido al cajero automatico...");
            Console.WriteLine("Saldo actual: 10.000");


            while (opcion != 4)
            {
                Console.WriteLine("1 - Depositar dinero");
                Console.WriteLine("2 - Retirar dinero");
                Console.WriteLine("3 - Ver saldo actual");
                Console.WriteLine("4 - Salir");

                Console.Write("Ingresar una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingresar cantidad que quiere depositar: ");
                        int cantidad = Convert.ToInt32(Console.ReadLine());

                        int platadepositada = saldo + cantidad;
                        Console.WriteLine("Saldo final: $" + platadepositada);

                        break;

                    case 2:
                        Console.Write("Ingresar cantidad que quiere retirar: ");
                        int cantidad2 = Convert.ToInt32(Console.ReadLine());

                        int plataretirada = saldo - cantidad2;
                        Console.WriteLine("Saldo final: $" + plataretirada);

                        break;

                    case 3:
                        Console.WriteLine("Saldo actual: " + saldo);
                        break;

                    case 4:
                        Console.WriteLine("Programa finalizado");
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            }
        }
    }
}
    

