using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while2
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario = "";
            string clave = "";

            int intentos = 0;

            while (intentos < 3)
            {
                Console.Write("Usuario: ");
                usuario = Console.ReadLine();
              
                Console.Write("Contraseña: ");
                clave = Console.ReadLine();

                if (usuario == "admin")
                {
                    if (clave == "1234")
                    {
                        Console.WriteLine("Bienvenido al sistema");
                        intentos = 3;
                    }
                    else
                    {
                        Console.WriteLine("Datos incorrectos");
                        intentos++;
                    }
                }
                else
                {
                    Console.WriteLine("Datos incorrectos");
                    intentos++;
                }
            }
            if (usuario != "admin" || clave != "1234")
            {
                Console.WriteLine("Cuenta bloqueada por seguridad");
            }
        }
    }
}
    

