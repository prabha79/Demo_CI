using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            Loop();
        }

        private static void Loop()
        {
            LoopTillEsc();
            LoopTillQ();
        }

        private static void LoopTillEsc()
        {
            //var mem = StaticAlloc.AllocMem();
            StaticAlloc.AllocMemLocal();
        }

        private static void LoopTillQ()
        {
            Console.WriteLine("Press Q to quit");
            do
            {
                while (!Console.KeyAvailable)
                {
                   int []arr = new int[1024]; // Do something
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Q);
        }
    }
}
