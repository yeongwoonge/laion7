using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연산자
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //연산자
            //int a = 5, b = 5;
            //int sum = a + b; //산술연산자 사용 +
            //bool isEqual = (a == b); //관계형 연산자 사용

            //Console.WriteLine($"합 : {sum}");
            //Console.WriteLine($"a와 b가 같은가? {isEqual}");

            //int number = 5;
            //Console.WriteLine(+number);
            //Console.WriteLine(-number);
            //Console.WriteLine(~number);
            //int fif = 15;
            //Console.WriteLine(~fif);

            //bool flag = true;
            //Console.WriteLine(flag);
            //Console.WriteLine(!flag);

            //int a = 10, b = 3;
            //Console.WriteLine(a+b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);

            //string firstName = "홍", lastName = "길동";
            //Console.WriteLine(firstName+lastName);

            //int a = 10, b = 3;

            //int c = a + b;
            //Console.WriteLine("더하기 : "+c);

            //int d = a - b;
            //Console.WriteLine("빼기 : "+d);

            //int e = a * b;
            //Console.WriteLine("곱하기 : " + e);

            //int f = a / b;
            //Console.WriteLine("나누기 : " + f);

            //int g = a % b;
            //Console.WriteLine("나머지 : " + g);

            int aa = 10, bb = 3;
            aa += bb; // aa = aa + bb
            Console.WriteLine("복합더하기 : " + aa);
            aa = 10;
            aa -= bb; // aa = aa - bb
            Console.WriteLine("복합빼기 : " + aa);
            aa = 10;
            aa *= bb; // aa = aa * bb
            Console.WriteLine("복합곱하기 : " + aa);
            aa = 10;
            aa /= bb; // aa = aa / bb
            Console.WriteLine("복합나누기 : " + aa);
            aa = 10;
            aa %= bb; // aa = aa % bb
            Console.WriteLine("복합나머지 : " + aa);






        }
    }
}
