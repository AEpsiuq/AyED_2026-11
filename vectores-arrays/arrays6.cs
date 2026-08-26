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
            double[] sucursal1 = new double[5];
            double[] sucursal2 = new double[5];

            double total1 = 0;
            double total2 = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingresar venta de sucursal 1, día " + (i + 1) + ": ");
                sucursal1[i] = Convert.ToDouble(Console.ReadLine());

                total1 = total1 + sucursal1[i];

                Console.Write("Ingresar venta de sucursal 2, día " + (i + 1) + ": ");
                sucursal2[i] = Convert.ToDouble(Console.ReadLine());

                total2 = total2 + sucursal2[i];
            }

            double mayor1 = sucursal1[0];
            int diaMayor1 = 1;

            double mayor2 = sucursal2[0];
            int diaMayor2 = 1;

            for (int i = 1; i < 5; i++)
            {
                if (sucursal1[i] > mayor1)
                {
                    mayor1 = sucursal1[i];
                    diaMayor1 = i + 1;
                }

                if (sucursal2[i] > mayor2)
                {
                    mayor2 = sucursal2[i];
                    diaMayor2 = i + 1;
                }
            }

            Console.WriteLine("Sucursal 1 vendió más el día " + diaMayor1);
            Console.WriteLine("Sucursal 2 vendió más el día " + diaMayor2);

            if (mayor1 > mayor2)
            {
                Console.WriteLine("La sucursal 1 vendió más ese día.");
            }
            else
            {
                Console.WriteLine("La sucursal 2 vendió más ese día.");
            }

            Console.WriteLine("Recaudación total sucursal 1: $" + total1);
            Console.WriteLine("Recaudación total sucursal 2: $" + total2);

            if (total1 > total2)
            {
                Console.WriteLine("La sucursal 1 tuvo mayor recaudación acumulada.");
            }
            else
            {
                Console.WriteLine("La sucursal 2 tuvo mayor recaudación acumulada.");
            }

        }
    }
}
