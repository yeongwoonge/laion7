using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhythm
{

    internal class Program
    {
        static Dictionary<ConsoleKey, (int x, int y)> keyDict = new Dictionary<ConsoleKey, (int x, int y)>()
        {
            { ConsoleKey.A, (35, 30) }, 
            { ConsoleKey.S, (45, 30) }, 
            { ConsoleKey.K, (55, 30) },
            { ConsoleKey.L, (65, 30) }
        };
        public static void Highlight(ConsoleKey a)
        {
            (int x, int y) = keyDict[a];
            Console.SetCursorPosition(x - 2, y - 1);
            Console.WriteLine("┌");
            Console.SetCursorPosition(x , y - 1);
            Console.WriteLine("─");
            Console.SetCursorPosition(x + 2, y - 1);
            Console.WriteLine("┐");
            Console.SetCursorPosition(x - 2, y );
            Console.WriteLine("│");
            Console.SetCursorPosition(x + 2, y );
            Console.WriteLine("│");
            Console.SetCursorPosition(x - 2, y + 1);
            Console.WriteLine("└");
            Console.SetCursorPosition(x , y + 1);
            Console.WriteLine("─");
            Console.SetCursorPosition(x + 2, y + 1);
            Console.WriteLine("┘");
        }
        public static void HighlightErase(ConsoleKey a)
        {
            {
                (int x, int y) = keyDict[a];
                Console.SetCursorPosition(x - 2, y - 1);
                Console.WriteLine(" ");
                Console.SetCursorPosition(x, y - 1);
                Console.WriteLine(" ");
                Console.SetCursorPosition(x + 2, y - 1);
                Console.WriteLine(" ");
                Console.SetCursorPosition(x - 2, y);
                Console.WriteLine(" ");
                Console.SetCursorPosition(x + 2, y);
                Console.WriteLine(" ");
                Console.SetCursorPosition(x - 2, y + 1);
                Console.WriteLine(" ");
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine(" ");
                Console.SetCursorPosition(x + 2, y + 1);
                Console.WriteLine(" ");
                Console.SetCursorPosition(x, y);
                Console.WriteLine(a);
            }
        }
        public static void Ui()
        {
            foreach (var drawkey in keyDict)
            {
                Console.SetCursorPosition(drawkey.Value.x, drawkey.Value.y);
                Console.WriteLine(drawkey.Key.ToString()); 
            }
        }


        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 40);
            Console.SetBufferSize(100, 40);
            int dwtime = Environment.TickCount;
            Console.CursorVisible = false;
            Ui();
            while (true)
            {
                while (dwtime + 50 > Environment.TickCount) { }
                dwtime = Environment.TickCount;
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo input = Console.ReadKey(true);
                    if(keyDict.ContainsKey(input.Key))
                    {
                        Highlight(input.Key);
                        int ddwtime = Environment.TickCount;
                        while (ddwtime + 250 > Environment.TickCount) { }
                        HighlightErase(input.Key);
                    }
                    
                }
            }
            
            
        }
    }
}
