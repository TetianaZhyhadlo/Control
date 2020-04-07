using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Company
{
    public static class Extension
    {
            public static void ToConsole()
            {
                Console.WriteLine();
                Console.ResetColor();
            }

            public static void ToConsole(object obj, ConsoleColor color = ConsoleColor.White)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(obj);
                Console.ResetColor();
            }
    }
}
