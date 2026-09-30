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

            Console.Write("Ingresar un numero entero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            int cantidadDigitos = ContarDigitos(numero);

            Console.WriteLine("Cantidad de dígitos: " + cantidadDigitos);

            if (EsCapicua(numero) == 1)
            {
                Console.WriteLine("El numero es capicúa.");
            }
            else
            {
                Console.WriteLine("El numero no es capicúa.");
            }
        }
        static int ContarDigitos(int numero)
        {
            int cantidad = 0;

            if (numero == 0)
            {
                return 1;
            }

            if (numero < 0)
            {
                numero = numero * -1;
            }

            while (numero > 0)
            {
                numero = numero / 10;
                cantidad++;
            }
            return cantidad;
        }

        static int InvertirNumero(int numero)
        {
            int invertido = 0;

            if (numero < 0)
            {
                numero = numero * -1;
            }
            while (numero > 0)
            {
                int digito = numero % 10;

                invertido = invertido * 10 + digito;

                numero = numero / 10;
            }
            return invertido;
        }
        static int EsCapicua(int numero)
        {
            int original = numero;

            if (numero < 0)
            {
                numero = numero * -1;
                original = numero;
            }

            int invertido = InvertirNumero(numero);

            if (original == invertido)
            {
                return 1;
            }
            return 0;
        }
    }
}
                                   
