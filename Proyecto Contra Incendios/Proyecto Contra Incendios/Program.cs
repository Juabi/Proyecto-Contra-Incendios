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


            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("                                 |                                                                                     ");
            Console.WriteLine("---------------------------------|                                                                                     ");
            Estetica.Gris();
            Console.SetCursorPosition(0, 1);
            TextUtilities.EscribirLento("Iniciando aplicación...", 50);
            
            Thread.Sleep(1000);
            
            Menu.EjecutarMenu();
            
        }
    }
}
