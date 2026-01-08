using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 기타_연산자
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10, b = 20;
            //string max = (a > b) ? "십" : "이십";
            //Console.WriteLine(max);

            //int score = 85;
            //string result = (score >= 60) ? "합격" : "불합격";

            //Console.WriteLine("=== 시험결과 ===");
            //Console.WriteLine($"점수: {score}");
            //Console.WriteLine($"결과: {result}");

            //int lv = 1;
            //string grade = ( lv > 50 ) ? "고급" : ( lv >=30 ) ? "중급" : "초급";
            //Console.WriteLine("플레이어 등급");
            //Console.WriteLine($"레벨: {lv}");
            //Console.WriteLine($"등급: {grade}");

            int health = 30;
            int maxHealth = 200;
            string healthStatus = (health >= maxHealth * 0.7) ? "안전" :
                                  (health >= maxHealth * 0.3) ? "주의" : "위험";

            Console.WriteLine("===체력 상태===");
            Console.WriteLine($"현재 체력: {health}/{maxHealth}");
            Console.WriteLine($"상태 : {healthStatus}");


        }
    }
}
