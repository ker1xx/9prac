using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac9
{
    internal class vntyri
    {
        public static int stope =0;
        public static void enter()
        {
            stope = 1;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(taskamanager.procList[taskamanager.pos-3].ProcessName);
            Console.WriteLine("_____________________________________________________________________");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("  Объем выделенной физической памяти: " + taskamanager.procList[taskamanager.pos - 3].WorkingSet64 /1024/1024 + " МБ");
            Console.WriteLine("  Приоритет процесса: " + taskamanager.procList[taskamanager.pos - 3].BasePriority);
            Console.WriteLine("  Время с запуска процесса: " + taskamanager.procList[taskamanager.pos - 3].UserProcessorTime);
            Console.WriteLine("  Время работы процесса в системе: " + taskamanager.procList[taskamanager.pos - 3].PrivilegedProcessorTime);
            Console.WriteLine("  Объем занятой виртуальной памяти: " + taskamanager.procList[taskamanager.pos - 3].PagedMemorySize64/1024/1024 + " МБ");
            Console.WriteLine("  Объем занятой системной памяти: " + taskamanager.procList[taskamanager.pos - 3].PagedSystemMemorySize64/1024/1024 + " МБ");
            taskamanager.procList[taskamanager.pos-3].
            taskamanager.pos -= 2;
            Console.SetCursorPosition(0, taskamanager.pos);
            while (arrows.key.Key != ConsoleKey.Backspace)
            {
                if (arrows.key.Key == ConsoleKey.UpArrow)
                    arrows.goup();
                else if (arrows.key.Key == ConsoleKey.DownArrow)
                    arrows.godown();
                Console.SetCursorPosition(0, taskamanager.pos);
                Console.WriteLine("->");
                arrows.key = Console.ReadKey();
            }
        }
    }
}
