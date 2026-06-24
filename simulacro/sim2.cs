using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    class Program
    {
        static void Main(string[] args)
        {
            char categoria;
            char respuesta;

            int influencers = 0;
            int periodistas = 0;
            int estudiantes = 0;

            int mayores = 0;
            int menores = 0;
            int jubilados = 0;

            int facturacionTotal = 0;

            // PRIMERA ETAPA - FUNCIÓN DE PRENSA

            for (int i = 1; i <= 35; i++)
            {
                Console.WriteLine("Ingrese categoría (A: Influencers, B: Periodistas, C: Estudiantes):");
                categoria = Convert.ToChar(Console.ReadLine());

                switch (categoria)
                {
                    case 'A':
                        influencers++;
                        break;

                    case 'B':
                        periodistas++;
                        break;

                    case 'C':
                        estudiantes++;
                        break;
                }
            }

            // SEGUNDA ETAPA - VENTAS COMERCIALES

            Console.WriteLine("¿Desea registrar una venta? (S/N)");
            respuesta = Convert.ToChar(Console.ReadLine());

            while (respuesta != 'N')
            {
                Console.WriteLine("Ingrese categoría (D: Mayores, E: Menores, F: Jubilados):");
                categoria = Convert.ToChar(Console.ReadLine());

                switch (categoria)
                {
                    case 'D':
                        mayores++;
                        facturacionTotal = facturacionTotal + 18000;
                        break;

                    case 'E':
                        menores++;
                        facturacionTotal = facturacionTotal + 12000;
                        break;

                    case 'F':
                        jubilados++;
                        facturacionTotal = facturacionTotal + 10000;
                        break;
                }

                Console.WriteLine("¿Desea registrar una venta? (S/N)");
                respuesta = Convert.ToChar(Console.ReadLine());
            }

            // FINALIZACIÓN

            Console.WriteLine("Ingrese Z para mostrar resultados:");
            categoria = Convert.ToChar(Console.ReadLine());

            if (categoria == 'Z')
            {
                Console.WriteLine("----- FUNCION DE PRENSA -----");

                Console.WriteLine("Influencers: " + influencers);
                Console.WriteLine("Periodistas: " + periodistas);
                Console.WriteLine("Estudiantes: " + estudiantes);

                Console.WriteLine("----- FUNCIONES COMERCIALES -----");

                Console.WriteLine("Mayores: " + mayores);
                Console.WriteLine("Menores: " + menores);
                Console.WriteLine("Jubilados: " + jubilados);

                Console.WriteLine("Facturación Total: $" + facturacionTotal);
            }

        }
    }
}
