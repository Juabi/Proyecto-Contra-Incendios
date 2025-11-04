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
        public static void Bateria ()
        {
            int op = 0;
            Console.Clear();
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("    Activar Energia de Respaldo   ");
            Console.WriteLine("----------------------------------");
            Beeps.Beep1();
            Console.WriteLine("[1] Activar");
            Beeps.Beep1();
            Console.WriteLine("[0] Volver");

            TextUtilities.EscribirLento("Seleccione una opción: ", 50);
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: TextUtilities.EscribirLento("Energia de respaldo activado...", 50); break;
                case 0: TextUtilities.EscribirLento("Volviendo...", 50); break;
                default: Console.WriteLine("\n¡Opción inválida! Intente de nuevo.\n"); Thread.Sleep(1000); break;
            }
        }
        public static void EjecutarMenu()
        {
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("----------------------------------");
                Console.WriteLine("             Menú SCI             ");
                Console.WriteLine("----------------------------------");
                Beeps.Beep1();
                Console.WriteLine("[1] Monitoreo Del Edificio");
                Beeps.Beep1();
                Console.WriteLine("[2] Monitoreo Piso Individual");
                Beeps.Beep1();
                Console.WriteLine("[3] Energía De Respaldo");
                Beeps.Beep1();
                Console.WriteLine("[0] Salir");
                Beeps.Beep1();
                TextUtilities.EscribirLento("Seleccione una opción: ", 50);
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1: MenuCompleto();break;
                    case 2: MonitoreoPisoIndividual(); break;
                    case 3: Bateria(); break;
                    case 0: TextUtilities.EscribirLento("Hasta Luego...", 50); Environment.Exit(op); break;
                    default: Console.WriteLine("\n¡Opción inválida! Intente de nuevo.\n"); Thread.Sleep(1000); break;
                }
                // Console.ReadKey(); // Descomentar para esperar un 'Enter'
                // Console.Clear();   // Descomentar para limpiar la pantalla después de cada selección
            } while (op != 0);
        }
        public static void MonitoreoPisoIndividual()
        {
            int op;
            do
            {
                Console.Clear();
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
                    case 1: MenuPiso1(); break;
                    case 2: MenuPiso2(); break;
                    case 3: MenuPiso3(); break;
                    case 0: TextUtilities.EscribirLento("Volviendo...", 50); break;
                    default: Console.WriteLine("\n¡Opción inválida! Intente de nuevo.\n"); Thread.Sleep(1000); Console.Clear(); break;
                }

            } while (op != 0);
        }
        public static void MenuCompleto()
        {
            int op;
            do
            {
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
                    case 1: MenuPiso1(); break;
                    case 2: MenuPiso2(); break;
                    case 3: MenuPiso3(); break;
                    case 0: TextUtilities.EscribirLento("Volviendo...", 50); EjecutarMenu(); break;
                    default: Console.WriteLine("\n¡Opción inválida! Intente de nuevo.\n"); Thread.Sleep(1000); Console.Clear(); break;
                }

            } while (op != 0);

        }
        public static void MenuPiso1()
        {
            int op;
            do
            {

                Edificio.Piso1();
                Console.SetCursorPosition(0, 5);
                
                Console.WriteLine("----------------------------------");
                Console.WriteLine("        Monitoreo de Pisos        ");
                Console.WriteLine("----------------------------------");
                Beeps.Beep1();
                Console.WriteLine("[1]Edificio Completo");
                Beeps.Beep1();
                Console.WriteLine("[2]Piso 2");
                Beeps.Beep1();
                Console.WriteLine("[3]Piso 3");
                Beeps.Beep1();
                Console.WriteLine("[0]Menú Principal ");

                TextUtilities.EscribirLento("Seleccione una opción: ", 50);
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1: MenuCompleto(); break;
                    case 2: MenuPiso2(); break;
                    case 3: MenuPiso3(); break;
                    case 0: TextUtilities.EscribirLento("Volviendo...", 50); EjecutarMenu(); break;
                    default: Console.WriteLine("\n¡Opción inválida! Intente de nuevo.\n"); Thread.Sleep(1000); Console.Clear(); break;
                }

            } while (op != 0);
        }
        public static void MenuPiso2()
        {
            int op;
            do
            {

                Edificio.Piso2();
                Console.SetCursorPosition(0, 5);
                
                Console.WriteLine("----------------------------------");
                Console.WriteLine("        Monitoreo de Pisos        ");
                Console.WriteLine("----------------------------------");
                Beeps.Beep1();
                Console.WriteLine("[1]Edificio Completo");
                Beeps.Beep1();
                Console.WriteLine("[2]Piso 1");
                Beeps.Beep1();
                Console.WriteLine("[3]Piso 3");
                Beeps.Beep1();
                Console.WriteLine("[0]Menú Principal ");

                TextUtilities.EscribirLento("Seleccione una opción: ", 50);
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1: MenuCompleto(); break;
                    case 2: MenuPiso1(); break;
                    case 3: MenuPiso3(); break;
                    case 0: TextUtilities.EscribirLento("Volviendo...", 50); EjecutarMenu(); break;
                    default: Console.WriteLine("\n¡Opción inválida! Intente de nuevo.\n"); Thread.Sleep(1000); Console.Clear(); break;
                }

            } while (op != 0);
        }
        public static void MenuPiso3()
        {
            int op;
            do
            {

                Edificio.Piso3();
                Console.SetCursorPosition(0, 5);
                
                Console.WriteLine("----------------------------------");
                Console.WriteLine("        Monitoreo de Pisos        ");
                Console.WriteLine("----------------------------------");
                Beeps.Beep1();
                Console.WriteLine("[1]Edificio Completo");
                Beeps.Beep1();
                Console.WriteLine("[2]Piso 1");
                Beeps.Beep1();
                Console.WriteLine("[3]Piso 2");
                Beeps.Beep1();
                Console.WriteLine("[0]Menú Principal ");

                TextUtilities.EscribirLento("Seleccione una opción: ", 50);
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1: MenuCompleto(); break;
                    case 2: MenuPiso1(); break;
                    case 3: MenuPiso2(); break;
                    case 0: TextUtilities.EscribirLento("Volviendo...", 50); EjecutarMenu(); break;
                    default: Console.WriteLine("\n¡Opción inválida! Intente de nuevo.\n"); Thread.Sleep(1000); Console.Clear(); break;
                }

            } while (op != 0);
        }
    }
}
