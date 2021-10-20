using System;
using System.Threading;

namespace TextUtil
{
    public class Writer
    {
        public int Interval { get; set; }
        public ConsoleColor Color { get; set; }

        public Writer()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Warning: No paramters detected! Behaving like normal WriteLine! Assuming intentional!");
        }

        public Writer(int paramInterval = 0, ConsoleColor paramColor = ConsoleColor.White)
        {
            this.Interval = paramInterval;
            this.Color = paramColor;
        }

        // primary write function
        public void Write(string input)
        {
            foreach (char c in input)
            {
                Console.ForegroundColor = Color;
                Console.Write(c);
                Thread.Sleep(Interval);   
            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White; // double enforcement
        }

        public void WriteNL(string input)
        {
            foreach (char c in input)
            {
                Console.ForegroundColor = Color;
                Console.Write(c);
                Thread.Sleep(Interval);   
            }
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White; // double enforcement
        }
    }

    public static class Writers
    {
        public static Writer Writer = new Writer(100, ConsoleColor.White);
        public static Writer Ok = new Writer(100, ConsoleColor.Green);
        public static Writer Warn = new Writer(100, ConsoleColor.Yellow);
        public static Writer Error = new Writer(100, ConsoleColor.Red);
        public static Writer Sys = new Writer(0, ConsoleColor.Blue); 
    }
}