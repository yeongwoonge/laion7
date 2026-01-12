using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); //콘솔 창 크기 설정
            Console.SetBufferSize(80, 25); //버퍼 크기도 동일하게 설정 (스크롤 방지)


            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            }; //배열 문자열로 그리기


            int playerX = 0;
            int playerY = 12;


            ConsoleKeyInfo keyInfo;  //키정보

            Console.CursorVisible = false; //콘솔창 커서 안보이게하기

            //Sleep()  //1000 1초동안 프로그램을 잠시멈춤 
            //지연방법 시간을 계산해서 1초 루프
            int dwTime = Environment.TickCount;   // 1/1000 초가 흐릅니다.


            while (true)
            {
                //1초루프
                if (dwTime + 10 < Environment.TickCount)
                {
                    //현재 시간 세팅
                    dwTime = Environment.TickCount;

                    Console.Clear();

                    if (Console.KeyAvailable) //키가 눌렸을때 true
                    {
                        keyInfo = Console.ReadKey(true); //키 입력 받기 

                        switch (keyInfo.Key)
                        {
                            case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
                            case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 1) playerY++; break;
                            case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
                            case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 1) playerX++; break;
                            case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                            case ConsoleKey.Escape: return; //ESC키로 종료 
                        }

                    }


                    for (int i = 0; i < player.Length; i++)
                    {
                        //콘솔좌표 설정 플레이어X 플레이어Y
                        Console.SetCursorPosition(playerX, playerY + i);
                        //문자열배열 출력
                        Console.WriteLine(player[i]);
                    }

                }


            }











        }
    }
}