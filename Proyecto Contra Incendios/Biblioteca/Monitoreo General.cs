using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Monitoreo_General
    {
        public static int G101 = 0, G102 = 0, G103 = 0, G201 = 0, G202 = 0, G203 = 0, G301 = 0, G302 = 0;
        public static void QuienSabe()
        {
            Console.Clear();

            Console.SetCursorPosition(0, 5);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("             Menú SCI             ");
            Console.WriteLine("----------------------------------");
            Beeps.Beep1();
            Console.WriteLine("[1]Volver");
            Beeps.Beep1();
            Console.WriteLine("[2]Reinicio de emergencia");
        }
        public static void Totalpisos()
        {
            Console.Clear();
            ENERGIA.ResBat();

            Random rnd = new Random();
            G101 = rnd.Next(20, 35); G102 = rnd.Next(20, 35); G103 = rnd.Next(20, 35);
            G201 = rnd.Next(20, 35); G202 = rnd.Next(20, 35); G203 = rnd.Next(20, 35);
            G301 = rnd.Next(20, 35); G302 = rnd.Next(20, 35);



            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("Control Total Pisos              |                                                                                     ");
            Console.WriteLine("---------------------------------|                                                                                     ");
            Console.WriteLine("                                                        C°|H%          C°|H%            C°|H%        ");
            Console.WriteLine("                                                                                                     ");
            Console.WriteLine("                                     Piso 1:     G101:    |     G102:    |      G103:     |          ");
            Console.WriteLine("                                                                                                     ");
            Console.WriteLine("                                                                                                     ");
            Console.WriteLine("                                                                                                     ");
            Console.WriteLine("                                                                                                     ");
            Console.WriteLine("                                     Piso 2:     G201:    |     G202:    |      G203:     |          ");
            Console.WriteLine("                                                                                                     ");
            Console.WriteLine("                                                                                                     ");
            Console.WriteLine("                                                                                                     ");
            Console.WriteLine("                                                                                                     ");
            Console.WriteLine("                                     Piso 3:     G301:    |     G302:    |                           ");
            Console.WriteLine("                                                                                                     ");
            Console.WriteLine("                                                                                                     ");
            Console.WriteLine("                                                                                                     ");
            Console.WriteLine("                                                                                                     ");
            Console.WriteLine("                                                                                                     ");
            Console.WriteLine("                                                                                                     ");
            Console.WriteLine("                                                                                                     ");
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

                G101 += rnd.Next(-5, 20); G102 += rnd.Next(-5, 20); G103 += rnd.Next(-5, 20);
                G201 += rnd.Next(-5, 20); G202 += rnd.Next(-5, 20); G203 += rnd.Next(-5, 20);
                G301 += rnd.Next(-5, 20); G302 += rnd.Next(-5, 20);

                int H101 = 0, H102 = 0, H103 = 0;
                int H201 = 0, H202 = 0, H203 = 0;
                int H301 = 0, H302 = 0;
                //Detec Humo G101
                if (G101 <= 35){H101 += rnd.Next(0, 2);}
                else if (G101 > 35 && G101 < 79){ H101 += rnd.Next(1, 4);}
                else if (G101 > 79){ H101 += rnd.Next(3, 7); }
                //Detec Humo G102
                if (G102 <= 35){H102 += rnd.Next(0, 2);}
                else if (G102 > 35 && G102 <= 79){H102 += rnd.Next(1, 4);}
                else if (G102 > 79) { H102 += rnd.Next(3, 7);}
                //Detec Humo G103
                if (G103 <= 35){H103 += rnd.Next(0, 2);}
                else if (G103 > 35 && G103 <= 79){ H103 += rnd.Next(1, 4);}
                else if (G103 > 79) { H103 += rnd.Next(3, 7);}

                //Detec Humo G201
                if (G201 <= 35) { H201 += rnd.Next(0, 2); }
                else if (G201 > 35 && G201 < 79) { H201 += rnd.Next(1, 4); }
                else if (G201 > 79) { H201 += rnd.Next(3, 7); }
                //Detec Humo G202
                if (G202 <= 35) { H202 += rnd.Next(0, 2); }
                else if (G202 > 35 && G202 <= 79) { H202 += rnd.Next(1, 4); }
                else if (G202 > 79) { H202 += rnd.Next(3, 7); }
                //Detec Humo G203
                if (G203 <= 35) { H203 += rnd.Next(0, 2); }
                else if (G203 > 35 && G203 <= 79) { H203 += rnd.Next(1, 4); }
                else if (G203 > 79) { H203 += rnd.Next(3, 7); }

                //Detec Humo G301
                if (G301 <= 35) { H301 += rnd.Next(0, 2); }
                else if (G301 > 35 && G301 < 79) { H301 += rnd.Next(1, 4); }
                else if (G301 > 79) { H301 += rnd.Next(3, 7); }
                //Detec Humo G302
                if (G302 <= 35) { H302 += rnd.Next(0, 2); }
                else if (G302 > 35 && G302 <= 79) { H302 += rnd.Next(1, 4); }
                else if (G302 > 79) { H302 += rnd.Next(3, 7); }

                General2(G101, 54, 5);General2(G102, 69, 5);General2(G103, 86, 5);
                General2(G201, 54, 10); General2(G202, 69, 10); General2(G203, 86, 10);
                General2(G301, 54, 15); General2(G302, 69, 15);

                General(H101, 59, 5); General(H102, 74, 5); General(H103, 91, 5);
                General(H201, 59, 10); General(H202, 74, 10); General(H203, 91, 10);
                General(H301, 59, 15); General(H302, 74, 15);

                Thread.Sleep(1000);
                if (G101 >= 93 || G102 >= 93 || G103 >= 93 || G201 >= 93 || G202 >= 93 || G203 >= 93 || G301 >= 93 || G302 >= 93 || H101 == 6 || H102 == 6 || H103 == 6|| H201 == 6 || H202 == 6 || H203 == 6||H301 == 6 || H302 == 6 )
                {
                    break;
                }

                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.D1)
                {
                    Menu.EjecutarMenu();
                }
                else if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.D2)
                {
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
