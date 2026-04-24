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
            Console.Write("Ingresar horas estacionado: ");
            int horas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar dinero disponible: ");
            int dinero = Convert.ToInt32(Console.ReadLine());

            int total;

            if (horas == 1)
            {
                total = 4000;
            }
            else
            {
                total = 4000 + (horas - 1) * 1600;
            }

            if (dinero >= total)
            {
                int cambiuo = dinero - total;
                Console.WriteLine("Pago realizado. Vuelto: " + cambiuo);
            }
            else
            {
                int falta = total - dinero;
                Console.WriteLine("Falta dinero: " + falta);
            }
        }
    }
}
