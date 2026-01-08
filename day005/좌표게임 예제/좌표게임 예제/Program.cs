using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 좌표게임_예제
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// d

            Console.OutputEncoding = Encoding.UTF8;
            Random rand = new Random();
            int playerX = 3, playerY = 1;
            int monsterX = 73, monsterY = 23; // 80,25 
            bool monsterMoveWay = false;
            int score = 0;
            while (true)
            {
                int targetX = (rand.Next(3, 36)) * 2 - 1, targetY = rand.Next(2, 22);
                ConsoleKeyInfo keyInfo;
                Console.CursorVisible = false;
                while (true)
                {
                    Console.Clear();
                    Console.SetCursorPosition(playerX, playerY);
                    Console.Write("🐣");
                    //Console.WriteLine(playerX+" "+playerY);
                    Console.SetCursorPosition(targetX, targetY);
                    Console.Write("🎁");
                    Console.SetCursorPosition(monsterX, monsterY);
                    Console.Write("🌚");
                    //Console.WriteLine("");
                    //Console.WriteLine(monsterX + " " + monsterY);
                    Console.SetCursorPosition((Console.WindowWidth) / 5, 0);
                    Console.Write($"score : {score}");

                    //벽그리기
                    //for (int i = 16; i<=64; i += 2)
                    //{
                    //    Console.SetCursorPosition(i, 12);
                    //    Console.Write("■");
                    //}
                    //for (int i = 5; i <= 19; i += 1)
                    //{
                    //    Console.SetCursorPosition(41 , i);
                    //    Console.Write("■");
                    //}

                    //플레이어이동
                    keyInfo = Console.ReadKey(true);
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow: if (playerY > 1) playerY--; break;
                        case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 2) playerY++; break;
                        case ConsoleKey.LeftArrow: if (playerX > 3) playerX -= 2; break;
                        case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 5) playerX += 2; break;
                        default: break;
                    }

                    //벽체크
                    //실패...

                    //몬스터이동
                    if (monsterMoveWay)
                    {
                        if (monsterX - playerX > 0) monsterX -= 2;
                        else if (monsterX - playerX < 0) monsterX += 2;
                        monsterMoveWay = !monsterMoveWay;
                    }
                    else
                    {
                        if (monsterY - playerY > 0) monsterY--;
                        else if (monsterY - playerY < 0) monsterY++;
                        monsterMoveWay = !monsterMoveWay;
                    }

                    //사망
                    if (playerX == monsterX && playerY == monsterY)
                    {
                        string dot = "";
                        for (int i = 0; i < 3; i++)
                        {
                            Console.SetCursorPosition(playerX-1, playerY+1);
                            Console.Write("　");
                            Console.SetCursorPosition(playerX-1, playerY-1);
                            Console.Write("　");
                            Console.SetCursorPosition(playerX + 2, playerY );
                            Console.Write("　");
                            Console.SetCursorPosition(playerX - 2, playerY );
                            Console.Write("　");
                            Console.SetCursorPosition(playerX, playerY);
                            Console.Write("☠️" + dot);
                            dot += ".";
                            Thread.Sleep(300);
                        }
                        while(true)
                        {
                            Console.SetCursorPosition((Console.WindowWidth) /2 ,0);
                            Console.Write("Press R to restart");
                            keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.R)
                            {
                                playerX = 3; playerY = 1;
                                monsterX = 73; monsterY = 24;
                                monsterMoveWay = false;
                                score = 0;
                                break;
                            }
                        }
                        break;
                    }

                    //보물
                    if (playerX == targetX && playerY == targetY)
                    {
                        score=score+1;
                        for (int i = 3; i >= 2; i--)
                        {
                            Console.SetCursorPosition(playerX - 1, playerY + 1);
                            Console.Write("　");
                            Console.SetCursorPosition(playerX - 1, playerY - 1);
                            Console.Write("　");
                            Console.SetCursorPosition(playerX, playerY );
                            Console.Write("🎉");
                            Console.SetCursorPosition(playerX - i + 1, playerY ); // 왼
                            Console.Write(">");
                            //Console.SetCursorPosition(playerX, playerY + 1); // 아래
                            //Console.WriteLine("▲");
                            Console.SetCursorPosition(playerX + i, playerY ); // 오른
                            Console.Write("<");
                            //Console.SetCursorPosition(playerX, playerY - 1); // 위
                            //Console.WriteLine("▼");
                            Thread.Sleep(300);
                        }
                        break;
                    }

                }
                /// d
            }
        }
    }
}
