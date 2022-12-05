using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac9
{
    internal class arrows
    {
        public static ConsoleKeyInfo key;
        public static void godown()
        {
            Console.SetCursorPosition(0, taskamanager.pos);
            Console.Write("  ");
            taskamanager.pos++;
            if (vntyri.stope == 0)
            {
                if (taskamanager.pos > taskamanager.procList.Count() + 2)
                    taskamanager.pos = 2;
            }
            else if (vntyri.stope == 1)
            {
                if (taskamanager.pos > 7)
                    taskamanager.pos = 7;
                check();
            }
        }
        public static void goup()
        {
            Console.SetCursorPosition(0, taskamanager.pos);
            Console.Write("  ");
            taskamanager.pos--;
            if (vntyri.stope == 0)
            {
                if (taskamanager.pos == 2)
                    taskamanager.pos = 3;
            }
            else if (vntyri.stope == 1)
            {
                if (taskamanager.pos == 1)
                    taskamanager.pos = 2;
                check();
            }
            
        }
        private static void check()
        {
            if (key.Key == ConsoleKey.Delete)
                taskamanager.pos = (int)hihi.delete;
            else if (key.Key == ConsoleKey.Backspace)
                taskamanager.pos = (int)hihi.backspace;
            else if (key.Key == ConsoleKey.D)
                taskamanager.pos = (int)hihi.d;
        }
    }
}
