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
            Console.Write("Ingrese usuario: ");
            string usuario = Console.ReadLine();

            Console.Write("Ingresar contraseña: ");
            string clave = Console.ReadLine();

            if (usuario == "admin")
            {
                if (clave == "1234")
                {
                    Console.WriteLine("Acceso concedido");
                }
                else
                {
                    Console.WriteLine("Error de credenciales");
                }
            }
            else
            {
                Console.WriteLine("Error de credenciales");
            }
        }
    }

}
    

