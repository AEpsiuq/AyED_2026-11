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
            int secreto = 15;
            int intentos = 0;
            int numer = 0;

            while (numer != secreto && intentos < 5)
            {
                Console.Write("Ingrese un número: ");
                numer = Convert.ToInt32(Console.ReadLine());

                intentos++;

                if (numer < secreto)
                {
                    Console.WriteLine("El número es mayor");
                }
                else
                {
                    if (numer > secreto)
                    {
                        Console.WriteLine("El número es menor");
                    }
                }
            }

            if (numer == secreto)
            {
                Console.WriteLine("Ganaste");
                Console.WriteLine("Intentos usados: " + intentos);
            }
            else
            {
                Console.WriteLine("Perdiste");
                Console.WriteLine("Intentos usados: " + intentos);
            }
        }
    }
}
    

