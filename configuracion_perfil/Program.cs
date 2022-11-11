using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configuracion_perfil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            string contraseña;
            int colores; 
            

            

            Console.WriteLine("Bienvenido a la configuracion de su perfil \n");

            Console.WriteLine("Ingrese su usuaio");
            usuario = Console.ReadLine();

            Console.WriteLine("Ingrese su contraseña");
            contraseña = Console.ReadLine();


            Console.WriteLine("Eliga el color de consola que quiera");
            colores = Convert.ToByte(Console.ReadLine());

            if (colores==1)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }

            if (colores==2)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }

            if (colores == 3)
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
            }

            Console.ReadKey();
        }
    }
}
