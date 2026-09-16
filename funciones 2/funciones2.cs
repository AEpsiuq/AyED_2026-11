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
            int numero1;
            int numero2;
            int menor;
            int mayor;
            int pares = 0;
            int impares = 0;
            int suma = 0;

            Console.Write("Ingrese el primer número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            menor = ObtenerMenor(numero1, numero2);
            mayor = ObtenerMayor(numero1, numero2);

            for (int i = menor; i <= mayor; i++)
            {
                Console.WriteLine(i);
                suma = suma + i;
                pares = pares + ContarPar(i);
                impares = impares + ContarImpar(i);
            }

            Console.WriteLine("Cantidad de pares: " + pares);
            Console.WriteLine("Cantidad de impares: " + impares);
            Console.WriteLine("Suma total: " + suma);
        }
        static int ObtenerMenor(int numero1, int numero2)
        {
            if (numero1 < numero2)
            {
                return numero1;
            }
            return numero2;
        }
        static int ObtenerMayor(int numero1, int numero2)
        {
            if (numero1 > numero2)
            {
                return numero1;
            }
            return numero2;
        }
        static int ContarPar(int numero)
        {
            if (numero % 2 == 0)
            {
                return 1;
            }
            return 0;
        }
        static int ContarImpar(int numero)
        {
            if (numero % 2 != 0)
            {
                return 1;
            }
            return 0;
        }
    }
}
   