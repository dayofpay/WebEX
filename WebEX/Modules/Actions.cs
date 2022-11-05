using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebEX.Modules
{
    class Actions
    {
        public static void CreateError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }
        public static void CreateInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
        public static void ClearConsole()
        {
            Console.Clear();
        }
        public static void CreateBlankLines(int count)
        {
            for (int i = 0; i <= count; i++)
            {
                Console.WriteLine("");
            }
        }
    }
}
