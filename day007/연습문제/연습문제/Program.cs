using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 연습문제
{
    internal class Program
    {
        static float aver(int[] numli) //평균계산
        {
            int sum = 0;
            for (int i = 0; i< numli.Length; i++) sum += numli[i];
            return (float)sum/numli.Length;
        }
        static string grade(int a) //등급판별
        {
            string b = "유효하지 않은 값";
            if (a <= 100 && a >= 0)
            {
                if (a >= 90) b = "A";
                else if (a >= 70) b = "B";
                else if (a >= 50) b = "C";
                else b = "F";
                return b;
            }
            else return b;
        }
        static string sosu(int a) //소수판별
        {
            if (a == 1) return "소수아님";
            for (int i = 2; i < a; i++) if (a % i == 0) return "소수 아님";
            return "소수임";
        }
        static void exp(int a, int b, out string c,out int d) //경험치
        {
            int need = 100;
            if (a + b >= need) { c = "레벨업 성공"; d = need - (a+b)%need; }
            else { c = "레벨업 실패"; d = need - (a + b); }            
        }

        static Random rand = new Random(); //아이템 강화
        static string gacha(int a)
        {
            int dwtime = Environment.TickCount;
            while (Environment.TickCount - dwtime < 100) ;
            if (a >= 9) a = 9;
            if (rand.Next(0, 100 - a * 10) < 5) return "당첨";
            else Console.WriteLine("꽝"); return gacha(a);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(aver(new int[]{ 10, 30, 40,100 })); //문제1 평균계산
            Console.WriteLine(grade(85)); //문제2 등급판별
            Console.WriteLine(sosu(37)); //문제3 소수판별
            int a = 50; int b = 60;
            exp(a, b, out string c, out int d);
            Console.WriteLine($"{c}. 다음 레벨까지 {d}exp 더 필요");  //문제4 경험치시스템
            int lv = 8;
            Console.WriteLine(gacha(lv)); //문제5 아이템강화
        }
    }
}
