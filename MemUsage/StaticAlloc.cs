using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemUsage
{
    public class MemType
    {
        private static int[] i = new int[1024 * 1024 * 4];
        
    }
   public class StaticAlloc
    {
        static List<MemType> memTypes = new List<MemType>();
        public static List<MemType> AllocMem()
        {
            
            Console.WriteLine("Press ESC to stop Mem allocation");
            do
            {
                while (!Console.KeyAvailable)
                {
                    MemType memType = new MemType();
                    memTypes.Add(memType);
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            return memTypes;

        }

        public static void AllocMemLocal()
        {
            List<MemType> memTypes = new List<MemType>();
            MemType memType;
            Console.WriteLine("Press ESC to stop Mem allocation");
            do
            {
                while (!Console.KeyAvailable)
                {
                    memType = new MemType();
                    memTypes.Add(memType);
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            //return memTypes;

        }


    }
}
