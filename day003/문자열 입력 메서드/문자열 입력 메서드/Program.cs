using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문자열_입력_메서드
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("이름을 입력하세요.");
            //string userName = Console.ReadLine();
            //Console.WriteLine($"반갑습니다, {userName}님!");

            //Console.WriteLine("나이를 입력하세요:");
            //string input = Console.ReadLine();
            //int age = int.Parse(input);
            //Console.WriteLine($"내년에는 {age+1}살이 되겠군요!");

            //Console.WriteLine("2진수를 입력하세요:");
            //string binaryInput = Console.ReadLine();
            //int decimalValue = Convert.ToInt32(binaryInput, 2); // Convert.ToInt32( -- , n ) < --을 n진수로 변환, int로 반환
            //string binaryOutput = Convert.ToString(decimalValue, 2); 

            //Console.WriteLine($"입력한 이진수 : {binaryInput}");
            //Console.WriteLine($"10진수로 변환 : {decimalValue}");
            //Console.WriteLine($"다시 이진수로 변환 : {binaryOutput}");

            Console.WriteLine("=== 캐릭터 생성 ===");
            Console.Write($"캐릭터 이름을 입력하세요: ");
            string characterName = Console.ReadLine();
            Console.WriteLine($"환영합니다, {characterName}님!");
            Console.Write($"시작 레벨을 입력하세요: ");
            string characterLevelInput = Console.ReadLine();
            int characterLevel = int.Parse(characterLevelInput);
            Console.WriteLine($"{characterName}님의 시작 레벨은 {characterLevelInput}입니다.");

        }
    }
}
