using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AlarmaPiso3
    {
        public static void CALORG301()
        {
            WaveOut emuladorReproductor = new WaveOut();
            AudioFileReader ubicacionAudio = new AudioFileReader(@"Audio\calor301.mp4");
            emuladorReproductor.Init(ubicacionAudio);
            emuladorReproductor.Play();
        }
        public static void HUMOG301()
        {
            WaveOut emuladorReproductor = new WaveOut();
            AudioFileReader ubicacionAudio = new AudioFileReader(@"Audio\humo301.mp4");
            emuladorReproductor.Init(ubicacionAudio);
            emuladorReproductor.Play();
        }

        public static void CALORG302()
        {
            WaveOut emuladorReproductor = new WaveOut();
            AudioFileReader ubicacionAudio = new AudioFileReader(@"Audio\calor302.mp4");
            emuladorReproductor.Init(ubicacionAudio);
            emuladorReproductor.Play();
        }
        public static void HUMOG302()
        {
            WaveOut emuladorReproductor = new WaveOut();
            AudioFileReader ubicacionAudio = new AudioFileReader(@"Audio\humo302.mp4");
            emuladorReproductor.Init(ubicacionAudio);
            emuladorReproductor.Play();
        }
        public static void AlarmaCalor301()
        {

            Estetica.ContunuacionPiso3();
            Estetica.MapaP3();

            Console.SetCursorPosition(0, 5);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("           Emergencia             ");
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se detecto Sobrecalentamiento en");
            Console.WriteLine("G301");
            Console.WriteLine("Parada de Emergencia...");
            Console.WriteLine("");
            Timbre();
            Console.WriteLine("LLamando a bomberos...");
            Console.ResetColor();
            int t = 0;
            while (t != 2)
            {
                t++;
                AlarmaPiso3.CALORG301();
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

        public static void AlarmaCalor302()
        {

            Estetica.ContunuacionPiso3();
            Estetica.MapaP3();

            Console.SetCursorPosition(0, 5);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("           Emergencia             ");
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se detecto Sobrecalentamiento en");
            Console.WriteLine("G302");
            Console.WriteLine("Parada de Emergencia...");
            Console.WriteLine("");
            Timbre();
            Console.WriteLine("LLamando a bomberos...");
            Console.ResetColor();
            int t = 0;
            while (t != 2)
            {
                t++;
                AlarmaPiso3.CALORG302();
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
        public static void AlarmaHumo301()
        {

            Estetica.ContunuacionPiso3();
            Estetica.MapaP3();

            Console.SetCursorPosition(0, 5);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("           Emergencia             ");
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se detecto exceso de humo en");
            Console.WriteLine("G301");
            Console.WriteLine("Parada de Emergencia...");
            Console.WriteLine("");
            Timbre();
            Console.WriteLine("LLamando a bomberos...");
            Console.ResetColor();
            int t = 0;
            while (t != 2)
            {
                t++;
                AlarmaPiso3.HUMOG301();
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

        public static void AlarmaHumo302()
        {

            Estetica.ContunuacionPiso3();
            Estetica.MapaP3();

            Console.SetCursorPosition(0, 5);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("           Emergencia             ");
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se detecto exceso de humo en");
            Console.WriteLine("G302");
            Console.WriteLine("Parada de Emergencia...");
            Console.WriteLine("");
            Timbre();
            Console.WriteLine("LLamando a bomberos...");
            Console.ResetColor();
            int t = 0;
            while (t != 2)
            {
                t++;
                AlarmaPiso3.HUMOG302();
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
        public static void Timbre()
        {
            WaveOut emuladorReproductor = new WaveOut();
            AudioFileReader ubicacionAudio = new AudioFileReader(@"Audio\Timbre.mp3");
            emuladorReproductor.Init(ubicacionAudio);
            emuladorReproductor.Play();
        }

    }
}
