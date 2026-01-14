using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 슈팅게임
{
    // 1. 총알 클래스
    public class BULLET
    {
        public int x;
        public int y;
        public bool fire;
    }

    // 2. 플레이어 클래스
    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();

        public int playerX;
        public int playerY;

        public BULLET[] playerBullet = new BULLET[20];
        public int Score = 100;

        public Player()
        {
            playerX = 0;
            playerY = 12;
            for (int i = 0; i < 20; i++)
            {
                playerBullet[i] = new BULLET();
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;
            }
        }
        public void GameMain()
        {
            KeyControl();
            PlayerDraw();
            UIscore();
        }
        public void KeyControl()
        {
            int pressKey;
            if (Console.KeyAvailable)
            {
                pressKey = _getch(); // pressKey를 아스키값으로
                // 224번(방향키 신호)이면 한 번 더 읽어오는 코드 추가하면 더 좋음
                if (pressKey == 224)
                {
                    pressKey = _getch();
                }

                switch (pressKey)
                {
                    case 72:
                        playerY--;
                        if (playerY < 1) playerY = 1;
                        break;
                    case 75:
                        playerX--;
                        if (playerX < 0) playerX = 0;
                        break;
                    case 77:
                        playerX++;
                        if (playerX > 75) playerX = 75;
                        break;
                    case 80:
                        playerY++;
                        if (playerY > 21) playerY = 21;
                        break;
                    case 32:
                        for (int i = 0; i < 20; i++)
                        {
                            if (playerBullet[i].fire == false)
                            {
                                playerBullet[i].fire = true;
                                playerBullet[i].x = playerX + 5;
                                playerBullet[i].y = playerY + 1;
                                break;
                            }
                        }
                        break;
                }
            }
        }
        public void BulletDraw()
        {
            string bullet = "->";
            for (int i = 0; i < 20; i++)
            {
                if (playerBullet[i].fire == true)
                {
                    Console.SetCursorPosition(playerBullet[i].x - 1, playerBullet[i].y);
                    Console.WriteLine(bullet);
                    playerBullet[i].x++;
                    if (playerBullet[i].x > 78)
                    {
                        playerBullet[i].fire = false;
                    }
                }
            }
        }
        public void PlayerDraw()
        {
            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            };
            for (int i = 0; i < player.Length; i++)
            {
                Console.SetCursorPosition(playerX, playerY + i);
                Console.WriteLine(player[i]);
            }
        }
        public void UIscore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : " + Score);
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }
        public void CrashEnemyAndBullet(Enemy enemy)
        {
            for (int i = 0; i < 20; i++)
            {
                if (playerBullet[i].fire == true)
                {
                    if (playerBullet[i].y == enemy.enemyY)
                    {
                        if (playerBullet[i].x >= enemy.enemyX - 1 && playerBullet[i].x <= enemy.enemyX + 1)
                        {
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);
                            playerBullet[i].fire = false;
                            Score += 100;
                        }
                    }
                }
            }
        }
    } // Player 클래스 끝

    // 3. 적 클래스
    public class Enemy
    {
        public int enemyX;
        public int enemyY;
        public Enemy()
        {
            enemyX = 77;
            enemyY = 12;
        }
        public void EnemyDraw()
        {
            string enemy = "<-0->";
            Console.SetCursorPosition(enemyX, enemyY);
            Console.WriteLine(enemy);
        }
        public void EnemyMove()
        {
            Random rand = new Random();
            enemyX--;
            if (enemyX < 2)
            {
                enemyX = 75;
                enemyY = rand.Next(2, 22);
            }
        }
    } // Enemy 클래스 끝

    // 4. 메인 프로그램 클래스 (들여쓰기 맞춤)
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            Player player = new Player();
            Enemy enemy = new Enemy();

            int dwtime = Environment.TickCount;

            while (true)
            {
                if (dwtime + 50 < Environment.TickCount)
                {
                    dwtime = Environment.TickCount;
                    Console.Clear();
                    player.GameMain();
                    player.BulletDraw();
                    enemy.EnemyMove();
                    enemy.EnemyDraw();
                    player.CrashEnemyAndBullet(enemy);
                }
            }
        }
    } // Program 클래스 끝

} // namespace 끝