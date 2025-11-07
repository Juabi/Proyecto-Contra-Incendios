using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Piso_3
    {
        public static int G301 = 0, G302 = 0;


        public static void PlantaPiso3()
        {
            Console.Clear();
            ENERGIA.ResBat();

            Random rnd = new Random();
            G301 = rnd.Next(20, 35); G302 = rnd.Next(20, 35);


            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("Piso 3                           |                                                                                     ");
            Console.WriteLine("---------------------------------|                                                                                     ");
            Console.WriteLine("                                     ________________________________________________________________");
            Console.WriteLine("                                     |                    |                    |                    |");
            Console.WriteLine("                                     |        G301        |                    |        G302        |");
            Console.WriteLine("                                     |                    |                    |                    |");
            Console.WriteLine("                                     |                    |                    |                    |");
            Console.WriteLine("                                     |________    ________|________    ________|________    ________|");
            Console.WriteLine("                                     |                                                            __|");
            Console.WriteLine("                                     |                                                           | ex");
            Console.WriteLine("                                     |                    ________ _  _ ________                 | it");
            Console.WriteLine("                                     |                    |      Elevador      |                 |__");
            Console.WriteLine("                                     |_______      _______|____________________|_______      _______|");
            Console.WriteLine("                                     | e    |      |      |                    |      |      | e    |");
            Console.WriteLine("                                     | m    |      |      |                    |      |      | m    |");
            Console.WriteLine("                                     | e  e |      |      |                    |      |      | e  e |");
            Console.WriteLine("                                     | r  x |      |      |                    |      |      | r  x |");
            Console.WriteLine("                                     | g  i |      |      |                    |      |      | g  i |");
            Console.WriteLine("                                     | e  t |      |      |                    |      |      | e  t |");
            Console.WriteLine("                                     | n                  |                    |               n    |");
            Console.WriteLine("                                     | c                  |                    |               c    |");
            Console.WriteLine("                                     |_y____|______|______|                    |______|______|_y____|");
            Estetica.Gris();
            Console.SetCursorPosition(0, 5);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("        Monitoreo de Pisos        ");
            Console.WriteLine("----------------------------------");
            Beeps.Beep1();
            Console.WriteLine("[1]Volver");
            Beeps.Beep1();
            Console.WriteLine("[2]Reinicio de emergencia");
            while (true)
            {

                G301 += rnd.Next(-5, 20); G302 += rnd.Next(-5, 20);

                int H301 = 0, H302 = 0;
                //Detec Humo G101
                if (G301 <= 35) { H301 += rnd.Next(0, 2); }
                else if (G301 > 35 && G301 < 79) { H301 += rnd.Next(1, 4); }
                else if (G301 > 79) { H301 += rnd.Next(3, 7); }
                //Detec Humo G102
                if (G302 <= 35) { H302 += rnd.Next(0, 2); }
                else if (G302 > 35 && G302 <= 79) { H302 += rnd.Next(1, 4); }
                else if (G302 > 79) { H302 += rnd.Next(3, 7); }

                General2(G301, 47, 6); General2(G302, 89, 6);

                General(H301, 47, 7); General(H302, 89, 7);

                Thread.Sleep(1000);
                if (G301 >= 93 || G302 >= 93 || H301 == 6 || H302 == 6)
                {
                    break;
                }

                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.D1)
                {
                    Console.SetCursorPosition(0, 12);
                    TextUtilities.EscribirLento("Volviendo...", 50); Menu.EjecutarMenu(); break;
                }
                else if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.D2)
                {
                    Console.Clear();
                    ENERGIA.RestablecerSistemas();
                }
            }
        }
        internal static void General2(int G, int x, int y)
        {
            if (G <= 35)
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(G + "C°");
                Console.ResetColor();
            }
            else if (G > 35 && G <= 79)
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(G + "C°");
                Console.ResetColor();
            }
            else if (G > 79)
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(G + "C°");
                Console.ResetColor();
            }
        }
        internal static void General(int H, int x, int y)
        {

            switch (H)
            {
                case 0:
                    Console.SetCursorPosition(x, y);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(H + "%");
                    Console.ResetColor();
                    break;
                case 1:
                    Console.SetCursorPosition(x, y);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(H + "%");
                    Console.ResetColor();
                    break;
                case 2:
                    Console.SetCursorPosition(x, y);
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(H + "%");
                    Console.ResetColor();
                    break;
                case 3:
                    Console.SetCursorPosition(x, y);
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(H + "%");
                    Console.ResetColor();
                    break;
                case 4:
                    Console.SetCursorPosition(x, y);
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(H + "%");
                    Console.ResetColor();
                    break;
                case 5:
                    Console.SetCursorPosition(x, y);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(H + "%");
                    Console.ResetColor();
                    break;
                case 6:
                    Console.SetCursorPosition(x, y);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(H + "%");
                    Console.ResetColor();
                    break;

            }
        }
    }
}
