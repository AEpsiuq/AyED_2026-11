using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            string clave = "";

            while (clave != "6767")
            {
                Console.Write("Ingresar la clave de acceso: ");
                clave = Console.ReadLine();
            }

            Console.WriteLine("Acceso permitido");
        } 
    }





















    
    
}

