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

            TextUtilities.EscribirLento("Iniciando aplicación...", 50);
            Thread.Sleep(1000);

            Menu.EjecutarMenu();

            Beeps.Beep1();
            TextUtilities.EscribirLento("Aplicación finalizada.", 50);
            
        }
    }
}
