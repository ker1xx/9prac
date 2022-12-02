using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac9
{
    internal class taskamanager
    {
        public static int pos = 1;
            public static Process[] procList = Process.GetProcesses();
        public static void manager()
        {
            int maxlen_name = 0;
            int notmaxlen_name = 0;
            int yo = 1;
            int maxlen_size = 0;
            int notmaxlen_size = 0;

            foreach (var proc in procList)
            {
                Console.SetCursorPosition(2, yo);
                Console.Write(proc.ProcessName);
                Console.SetCursorPosition(42, yo);
                Console.Write(proc.PrivateMemorySize);
                Console.SetCursorPosition(57, yo);
                Console.Write(proc.BasePriority);
                yo++;
            }
            while (arrows.key.Key != CoonsoleKey.Enter)
            if (arrows.key.Key == ConsoleKey.UpArrow)
                arrows.goup();
            else if (arrows.key.Key == ConsoleKey.DownArrow)
                arrows.godown();
            if (arrows.key.Key != ConsoleKey.Enter)
            Console.WriteLine("->");
            arrows.key = Console.ReadKey();
        }
    }
}
