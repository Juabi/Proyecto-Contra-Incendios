using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;

namespace Biblioteca
{
    public class ENERGIA
    {
        public static int bat = 100;
        public static int bat2 = 100;
        public static int estado = 0;
        public static void Confirmadora()
        {
            if (bat == 0 && bat2 == 0)
            {
                Error0energia();
            }
            if (estado==0)
            {
                if (bat > 0)
                {
                    MenuBateria1();
                }
                else
                {
                    ErrorBateria();
                }
            }
            else if (estado >0)
            {
                if (bat2 > 0)
                {
                    MenuBateria2();
                }
                else
                {
                    ErrorBateria2();
                }
            }
            
        }
        public static void ResBat()
        {
            if (estado == 0)
            {
                if (bat > 0)
                {
                    bat -= 25;
                }
                else if (bat == 0)
                {
                    if (bat2 == 0)
                    {
                        Error0energia();
                    }
                    ErrorBateria();
                }
            }
            else if (estado > 0)
            {
                if (bat2 > 0)
                {
                    bat2 -= 25;
                }
                else if (bat2 == 0)
                {
                    if (bat == 0)
                    {
                        Error0energia();
                    }
                    ErrorBateria2();
                }
            }

        }
        public static void MenuBateria1()
        {

            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("=======================================================================================================================");
                Console.WriteLine("Menú                             |                                                                                     ");
                Console.WriteLine("---------------------------------|                                                                                     ");
    
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("----------------------------------");
                Console.WriteLine("            Menú Energía          ");
                Console.WriteLine("----------------------------------");
                Beeps.Beep1();
                Console.WriteLine($"Energía actual: {bat}%");
                Console.WriteLine("");
                Beeps.Beep1();
                Console.WriteLine("[1] Activar Energía de Respaldo");
                Beeps.Beep1();
                Console.WriteLine("[0] Volver");

                TextUtilities.EscribirLento("Seleccione una opción: ", 50);
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1: Thread.Sleep(500); ActivarRespaldo();  break;
                    case 0: TextUtilities.EscribirLento("Volviendo...", 50); Menu.EjecutarMenu(); break;
                    default: Console.WriteLine("\n¡Opción inválida! Intente de nuevo.\n"); Thread.Sleep(1000); break;
                }
            } while (op != 0);
            
        }
        public static void MenuBateria2()
        {

            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("=======================================================================================================================");
                Console.WriteLine("Menú                             |                                                                                     ");
                Console.WriteLine("---------------------------------|                                                                                     ");
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("----------------------------------");
                Console.WriteLine("     Menú Energía de Respaldo     ");
                Console.WriteLine("----------------------------------");
                Beeps.Beep1();
                Console.WriteLine($"Energía actual: {bat2}%");
                Console.WriteLine("");
                Beeps.Beep1();
                Console.WriteLine("[1] Activar Energía Local");
                Beeps.Beep1();
                Console.WriteLine("[0] Volver");

                TextUtilities.EscribirLento("Seleccione una opción: ", 50);
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1: ActivarLocal(); break;
                    case 0: TextUtilities.EscribirLento("Volviendo...", 50); Menu.EjecutarMenu(); break;
                    default: Console.WriteLine("\n¡Opción inválida! Intente de nuevo.\n"); Thread.Sleep(1000); break;
                }
            } while (op != 0);
            
        }
        
        public static void ActivarRespaldo()
        {
            int op = 0;
            do
            {
                Console.Clear();

                Console.WriteLine("=======================================================================================================================");
                Console.WriteLine("Energía de Respaldo              |                                                                                     ");
                Console.WriteLine("---------------------------------|                                                                                     ");
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("----------------------------------");
                Console.WriteLine("    Activar Energía de Respaldo   ");
                Console.WriteLine("----------------------------------");
                Beeps.Beep1();
                Console.WriteLine("[1] Activar");
                Beeps.Beep1();
                Console.WriteLine("[0] Volver");

                TextUtilities.EscribirLento("Seleccione una opción: ", 50);
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        if (estado == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("=======================================================================================================================");
                            Console.WriteLine("                                 |                                                                                     ");
                            Console.WriteLine("---------------------------------|                                                                                     ");
                            Estetica.Gris();
                            FueraLuces();
                            Thread.Sleep(2000);
                        }

                        HolaLuces(); TextUtilities.EscribirLento("Energía de respaldo activado.", 50); estado++; Confirmadora(); break;
                    case 0: TextUtilities.EscribirLento("Volviendo...", 50); Menu.EjecutarMenu(); break;
                    default: Console.WriteLine("\n¡Opción inválida! Intente de nuevo.\n"); Thread.Sleep(1000); break;
                }
            } while (op != 0);
            
        }
        public static void ActivarLocal()
        {
            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("=======================================================================================================================");
                Console.WriteLine("Energía Local                    |                                                                                     ");
                Console.WriteLine("---------------------------------|                                                                                     ");
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("----------------------------------");
                Console.WriteLine("      Activar Energía Local       ");
                Console.WriteLine("----------------------------------");
                Beeps.Beep1();
                Console.WriteLine("[1] Activar");
                Beeps.Beep1();
                Console.WriteLine("[0] Volver");

                TextUtilities.EscribirLento("Seleccione una opción: ", 50);
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        if (estado > 0)
                        {

                            Console.Clear();
                            Console.WriteLine("=======================================================================================================================");
                            Console.WriteLine("                                 |                                                                                     ");
                            Console.WriteLine("---------------------------------|                                                                                     ");
                            Estetica.Gris();
                            FueraLuces();
                            Thread.Sleep(2000);
                        }
                        HolaLuces(); TextUtilities.EscribirLento("Energía Local activado...", 50); estado--; Confirmadora(); break;
                    case 0: TextUtilities.EscribirLento("Volviendo...", 50); Menu.EjecutarMenu(); break;
                    default: Console.WriteLine("\n¡Opción inválida! Intente de nuevo.\n"); Thread.Sleep(1000); break;
                }
            } while (op != 0);
            
        }
        public static void ErrorBateria()
        {

            Console.Clear();
            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("Error                            |                                                                                     ");
            Console.WriteLine("---------------------------------|                                                                                     ");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("        Error en el sistema       ");
            Console.WriteLine("----------------------------------");
            Beeps.Beep1();
            TextUtilities.EscribirLento("Energía insuficiente", 50);
            Beeps.Beep1();
            TextUtilities.EscribirLento("Redirigiendo a Energía de Respaldo", 50);
            Beeps.Beep1();
            Thread.Sleep(1000);
            ActivarRespaldo();
        }
        public static void ErrorBateria2()
        {
            Console.Clear();
            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("Error                            |                                                                                     ");
            Console.WriteLine("---------------------------------|                                                                                     ");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("        Error en el sistema       ");
            Console.WriteLine("----------------------------------");
            Beeps.Beep1();
            TextUtilities.EscribirLento("Energía insuficiente", 50);
            Beeps.Beep1();
            TextUtilities.EscribirLento("Redirigiendo a Energía Local", 50);
            Beeps.Beep1();
            Thread.Sleep(1000);
            ActivarLocal();
        }
        public static void Error0energia()
        {
            FueraLuces();
            Console.Clear();
            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("Error                            |                                                                                     ");
            Console.WriteLine("---------------------------------|                                                                                     ");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("        Error en el sistema       ");
            Console.WriteLine("----------------------------------");
            Beeps.Beep1();
            TextUtilities.EscribirLento("Energía insuficiente en ambos", 50);
            TextUtilities.EscribirLento("centros de Energía", 50);
            Beeps.Beep1();
            Console.SetCursorPosition(0, 1);
            TextUtilities.EscribirLento("Cerrando sistema...", 50);
            Console.SetCursorPosition(0, 13);
            Environment.Exit(estado);
            
            Thread.Sleep(1000);
            
        }
        public static void FueraLuces()
        {

            WaveOut emuladorReproductor = new WaveOut();

            AudioFileReader ubicacionAudio = new AudioFileReader("FueraLuces.mp3");

            emuladorReproductor.Init(ubicacionAudio);

            emuladorReproductor.Play();

        }
        public static void HolaLuces()
        {
            WaveOut emuladorReproductor = new WaveOut();

            AudioFileReader ubicacionAudio = new AudioFileReader("HolaLuces.mov");

            emuladorReproductor.Init(ubicacionAudio);

            emuladorReproductor.Play();
        }
        public static void RestablecerSistemas()
        {
            Console.Clear();
            ENERGIA.FueraLuces();
            Thread.Sleep(1000); 
            HolaLuces(); 
            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("                                 |                                                                                     ");
            Console.WriteLine("---------------------------------|                                                                                     ");
            Estetica.Gris();
            Console.SetCursorPosition(0, 1);
            TextUtilities.EscribirLento("Iniciando aplicación...", 50);
            Console.SetCursorPosition(0, 2);
            TextUtilities.EscribirLento("\t\t\t\t\t\t\t\t\tSistema reiniciado", 50);

            Thread.Sleep(1000);

            Menu.EjecutarMenu();

        }
    }
    
}



