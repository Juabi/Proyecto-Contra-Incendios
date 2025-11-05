using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class TextUtilities
    {
        public static void EscribirLento(string texto, int tiempoEsperaMs)
        {
            foreach (char caracter in texto)
            {
                Console.Beep(1000, tiempoEsperaMs);
                Console.Write(caracter);
            }
            Console.WriteLine();

        }
    }
}
