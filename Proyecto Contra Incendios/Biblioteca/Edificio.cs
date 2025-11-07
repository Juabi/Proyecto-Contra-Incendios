using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Edificio
    {
        public static void MenuCompleto()
        {
            //Menu Edificio compoleto
            int op;
            while (true)
                do
                {
                    Console.Clear();
                    ENERGIA.ResBat();
                    Completo();
                    Console.WriteLine("=======================================================================================================================");
                    Console.WriteLine("                                 |                                                                                     ");
                    Console.WriteLine("---------------------------------|                                                                                     ");

                    Console.SetCursorPosition(0, 5);

                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("        Monitoreo de Pisos        ");
                    Console.WriteLine("----------------------------------");
                    Beeps.Beep1();
                    Console.WriteLine("[1]Piso 1");
                    Beeps.Beep1();
                    Console.WriteLine("[2]Piso 2");
                    Beeps.Beep1();
                    Console.WriteLine("[3]Piso 3");
                    Beeps.Beep1();
                    Console.WriteLine("[0]Atras");

                    TextUtilities.EscribirLento("Seleccione una opción: ", 50);
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1: Piso_1.PlantaPiso1(); break;
                        case 2: Piso_2.PlantaPiso2(); break;
                        case 3: Piso_3.PlantaPiso3(); break;
                        case 0: TextUtilities.EscribirLento("Volviendo...", 50); Menu.EjecutarMenu(); break;
                        default: Console.WriteLine("\n¡Opción inválida! Intente de nuevo.\n"); Thread.Sleep(1000); Console.Clear(); break;
                    }

                } while (op != 0);

        }
        public static void Completo()
        {
            Beeps.Beep1();

            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("Edificio                         |                                                                                     ");
            Console.WriteLine("---------------------------------|                                                                                     ");
            Console.WriteLine("                                            _______________________________________________________________");
            Console.WriteLine("                                           /                                                              /|");
            Console.WriteLine("                                          /                                                              / |");
            Console.WriteLine("                                         /                    _______________________                   /  |");
            Console.WriteLine("                                        /                   /|                      /                  /   |");
            Console.WriteLine("                                       /                   / |                     /                  /    |");
            Console.WriteLine("                                      /                   /  |                    /                  /     |");
            Console.WriteLine("                                     /___________________/   |                   /__________________/     /|");
            Console.WriteLine("                                     |                  |    |                  |                  |     / |");
            Console.WriteLine("                                     |                  |    |__________________|                  |    /  |");
            Console.WriteLine("                                     |       G301       |   /|                  |       G302       |   /   |");
            Console.WriteLine("                                     |                  |  / |                  |                  |  /    |");
            Console.WriteLine("                                     |                  | /  |       G202       |                  | /     |");
            Console.WriteLine("                                     |__________________|/   |                  |__________________|/     /|");
            Console.WriteLine("                                     |                  |    |                  |                  |     / |");
            Console.WriteLine("                                     |                  |    |__________________|                  |    /  |");
            Console.WriteLine("                                     |       G201       |   /|                  |       G203       |   /   |");
            Console.WriteLine("                                     |                  |  / |                  |                  |  /    |");
            Console.WriteLine("                                     |                  | /  |       G102       |                  | /     |");
            Console.WriteLine("                                     |__________________|/   |                  |__________________|/     /");
            Console.WriteLine("                                     |                  |    |                  |                  |     /");
            Console.WriteLine("                                     |                  |    |__________________|                  |    /");
            Console.WriteLine("                                     |       G101       |   /                   |       G101       |   /");
            Console.WriteLine("                                     |  __              |  /                    |              __  |  /");
            Console.WriteLine("                                     | |SE|             | /                     |             |SE| | /");
            Console.WriteLine("                                     |_|__|_____________|/                      |_____________|__|_|/");


        }
    }
}
