using NAudio;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AlarmasPiso1
    {
        public static void  CALORG101()
        {
            WaveOut emuladorReproductor = new WaveOut();
            AudioFileReader ubicacionAudio = new AudioFileReader("calor101.mp4");
            emuladorReproductor.Init(ubicacionAudio);
            emuladorReproductor.Play();
        }
        public static void HUMOG101()
        {
            WaveOut emuladorReproductor = new WaveOut();
            AudioFileReader ubicacionAudio = new AudioFileReader("humo101.mp4");
            emuladorReproductor.Init(ubicacionAudio);
            emuladorReproductor.Play();
        }

        public static void CALORG102()
        {
            WaveOut emuladorReproductor = new WaveOut();
            AudioFileReader ubicacionAudio = new AudioFileReader("calor102.mp4");
            emuladorReproductor.Init(ubicacionAudio);
            emuladorReproductor.Play();
        }
        public static void HUMOG102()
        {
            WaveOut emuladorReproductor = new WaveOut();
            AudioFileReader ubicacionAudio = new AudioFileReader("humo102.mp4");
            emuladorReproductor.Init(ubicacionAudio);
            emuladorReproductor.Play();
        }
        public static void CALORG103()
        {
            WaveOut emuladorReproductor = new WaveOut();
            AudioFileReader ubicacionAudio = new AudioFileReader("calor103.mp4");
            emuladorReproductor.Init(ubicacionAudio);
            emuladorReproductor.Play();
        }
        public static void HUMOG103()
        {
            WaveOut emuladorReproductor = new WaveOut();
            AudioFileReader ubicacionAudio = new AudioFileReader("humo103.mp4");
            emuladorReproductor.Init(ubicacionAudio);
            emuladorReproductor.Play();
        }
        public static void AlarmaCalor101()
        {

            Estetica.ContunuacionPiso1();
            Estetica.MapaP1();

            Console.SetCursorPosition(0, 5);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("           Emergencia             ");
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se detecto Sobrecalentamiento en");
            Console.WriteLine("G101");
            Console.WriteLine("Parada de Emergencia...");
            Console.WriteLine("");
            AlarmaPiso3.Timbre();
            Console.WriteLine("LLamando a bomberos...");
            Console.ResetColor();
            int t = 0;
            while (t != 2)
            {
                t++;
                AlarmasPiso1.CALORG101();
                int i = 0;
                while (i != 8)
                {
                    i++;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(38, 4);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(38, 5);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(38, 6);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(38, 7);
                    Console.WriteLine("                    ");
                    Thread.Sleep(500);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(38, 4);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(38, 5);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(38, 6);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(38, 7);
                    Console.WriteLine("                    ");
                    Thread.Sleep(500);
                    Console.ResetColor();
                }

            }
            TextUtilities.EscribirLento("Reiniciando el sistema", 50);
            Thread.Sleep(1000);
            ENERGIA.RestablecerSistemas();
        }
        public static void AlarmaCalor102()
        {

            Estetica.ContunuacionPiso1();
            Estetica.MapaP1();

            Console.SetCursorPosition(0, 5);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("           Emergencia             ");
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se detecto Sobrecalentamiento en");
            Console.WriteLine("G102");
            Console.WriteLine("Parada de Emergencia...");
            Console.WriteLine("");
            AlarmaPiso3.Timbre();
            Console.WriteLine("LLamando a bomberos...");
            Console.ResetColor();
            int t = 0;
            while (t != 2)
            {
                t++;
                AlarmasPiso1.CALORG102();
                int i = 0;
                while (i != 8)
                {
                    i++;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(59, 4);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(59, 5);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(59, 6);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(59, 7);
                    Console.WriteLine("                    ");
                    Thread.Sleep(500);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(59, 4);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(59, 5);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(59, 6);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(59, 7);
                    Console.WriteLine("                    ");
                    Thread.Sleep(500);
                    Console.ResetColor();
                }
            }
            TextUtilities.EscribirLento("Reiniciando el sistema", 50);
            Thread.Sleep(1000);
            ENERGIA.RestablecerSistemas();
        }
        public static void AlarmaCalor103()
        {

            Estetica.ContunuacionPiso1();
            Estetica.MapaP1();

            Console.SetCursorPosition(0, 5);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("           Emergencia             ");
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se detecto Sobrecalentamiento en");
            Console.WriteLine("G103");
            Console.WriteLine("Parada de Emergencia...");
            Console.WriteLine("");
            AlarmaPiso3.Timbre();
            Console.WriteLine("LLamando a bomberos...");
            Console.ResetColor();
            int t = 0;
            while (t != 2)
            {
                t++;
                AlarmasPiso1.CALORG103();
                int i = 0;
                while (i != 8)
                {
                    i++;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(80, 4);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(80, 5);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(80, 6);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(80, 7);
                    Console.WriteLine("                    ");
                    Thread.Sleep(500);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(80, 4);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(80, 5);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(80, 6);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(80, 7);
                    Console.WriteLine("                    ");
                    Thread.Sleep(500);
                    Console.ResetColor();
                }
            }
            TextUtilities.EscribirLento("Reiniciando el sistema", 50);
            Thread.Sleep(1000);
            ENERGIA.RestablecerSistemas();
        }
        public static void AlarmaHumo101()
        {

            Estetica.ContunuacionPiso1();
            Estetica.MapaP1();

            Console.SetCursorPosition(0, 5);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("           Emergencia             ");
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se detecto exceso de humo en");
            Console.WriteLine("G302");
            Console.WriteLine("Parada de Emergencia...");
            Console.WriteLine("");
            AlarmaPiso3.Timbre();
            Console.WriteLine("LLamando a bomberos...");
            Console.ResetColor();
            int t = 0;
            while (t != 2)
            {
                t++;
                AlarmasPiso1.HUMOG101();
                int i = 0;
                while (i != 8)
                {
                    i++;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(38, 4);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(38, 5);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(38, 6);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(38, 7);
                    Console.WriteLine("                    ");
                    Thread.Sleep(500);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(38, 4);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(38, 5);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(38, 6);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(38, 7);
                    Console.WriteLine("                    ");
                    Thread.Sleep(500);
                    Console.ResetColor();
                }
            }
            TextUtilities.EscribirLento("Reiniciando el sistema", 50);
            Thread.Sleep(1000);
            ENERGIA.RestablecerSistemas();
        }
        public static void AlarmaHumo102()
        {

            Estetica.ContunuacionPiso1();
            Estetica.MapaP1();

            Console.SetCursorPosition(0, 5);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("           Emergencia             ");
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se detecto exceso de humo en");
            Console.WriteLine("G102");
            Console.WriteLine("Parada de Emergencia...");
            Console.WriteLine("");
            AlarmaPiso3.Timbre();
            Console.WriteLine("LLamando a bomberos...");
            Console.ResetColor();
            int t = 0;
            while (t != 2)
            {
                t++;
                AlarmasPiso1.HUMOG102();
                int i = 0;
                while (i != 8)
                {
                    i++;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(59, 4);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(59, 5);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(59, 6);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(59, 7);
                    Console.WriteLine("                    ");
                    Thread.Sleep(500);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(59, 4);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(59, 5);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(59, 6);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(59, 7);
                    Console.WriteLine("                    ");
                    Thread.Sleep(500);
                    Console.ResetColor();
                }
            }

            TextUtilities.EscribirLento("Reiniciando el sistema", 50);
            Thread.Sleep(1000);
            ENERGIA.RestablecerSistemas();
        }
        public static void AlarmaHumo103()
        {

            Estetica.ContunuacionPiso1();
            Estetica.MapaP1();

            Console.SetCursorPosition(0, 5);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("           Emergencia             ");
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se detecto exceso de humo en");
            Console.WriteLine("G103");
            Console.WriteLine("Parada de Emergencia...");
            Console.WriteLine("");
            AlarmaPiso3.Timbre();
            Console.WriteLine("LLamando a bomberos...");
            Console.ResetColor();
            int t = 0;
            while (t != 2)
            {
                t++;
                AlarmasPiso1.HUMOG103();
                int i = 0;
                while (i != 8)
                {
                    i++;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(80, 4);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(80, 5);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(80, 6);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(80, 7);
                    Console.WriteLine("                    ");
                    Thread.Sleep(500);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(80, 4);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(80, 5);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(80, 6);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(80, 7);
                    Console.WriteLine("                    ");
                    Thread.Sleep(500);
                    Console.ResetColor();
                }
            }

            TextUtilities.EscribirLento("Reiniciando el sistema", 50);
            Thread.Sleep(1000);
            ENERGIA.RestablecerSistemas();
        }
    }
}
