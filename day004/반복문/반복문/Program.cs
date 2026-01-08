using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace 반복문
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int totalGoblin = 5;
            //for (int i = 1; i <= totalGoblin; i++)
            //{
            //    Console.WriteLine($"고블린 #{i} 생성!");
            //}
            //Console.WriteLine($"총 {totalGoblin}마리 생성 완료");

            //Console.WriteLine("=== 게임 시작 카운트 다운 ===");
            //for (int i = 5; i > 0 ; i-- )
            //{
            //    Console.WriteLine($"{i}...");
            //    Thread.Sleep(1000);
            //}
            //Console.WriteLine("게임 시작~");

            //int i = 0;
            //for (; ;)
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("5번반복");
            //    i++;
            //    if (i == 5) break;
            //}

            string sword = "무한의 대검";

            Console.WriteLine("당신은 20번뽑기가 가능합니다. 지금 실행합니다.");

            Random rand = new Random();

            int random = 0;

            for (int i = 0; i < 20; i++)
            {
                random = rand.Next(1, 101);

                if (random >= 1 && random <= 10)
                {
                    sword = "무한의 대검";
                }
                else if (random >= 11 && random <= 30)
                {
                    sword = "카타나";
                }
                else if (random >= 31 && random <= 60)
                {
                    sword = "엑스칼리버";
                }
                else if (random >= 61 && random <= 100)
                {
                    sword = "정기정검";
                }

                Console.WriteLine(sword);
                Thread.Sleep(500);
            }

        }
    }
}
