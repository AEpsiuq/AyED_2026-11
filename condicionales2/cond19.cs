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
            Console.Write("Facturas producidas: ");
            int total = Convert.ToInt32(Console.ReadLine());

            Console.Write("Docenas vendidas: ");
            int docenas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Precio por docena: ");
            int precio = Convert.ToInt32(Console.ReadLine());

            int vendidas = docenas * 12;
            int sobrantes = total - vendidas;
            int dinero = docenas * precio;

            Console.WriteLine("Sobrantes: " + sobrantes);
            Console.WriteLine("Dinero recaudado: " + dinero);

            if (sobrantes > 6)
            {
                Console.WriteLine("Alerta: Exceso de producción");
            }
            else
            {
                Console.WriteLine("Producción eficiente");
            }
        }
    }

}
    
