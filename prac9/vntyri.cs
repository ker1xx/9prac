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
        public static int stope = 0;
        public static void enter()
        {
            int pos4kill = taskamanager.pos4kill;
            Console.SetCursorPosition(2, 2);
            stope = 1;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            try
            {
                Console.WriteLine(taskamanager.procList[taskamanager.pos - 3].ProcessName);
                Console.WriteLine("_____________________________________________________________________");
                var a = (taskamanager.procList[taskamanager.pos - 3].UserProcessorTime);
                var b = (taskamanager.procList[taskamanager.pos - 3].WorkingSet64);
                var c = (taskamanager.procList[taskamanager.pos - 3].BasePriority);
                var d = (taskamanager.procList[taskamanager.pos - 3].PrivilegedProcessorTime);
                var e = (taskamanager.procList[taskamanager.pos - 3].PagedMemorySize64 / 1024 / 1024);
                var f = (taskamanager.procList[taskamanager.pos - 3].PagedSystemMemorySize64);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка доступа");
                Console.WriteLine(ex.Message);
                Console.WriteLine("_____________________________________________________________________");
                Console.WriteLine("BackSpace - вернуться в меню\nD - завершить данный процесс\nDelete - заверишть все процессы с этим именем");
                arrows.key = Console.ReadKey();
            }
            finally
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(taskamanager.procList[taskamanager.pos - 3].ProcessName);
                Console.WriteLine("_____________________________________________________________________");
            }
            if (arrows.key.Key == ConsoleKey.Backspace)
            {
                Console.Clear();
                return;
            }
            else if (taskamanager.pos == (int)hihi.d)
            {
                taskamanager.procList[taskamanager.pos4kill].Kill();
                Console.Clear();
                return;
            }
            else if (taskamanager.pos == (int)hihi.delete)
            {
                string nameproc = taskamanager.procList[pos4kill].ProcessName;
                foreach (var proc in taskamanager.procList)
                {
                    if (proc.Equals(nameproc))
                        proc.Kill();
                }
                Console.Clear();
                return;
            }
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("  Время с запуска приложения: " + taskamanager.procList[taskamanager.pos - 3].UserProcessorTime);
            Console.WriteLine("  Объем выделенной физической памяти: " + taskamanager.procList[taskamanager.pos - 3].WorkingSet64 / 1024 / 1024 + " МБ");
            Console.WriteLine("  Приоритет процесса: " + taskamanager.procList[taskamanager.pos - 3].BasePriority);
            Console.WriteLine("  Время работы процесса в системе: " + taskamanager.procList[taskamanager.pos - 3].PrivilegedProcessorTime);
            Console.WriteLine("  Объем занятой виртуальной памяти: " + taskamanager.procList[taskamanager.pos - 3].PagedMemorySize64 / 1024 / 1024 + " МБ");
            Console.WriteLine("  Объем занятой системной памяти: " + taskamanager.procList[taskamanager.pos - 3].PagedSystemMemorySize64 / 1024 / 1024 + " МБ");
            Console.WriteLine("_____________________________________________________________________");
            Console.WriteLine("BackSpace - вернуться в меню\nD - завершить данный процесс\nDelete - заверишть все процессы с этим именем");
            taskamanager.pos = 2;
            Console.SetCursorPosition(taskamanager.pos, 2);
            while (arrows.key.Key != ConsoleKey.O)
            {
                if (arrows.key.Key == ConsoleKey.UpArrow)
                    arrows.goup();
                else if (arrows.key.Key == ConsoleKey.DownArrow)
                    arrows.godown();
                Console.SetCursorPosition(0, taskamanager.pos);
                /*                if ()*/
                Console.WriteLine("->"); /* ЕСЛИ ОШИБКИ НЕТ ТО НУЖНО ЧТОТО ВЕРНУТЬ */
                arrows.key = Console.ReadKey();
                if (arrows.key.Key == ConsoleKey.D)
                    taskamanager.pos = (int)hihi.d;
                if (arrows.key.Key == ConsoleKey.Delete)
                    taskamanager.pos = (int)hihi.delete;
                if (arrows.key.Key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    return;
                }
                else if (taskamanager.pos == (int)hihi.d)
                {
                    taskamanager.procList[taskamanager.pos4kill].Kill();
                    Console.Clear();
                    return;
                }
                else if (taskamanager.pos == (int)hihi.delete)
                {
                    string nameproc = taskamanager.procList[pos4kill].ProcessName;
                    foreach (var proc in taskamanager.procList)
                    {
                        if (proc.Equals(nameproc))
                            proc.Kill();
                    }
                    Console.Clear();
                    return;
                }
            }
        }
    }
}
