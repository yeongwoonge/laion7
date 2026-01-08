using System;

namespace _2차원for문
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j <= 3; j++)
            //    {
            //        Console.WriteLine($"i:{i} j:{j}");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j-1 < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int y = 0; y < 5; y++)
            //{
            //    for (int x = 0; x < 5; x++)
            //    {
            //        Console.Write($"({x},{y}) ");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (j <= i)
            //        {
            //            Console.Write("*");
            //        }

            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (j >= i)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }

            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 3; i++){
            //    for(int j = 1; j <= 3; j++)
            //    {
            //        Console.Write($"{i}*{j}={i*j} ");
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (i * j == 1)
                    {
                        Console.Write("※ ");
                    }
                    else if (i * j == 16)
                    {
                        Console.Write("◎ ");
                    }
                    else
                    {
                        Console.Write("■ ");
                    }
                }
                Console.WriteLine();

            }
        }
    }
}
