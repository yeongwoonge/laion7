using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 관계형_연산자
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;
            //int y = 10;
            //Console.WriteLine(x < y);
            //Console.WriteLine(x > y);
            //Console.WriteLine(x <= y);
            //Console.WriteLine(x >= y);
            //Console.WriteLine(x == y);
            //Console.WriteLine(x != y);

            ////AND 연산자(&&)
            //bool a = true;
            //bool b = true;
            //Console.WriteLine(a && b); // true , 둘 다 참일 때만 참
            //b = false;
            //Console.WriteLine(a && b); // false , 하나라도 거짓이면 거짓

            ////OR 연산자(||)
            //bool c = false, d = false;
            //Console.WriteLine(c || d);  // false , 둘 다 거짓일 때만 거짓
            //c = true; d = false;
            //Console.WriteLine(c || d);  // true , 하나라도 참이면 참
            //c = true; d = true;
            //Console.WriteLine(c || d);  // true , 하나라도 참이면 참

            //// NOT 연산자(!)
            //bool e = true;
            //Console.WriteLine(!e); // false , 참이면 거짓으로
            //Console.WriteLine(!!e); // true , 거짓이면 참으로

            //int x = 5; // 0101
            //int y = 3; // 0011
            //string binary = Convert.ToString(x&y,2).PadLeft(8, '0');
            //Console.WriteLine(x & y); // AND: 1 (0001) , 둘 다 1일 때만 1
            //Console.WriteLine($"8비트 : {binary}");

            //binary = Convert.ToString(x | y, 2).PadLeft(8, '0');
            //Console.WriteLine(x | y); // OR: 7 (0111) , 하나라도 1이면 1
            //Console.WriteLine($"8비트 : {binary}");

            //binary = Convert.ToString(x ^ y, 2).PadLeft(8, '0');
            //Console.WriteLine(x ^ y); // XOR: 6 (0110) , 서로 다를 때만 1
            //Console.WriteLine($"8비트 : {binary}");

            //binary = Convert.ToString(~x , 2).PadLeft(8, '0');
            //Console.WriteLine(~x); // NOT: -6 , 모든 비트를 반전, 1010 -> 2의 보수 표현법으로 -6 
            //Console.WriteLine($"8비트 : {binary}");

            //int value = 4; // 0000 0100
            //Console.WriteLine(value << 1); // 8 (0000 1000) , 왼쪽으로 1비트 시프트, 2배
            //Console.WriteLine(value << 2); // 16 (0001 0000) , 왼쪽으로 2비트 시프트, 4배
            //Console.WriteLine(value >> 1); // 2 (0000 0010) , 오른쪽으로 1비트 시프트, 1/2배
            //Console.WriteLine(value >> 2); // 1 (0000 0001) , 오른쪽으로 2비트 시프트, 1/4배

            //Console.WriteLine(value << 3); // 32 (0010 0000) , 왼쪽으로 3비트 시프트, 8배 

            int inventory = 0; // 0000 0000 

            Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");

            //슬롯 번호
            int slot1 = 1; //활
            int slot2 = 2; //지팡이

            //슬롯 0에 활을 추가
            inventory = inventory | (1 << slot1); // 2번째로 1추가
            Console.WriteLine($"슬롯 {slot1}에 활 추가");
            Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");

            //슬롯 0에 활을 추가
            inventory = inventory | (1 << slot2); // 2번째로 1추가
            Console.WriteLine($"슬롯 {slot2}에 지팡이 추가");
            Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");



        }
    }
}
