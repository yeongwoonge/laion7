using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("안");
            //Thread.Sleep(1000);
            //Console.Write("녕");
            //Thread.Sleep(1000);
            //Console.Write("하");
            //Thread.Sleep(1000);
            //Console.Write("세");
            //Thread.Sleep(1000);
            //Console.Write("요");
            //Thread.Sleep(1000);
            //Console.WriteLine("안");
            //Thread.Sleep(1000);
            //Console.Clear();
            //Console.WriteLine("안녕");
            //Thread.Sleep(1000);
            //Console.Clear();
            //Console.WriteLine("안녕하");
            //Thread.Sleep(1000);
            //Console.Clear();
            //Console.WriteLine("안녕하세");
            //Thread.Sleep(1000);
            //Console.Clear();
            //Console.WriteLine("안녕하세요");
            //Thread.Sleep(1000);
            //Console.Clear();
            string gameStart = "★★★게임시작★★★";

            for (int i = gameStart.Length / 2; i >= 0 ; i-- )
            {
                Console.WriteLine(gameStart.Substring(i, (gameStart.Length/2 - i)*2));
                Thread.Sleep(1000);
            }



        }
    }
}
