using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var_데이터_형식_자동_추론
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var name = "Alice"; // 문자열로 추론
            //var age = 25; // 정수로 추론
            //var isStudent = true; // 논리값으로 추론
            //Console.WriteLine($"이름: {name}, 나이: {age}, 학생 여부: {isStudent}"); // 쉽고 편하지만, 타입 추론을 명확히 해야할 필요 존재

            //int defaultInt = default; // 기본값: 0
            //string defaultString = default; // 기본값: null
            //bool defaultBool = default; // 기본값: false
            //Console.WriteLine($"정수 기본값: {defaultInt}"); // 출력: 0
            //Console.WriteLine($"문자열 기본값: {defaultString}"); // 출력: (null)
            //Console.WriteLine($"논리값 기본값: {defaultBool}"); // 출력: False

            //// 1. 암시적 변환 (작은 타입 -> 큰 타입)
            //int small = 100;
            //long big = small; // 암시적 변환, int -> long은 알아서 자동 변환
            //double bigbig = small; // 암시적 변환, int -> double도 자동 변환
            //Console.WriteLine($"암시적 변환: {big}"); // 출력: 100
            //Console.WriteLine(small.GetType());
            //Console.WriteLine(big.GetType());
            //Console.WriteLine(bigbig.GetType());
            //// 2. 명시적 변환 (큰 타입 -> 작은 타입)
            //double pi = 3.14159;
            //int intPi = (int)pi; // 명시적 변환, double -> int는 강제 변환 필요
            //Console.WriteLine($"명시적 변환: {intPi}"); // 출력: 3
            //Console.WriteLine(pi.GetType());
            //Console.WriteLine(intPi.GetType());

            //int a = 10;
            //a.ToString(); // int를 문자열로 변환
            //Convert.ToString(a);
            //Console.WriteLine(a.GetType());

            //문자열 -> 숫자 변환
            string scoreText = "95";
            int score = int.Parse(scoreText); // 문자열을 정수로 변환
            Console.WriteLine($"점수: {score}"); // 출력: 점수: 95

            string priceText = "19.99";
            double price = double.Parse(priceText);

            Console.WriteLine("\n=== 문자열 변환 ===");
            Console.WriteLine($"점수(문자열) : {scoreText} -> 숫자 : {score}");
            Console.WriteLine($"가격(문자열) : {priceText} -> 숫자 : {price}");

            //숫자 -> 문자열 변환
            int playerLevel = 50;
            string levelText = playerLevel.ToString(); // 정수를 문자열로 변환
            Console.WriteLine($"\n=== 숫자 변환 ===");
            Console.WriteLine($"플레이어 레벨(숫자) : {playerLevel} -> 문자열 : {levelText}");




            // 1. 명시적 변환 시 데이터 손실
            double value = 9.8;
            int result = (int)value;  // 9.8 → 9 (소수점 버려짐!)
            int realResult = Convert.ToInt32(value); // 반올림 처리
            Console.WriteLine(realResult);

            // 2. 범위 초과
            int bigValue = 300;
            byte smallValue = (byte)bigValue;  // 오버플로우 발생!
            Console.WriteLine(smallValue); // 300-256 = 44 출력

            // 3. 잘못된 문자열 변환
            string text = "abc";
            // int num = int.Parse(text);  // ❌ 런타임 오류!

            // 안전한 변환: TryParse 사용
            if (int.TryParse(text, out int num))
            {
                Console.WriteLine($"변환 성공: {num}");
            }
            else
            {
                Console.WriteLine("변환 실패!");
            }


        }
    }
}
