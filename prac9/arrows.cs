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
            Console.SetCursorPosition(0,taskamanager.pos);
            Console.Write("  ");
            taskamanager.pos++;
            if (vntyri.stope == 0)
            {
                if (taskamanager.pos > taskamanager.procList.Count() + 2)
                    taskamanager.pos = taskamanager.procList.Count() + 2;
            }
            else
            {
                if (taskamanager.pos > 7)
                    taskamanager.pos = 7;
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
            else
            {
                if (taskamanager.pos == 1)
                    taskamanager.pos = 2;
            }
        }
    }
}
