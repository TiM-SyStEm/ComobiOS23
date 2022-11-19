using System;

namespace ComobiOS23.src.System
{
    class IOsteram
    {
        public static void OutLN(string text, ConsoleColor color = ConsoleColor.White)
        {
            if (color != ConsoleColor.White)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(text);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else Console.WriteLine(text);
        }
        public static void Out(string text, ConsoleColor color = ConsoleColor.White)
        {
            if (color != ConsoleColor.White)
            {
                Console.ForegroundColor = color;
                Console.Write(text);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else Console.Write(text);
        }
        public static string In(string text, ConsoleColor color = ConsoleColor.White)
        {
            if (color != ConsoleColor.White)
            {
                Console.ForegroundColor = color;
                Console.Write(text);
                Console.ForegroundColor = ConsoleColor.White;
                return Console.ReadLine();
            }
            Console.Write(text);
            return Console.ReadLine();
        }
        public static void Clear()
        {
            Console.Clear();
        }
        public static void SetBckgColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }
    }
}