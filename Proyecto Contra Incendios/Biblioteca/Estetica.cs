using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estetica
    {
        public static void Gris()
        {
            Console.SetCursorPosition(0, 5);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("----------------------------------");
            Console.WriteLine("              ");
            Console.WriteLine("----------------------------------");
            Console.ResetColor();
        }
        public static void Cara1()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" =================================");
            Console.WriteLine("|                                 |");
            Console.WriteLine(" =================================");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|_________________________________|");
            Console.ResetColor();
        }
    }
}
