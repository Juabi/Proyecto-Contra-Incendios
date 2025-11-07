using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Menu
    {
        
        public static void EjecutarMenu()
        {
            //Menu principal
            int op;
            do
            {
                //ENERGIA.ResBat();
                //ENERGIA.Massa();
                
                Console.Clear();
                Console.WriteLine("=======================================================================================================================");
                Console.WriteLine("Menú                             |                                                                                     ");
                Console.WriteLine("---------------------------------|                                                                                     ");
                Console.SetCursorPosition(0, 5);

                

                Console.WriteLine("----------------------------------");
                Console.WriteLine("             Menú SCI             ");
                Console.WriteLine("----------------------------------");
                Beeps.Beep1();
                Console.WriteLine("[1] Monitoreo Del Edificio");
                Beeps.Beep1();
                Console.WriteLine("[2] Monitoreo General");
                Beeps.Beep1();
                Console.WriteLine("[3] Estado de Energía");
                Beeps.Beep1();
                Console.WriteLine("[0] Salir");
                Beeps.Beep1();
                TextUtilities.EscribirLento("Seleccione una opción: ", 50);
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1: MenuCompleto();break;
                    case 2: Monitoreo_General.Totalpisos(); break;
                    case 3: ENERGIA.Confirmadora(); break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("=======================================================================================================================");
                        Console.WriteLine("                                 |                                                                                     ");
                        Console.WriteLine("---------------------------------|                                                                                     ");
                        Beeps.Beep1();
                        Estetica.Gris();
                        Console.SetCursorPosition(0, 1);
                        TextUtilities.EscribirLento("Aplicación finalizada.", 50);
                        Console.SetCursorPosition(0, 7);
                        Environment.Exit(op); 
                        break;
                    default: Console.WriteLine("\n¡Opción inválida! Intente de nuevo.\n"); Thread.Sleep(1000); break;
                }
                // Console.ReadKey(); // 
                // Console.Clear();   // 
            } while (op != 0);
        }
        public static void MenuCompleto()
        {
            //Menu Edificio compoleto
            int op;
            while(true)
            do
            {
                Console.Clear();
                Edificio.Completo();
                
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
                    case 0: TextUtilities.EscribirLento("Volviendo...", 50); EjecutarMenu(); break;
                    default: Console.WriteLine("\n¡Opción inválida! Intente de nuevo.\n"); Thread.Sleep(1000); Console.Clear(); break;
                }

            } while (op != 0);

        }
        
    }
}
