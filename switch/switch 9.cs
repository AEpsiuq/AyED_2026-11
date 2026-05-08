using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            int contador = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Ingrese gasto del día " + i + ": ");
                int gasto = Convert.ToInt32(Console.ReadLine());

                acumulador = acumulador + gasto;

                if (gasto > 550)
                {
                    contador++;
                }
            }

            Console.WriteLine("Suma total de gastos: " + acumulador);
            Console.WriteLine("Gastos mayores a 550: " + contador);
        }
    }

}
    
