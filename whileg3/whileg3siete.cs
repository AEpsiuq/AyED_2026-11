using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileg3
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "S";
            int presentes = 0;
            int ausentes = 0;

            while (continuar == "S" || continuar == "s")
            {
                Console.Write("Nombre del alumno: ");
                string nombre = Console.ReadLine();

                Console.Write("Estado (P/A): ");
                string estado = Console.ReadLine();

                if (estado == "P" || estado == "p")
                {
                    presentes++;
                }
                else
                {
                    ausentes++;
                }

                Console.Write("¿Cargar otro alumno? (S/N): ");
                continuar = Console.ReadLine();
            }

            int total = presentes + ausentes;
            double porcentaje = presentes * 100.0 / total;

            Console.WriteLine("Presentes: " + presentes);
            Console.WriteLine("Ausentes: " + ausentes);
            Console.WriteLine("Presentismo: " + porcentaje + "%");

        }
    }
}
