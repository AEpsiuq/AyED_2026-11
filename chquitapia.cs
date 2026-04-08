using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacionaritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cantidad de minutos: ");
            int minutos = Convert.ToInt32(Console.ReadLine());

            int horas = minutos / 60;
            Console.WriteLine("Horas: " + horas);
            int resto = minutos % 60;
            Console.WriteLine("Minutos: " + resto);

            int costo_total1 = 6000 * horas;
            int costo_total2 = 150 * resto;
            int costo_final = costo_total1 + costo_total2;

            int iva = costo_final* 21 / 100;
            int monto_final = iva + costo_final;

            Console.WriteLine("Monto final a pagar es de: " + monto_final);
        }
    }
}
