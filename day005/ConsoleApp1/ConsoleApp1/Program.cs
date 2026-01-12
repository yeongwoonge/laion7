using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < Console.WindowWidth; x += 2)
            {
                // 윗벽 (Y는 0으로 고정)
                Console.SetCursorPosition(x, 0);
                Console.Write("■");

                // 아랫벽 (Y는 밑바닥으로 고정)
                // 주의: WindowHeight에서 1을 빼야 맨 밑 줄입니다. 
                // (버퍼 문제로 화면이 밀릴 수 있어서 -2로 안전하게 잡음)
                Console.SetCursorPosition(x, Console.WindowHeight - 2);
                Console.Write("■");
            }

            // 2. 세로 선 그리기 (왼쪽, 오른쪽)
            // 세로(Y)는 1칸씩 이동해도 됩니다.
            for (int y = 0; y < Console.WindowHeight - 1; y++)
            {
                // 왼쪽벽 (X는 0으로 고정)
                Console.SetCursorPosition(0, y);
                Console.Write("■");

                // 오른쪽벽 (X는 오른쪽 끝으로 고정)
                // 가로 폭에서 2칸 정도 뺀 위치
                Console.SetCursorPosition(Console.WindowWidth - 2, y);
                Console.Write("■");
            }
        
        }
    }
}
