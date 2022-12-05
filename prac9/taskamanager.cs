using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac9
{
    internal class taskamanager
    {
        public static int pos = 3;
        public static Process[] procList = Process.GetProcesses();
        public static int maxlen_name = 0;
        public static int notmaxlen_name = 0;
        public static int maxlen_size = 0;
        public static int notmaxlen_size = 0;
        public static int pos4kill = 0;
        [Obsolete]
        public static void manager()
        {
            while (arrows.key.Key != ConsoleKey.Escape)
            {
                var processes = procList.OrderBy(proc => proc.ProcessName);
                Console.WriteLine("D1$p3t43R ZADA4))))))))))))\n______________________________________________________________");
                foreach (var proc in processes)
                {
                    notmaxlen_name = proc.ProcessName.ToString().Length;
                    if (maxlen_name < notmaxlen_name)
                        maxlen_name = notmaxlen_name;
                    notmaxlen_size = proc.PagedMemorySize.ToString().Length;
                    if (maxlen_size < notmaxlen_size)
                        maxlen_size = notmaxlen_size;
                }
                foreach (var proc in processes)
                {
                    Console.SetCursorPosition(2, pos);
                    Console.Write(proc.ProcessName);
                    Console.SetCursorPosition(maxlen_name + 4, pos);
                    double mem = Convert.ToDouble(proc.PagedMemorySize) / 1024 / 1024;
                    mem = Math.Round(mem, 2);
                    Console.Write(mem + " MB");
                    Console.SetCursorPosition(maxlen_name + maxlen_size + 8, pos);
                    Console.Write(proc.BasePriority);
                    pos++;
                }
                moving();
            }
        }
        private static void moving()
        {
            pos = 3;
            Console.SetCursorPosition(0, pos);
            while (arrows.key.Key != ConsoleKey.Enter)
            {
                if (arrows.key.Key == ConsoleKey.UpArrow)
                    arrows.goup();
                else if (arrows.key.Key == ConsoleKey.DownArrow)
                    arrows.godown();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                arrows.key = Console.ReadKey();
            }
            if (arrows.key.Key == ConsoleKey.Enter)
            {
                pos4kill = pos;
                vntyri.enter();
                pos = 3;
            }
        }
    }
}
