using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Biblioteca;

namespace Proyecto_Contra_Incendios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            //ActualizacionBateria.Energia();
            //Random rnd = new Random();
            //int a = rnd.Next(20);
            //Console.WriteLine($"\ra {a}");
            //while (true)
            //{
            //    a += rnd.Next(4);

            //}
            //Console.WriteLine($"\ra {a}");
            

          

            TextUtilities.EscribirLento("Iniciando aplicación...", 50);
            Thread.Sleep(1000);

            Menu.EjecutarMenu();

            Beeps.Beep1();
            TextUtilities.EscribirLento("Aplicación finalizada.", 50);
            
        }
    }
}
