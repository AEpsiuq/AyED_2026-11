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

            int capacidad;
            int estado;

            int utilizables = 0;
            int conFallas = 0;
            int rechazados = 0;

            double costoPerdido = 0;

            // PRIMERA ETAPA - LOTE FIJO DE 9 ENVASES

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("Ingrese capacidad del envase:");
                capacidad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese estado (1: Perfecto, 2: Con fallas leves, 3: Rechazado):");
                estado = Convert.ToInt32(Console.ReadLine());

                if (estado == 1)
                {
                    utilizables++;
                }
                else if (estado == 2)
                {
                    utilizables++;
                    conFallas++;
                }
                else if (estado == 3)
                {
                    rechazados++;

                    if (capacidad == 375)
                    {
                        costoPerdido = costoPerdido + 0.58;
                    }
                    else if (capacidad == 500)
                    {
                        costoPerdido = costoPerdido + 1.12;
                    }
                    else if (capacidad == 1500)
                    {
                        costoPerdido = costoPerdido + 2.28;
                    }
                }
            }

            // SEGUNDA ETAPA - PRODUCCIÓN CONTINUA

            Console.WriteLine("Ingrese capacidad del envase:");
            capacidad = Convert.ToInt32(Console.ReadLine());

            while (capacidad > 0)
            {
                Console.WriteLine("Ingrese estado (1: Perfecto, 2: Con fallas leves, 3: Rechazado):");
                estado = Convert.ToInt32(Console.ReadLine());

                if (estado == 1)
                {
                    utilizables++;
                }
                else if (estado == 2)
                {
                    utilizables++;
                    conFallas++;
                }
                else if (estado == 3)
                {
                    rechazados++;

                    if (capacidad == 375)
                    {
                        costoPerdido = costoPerdido + 0.58;
                    }
                    else if (capacidad == 500)
                    {
                        costoPerdido = costoPerdido + 1.12;
                    }
                    else if (capacidad == 1500)
                    {
                        costoPerdido = costoPerdido + 2.28;
                    }
                }

                Console.WriteLine("Ingrese capacidad del envase:");
                capacidad = Convert.ToInt32(Console.ReadLine());
            }

            // CÁLCULO DEL PORCENTAJE

            int totalEnvases = utilizables + rechazados;
            double porcentajeFallas = (double)conFallas * 100 / totalEnvases;

            // RESULTADOS

            Console.WriteLine("Cantidad de envases utilizables: " + utilizables);
            Console.WriteLine("Porcentaje de envases con fallas: " + porcentajeFallas + "%");
            Console.WriteLine("Cantidad de envases rechazados: " + rechazados);
            Console.WriteLine("Costo perdido por rechazados: $" + costoPerdido);

        }
    }
}
