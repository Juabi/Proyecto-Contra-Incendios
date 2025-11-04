using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Beeps
    {
        public static void Beep1()
        {
            Thread.Sleep(700);
            Console.Beep(1000, 10);
        }
    }
}
