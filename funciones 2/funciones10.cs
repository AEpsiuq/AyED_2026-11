using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Ingresar un numero entero positivo: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                int cantidadr = representaciones(numero);

                if (cantidadr == 0)
                {
                    Console.WriteLine("No se encontraron representaciones");
                }
                else
                {
                    Console.WriteLine("Cantidad de representaciones: " + cantidadr);
                }
            }
            else
            {
                Console.WriteLine("El numero tiene que ser positivo");
            }
        }
        static int representaciones(int numero)
        {
            int cantidadRepresent = 0;

            for (int inicio = 1; inicio < numero; inicio++)
            {
                int suma = 0;
                int siguiente = inicio;
                int c_terminos = 0;

                while (suma < numero)
                {
                    suma = suma + siguiente;
                    c_terminos++;

                    if (suma == numero && c_terminos >= 2)
                    {
                        for (int i = inicio; i <= siguiente; i++)
                        {
                            Console.Write(i);

                            if (i < siguiente)
                            {
                                Console.Write(" + ");
                            }
                        }
                        Console.WriteLine(" = " + numero);
                        cantidadRepresent++;
                    }
                    siguiente++;
                }
            }
            return cantidadRepresent;
        }
    }
}
