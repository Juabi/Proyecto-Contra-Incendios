using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AlarmaPiso2
    {
        public static void CALORG201()
        {
            WaveOut emuladorReproductor = new WaveOut();
            AudioFileReader ubicacionAudio = new AudioFileReader("calor201.mp3");
            emuladorReproductor.Init(ubicacionAudio);
            emuladorReproductor.Play();
        }
        public static void HUMOG201()
        {
            WaveOut emuladorReproductor = new WaveOut();
            AudioFileReader ubicacionAudio = new AudioFileReader("humo201.mp3");
            emuladorReproductor.Init(ubicacionAudio);
            emuladorReproductor.Play();
        }

        public static void CALORG202()
        {
            WaveOut emuladorReproductor = new WaveOut();
            AudioFileReader ubicacionAudio = new AudioFileReader("calor202.mp3");
            emuladorReproductor.Init(ubicacionAudio);
            emuladorReproductor.Play();
        }
        public static void HUMOG202()
        {
            WaveOut emuladorReproductor = new WaveOut();
            AudioFileReader ubicacionAudio = new AudioFileReader("humo202.mp3");
            emuladorReproductor.Init(ubicacionAudio);
            emuladorReproductor.Play();
        }
        public static void CALORG203()
        {
            WaveOut emuladorReproductor = new WaveOut();
            AudioFileReader ubicacionAudio = new AudioFileReader("calor203.mp3");
            emuladorReproductor.Init(ubicacionAudio);
            emuladorReproductor.Play();
        }
        public static void HUMOG203()
        {
            WaveOut emuladorReproductor = new WaveOut();
            AudioFileReader ubicacionAudio = new AudioFileReader("humo203.mp3");
            emuladorReproductor.Init(ubicacionAudio);
            emuladorReproductor.Play();
        }
        public static void AlarmaCalor201()
        {

            Estetica.ContunuacionPiso2();
            Estetica.MapaP2();

            Console.SetCursorPosition(0, 5);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("           Emergencia             ");
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se detecto Sobrecalentamiento en");
            Console.WriteLine("G201");
            Console.WriteLine("Parada de Emergencia...");
            Console.WriteLine("");
            AlarmaPiso3.Timbre();
            Console.WriteLine("LLamando a bomberos...");
            Console.ResetColor();
            int t = 0;
            while (t != 2)
            {
                t++;
                AlarmaPiso2.CALORG201();
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
        public static void AlarmaCalor202()
        {

            Estetica.ContunuacionPiso2();
            Estetica.MapaP2();

            Console.SetCursorPosition(0, 5);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("           Emergencia             ");
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se detecto Sobrecalentamiento en");
            Console.WriteLine("G202");
            Console.WriteLine("Parada de Emergencia...");
            Console.WriteLine("");
            AlarmaPiso3.Timbre();
            Console.WriteLine("LLamando a bomberos...");
            Console.ResetColor();
            int t = 0;
            while (t != 2)
            {
                t++;
                AlarmaPiso2.CALORG202();
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
        public static void AlarmaCalor203()
        {

            Estetica.ContunuacionPiso2();
            Estetica.MapaP2();

            Console.SetCursorPosition(0, 5);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("           Emergencia             ");
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se detecto Sobrecalentamiento en");
            Console.WriteLine("G203");
            Console.WriteLine("Parada de Emergencia...");
            Console.WriteLine("");
            AlarmaPiso3.Timbre();
            Console.WriteLine("LLamando a bomberos...");
            Console.ResetColor();
            int t = 0;
            while (t != 2)
            {
                t++;
                AlarmaPiso2.CALORG203();
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
        public static void AlarmaHumo201()
        {

            Estetica.ContunuacionPiso2();
            Estetica.MapaP2();

            Console.SetCursorPosition(0, 5);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("           Emergencia             ");
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se detecto exceso de humo en");
            Console.WriteLine("G201");
            Console.WriteLine("Parada de Emergencia...");
            Console.WriteLine("");
            AlarmaPiso3.Timbre();
            Console.WriteLine("LLamando a bomberos...");
            Console.ResetColor();
            int t = 0;
            while (t != 2)
            {
                t++;
                AlarmaPiso2.HUMOG201();
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
        public static void AlarmaHumo202()
        {

            Estetica.ContunuacionPiso2();
            Estetica.MapaP2();

            Console.SetCursorPosition(0, 5);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("           Emergencia             ");
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se detecto exceso de humo en");
            Console.WriteLine("G202");
            Console.WriteLine("Parada de Emergencia...");
            Console.WriteLine("");
            AlarmaPiso3.Timbre();
            Console.WriteLine("LLamando a bomberos...");
            Console.ResetColor();
            int t = 0;
            while (t != 2)
            {
                t++;
                AlarmaPiso2.HUMOG202();
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
        public static void AlarmaHumo203()
        {

            Estetica.ContunuacionPiso2();
            Estetica.MapaP2();

            Console.SetCursorPosition(0, 5);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("           Emergencia             ");
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se detecto exceso de humo en");
            Console.WriteLine("G203");
            Console.WriteLine("Parada de Emergencia...");
            Console.WriteLine("");
            AlarmaPiso3.Timbre();
            Console.WriteLine("LLamando a bomberos...");
            Console.ResetColor();
            int t = 0;
            while (t != 2)
            {
                t++;
                AlarmaPiso2.HUMOG203();
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
