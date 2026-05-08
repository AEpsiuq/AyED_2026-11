using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_3
{
class Program
{
static void Main(string[] args)
{
        int ahorroAcumulado = 0;
        int ahorro = 0;

        for (int i = 1; i <= 4; i++)
        {
            Console.Write("Ingrese el ahorro de la semana N° " + i + ": ");
            ahorro = int.Parse(Console.ReadLine());

            ahorroAcumulado = ahorroAcumulado + ahorro;
        }

        Console.WriteLine("El dinero acumulado en el mes es de " + ahorroAcumulado);
    }
}
}
