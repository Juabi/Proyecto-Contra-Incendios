using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.NetworkInformation;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Serialization.Formatters;
namespace Biblioteca
{
    public class Piso_1
    {
        
        public static int G101 = 0, G102 = 0, G103 = 0;
        
        
        public static void PlantaPiso1()
        {
            Console.Clear();
            ENERGIA.ResBat();

            Random rnd = new Random();
            G101 = rnd.Next(20, 36);
            G102 = rnd.Next(20, 36);
            G103 = rnd.Next(20, 36);

            Estetica.ContunuacionPiso1();
            Estetica.MapaP1();
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
                
                G101 += rnd.Next(-5, 21);
                G102 += rnd.Next(-5, 21);
                G103 += rnd.Next(-5, 21);

                int H101 = 0, H102 = 0, H103 = 0;
                //Detec Humo G101
                if (G101<=35){H101 += rnd.Next(0,2);}
                else if (G101 > 35 && G101 <= 79){H101 += rnd.Next(1, 4);}
                else if (G101 > 79 ){H101 += rnd.Next(3, 7);}
                //Detec Humo G102
                if (G102 <= 35){H102 += rnd.Next(0, 2);}
                else if (G102 > 35 && G102 <= 79){H102 += rnd.Next(1, 4);}
                else if (G102 > 79) {H102 += rnd.Next(3, 7);}
                //Detec Humo G103
                if (G103 <= 35){H103 += rnd.Next(0, 2);}
                else if (G103 > 35 && G103 <= 79){H103 += rnd.Next(1, 4);}
                else if (G103 > 79 ) {H103 += rnd.Next(3, 7);}

                General2(G101, 47, 6);General2(G102, 68, 6); General2(G103, 89, 6);

                General(H101, 47, 7);General(H102, 68, 7);General(H103, 89, 7);

                Thread.Sleep(1000);
                
                if (G101 >= 93 || G102 >= 93 || G103 >= 93 || H101 == 6 || H102 == 6 || H103 == 6)
                {
                    Console.Clear();
                    if (G101 > 93)
                    {
                        AlarmasPiso1.AlarmaCalor101(); break;
                    }
                    else if (G102 >= 93)
                    {
                        AlarmasPiso1.AlarmaCalor102(); break;
                    }
                    else if (G103 >= 93)
                    {
                        AlarmasPiso1.AlarmaCalor103(); break;
                    }
                    else if (H101 == 6)
                    {
                        AlarmasPiso1.AlarmaHumo101(); break;
                    }
                    else if (H102 == 6)
                    {
                        AlarmasPiso1.AlarmaHumo102(); break;
                    }
                    else if (H103 == 6)
                    {
                        AlarmasPiso1.AlarmaHumo103(); break;
                    }

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
