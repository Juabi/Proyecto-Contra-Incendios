using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Piso_2
    {
        public static int G201 = 0, G202 = 0, G203 = 0;


        public static void PlantaPiso2()
        {
            Console.Clear();
            ENERGIA.ResBat();

            Random rnd = new Random();
            G201 = rnd.Next(20, 36);
            G202 = rnd.Next(20, 36);
            G203 = rnd.Next(20, 36);

            Estetica.ContunuacionPiso2();
            Estetica.MapaP2();
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

                G201 += rnd.Next(-5, 21); 
                G202 += rnd.Next(-5, 21); 
                G203 += rnd.Next(-5, 21);

                int H201 = 0, H202 = 0, H203 = 0;
                //Detec Humo G101
                if (G201 <= 35) { H201 += rnd.Next(0, 2); }
                else if (G201 > 35 && G201 <= 79) { H201 += rnd.Next(1, 4); }
                else if (G201 > 79) { H201 += rnd.Next(3, 7); }
                //Detec Humo G102
                if (G202 <= 35) { H202 += rnd.Next(0, 2); }
                else if (G202 > 35 && G202 <= 79) { H202 += rnd.Next(1, 4); }
                else if (G202 > 79) { H202 += rnd.Next(3, 7); }
                //Detec Humo G103
                if (G203 <= 35) { H203 += rnd.Next(0, 2); }
                else if (G203 > 35 && G203 <= 79) { H203 += rnd.Next(1, 4); }
                else if (G203 > 79) { H203 += rnd.Next(3, 7); }

                General2(G201, 47, 6); General2(G202, 68, 6); General2(G203, 89, 6);

                General(H201, 47, 7); General(H202, 68, 7); General(H203, 89, 7);

                Thread.Sleep(1000);
                if (G201 >= 93 || G202 >= 93 || G203 >= 93 || H201 == 6 || H202 == 6 || H203 == 6 )
                {
                    Console.Clear();
                    if (G201 >= 93)
                    {
                        AlarmaPiso2.AlarmaCalor201(); break;
                    }
                    else if (G202 >= 93)
                    {
                        AlarmaPiso2.AlarmaCalor202(); break;
                    }
                    else if (G203 >= 93)
                    {
                        AlarmaPiso2.AlarmaCalor203(); break;
                    }
                    else if (H201 == 6)
                    {
                        AlarmaPiso2.AlarmaHumo201(); break;
                    }
                    else if (H202 == 6)
                    {
                        AlarmaPiso2.AlarmaHumo202(); break;
                    }
                    else if (H203 == 6)
                    {
                        AlarmaPiso2.AlarmaHumo203(); break;
                    }
                }

                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.D1)
                {
                    Console.SetCursorPosition(0, 12);
                    TextUtilities.EscribirLento("Volviendo...", 50); 
                    Menu.EjecutarMenu(); break;
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
