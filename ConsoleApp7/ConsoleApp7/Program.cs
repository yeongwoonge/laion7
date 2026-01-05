using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////상수 : 값을 변경할 수 없는 변수
            //const double Pi = 3.14159; //상수 Pi 선언 및 초기화 
            //const int MaxScore = 100; //정수형 상수 선언

            ////출력
            //Console.WriteLine("Pi: " + Pi);
            //Console.WriteLine("Max Score: " + MaxScore);

            const int maxPlayers = 4; //최대 플레이어 수
            const int startGold = 1000; //게임 시작 시 지급되는 골드
            const string verson = "1.0.0"; //게임 버전

            Console.WriteLine("** 실행 결과 **\n");
            Console.WriteLine("=== 게임 설정 ===");
            Console.WriteLine($"최대 플레이어: {maxPlayers}명");
            Console.WriteLine($"시작 골드: {startGold}G");
            Console.WriteLine($"버전: {verson}");


        }
    }
}