using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int intNum = 123456;
            //float flotNum = 1234.56f;
            //double dubleNum = 1234.56;

            //Console.WriteLine(intNum);
            //Console.WriteLine(flotNum);
            //Console.WriteLine(dubleNum);

            //byte 0~255
            //sbyte -128~127
            //short -32,768~32,767
            //ushort 0~65,535
            //int -2,147,483,648~2,147,483,647
            //uint 0~4,294,967,295
            //long -9,223,372,036,854,775,808~9,223,372,036,854,775,807
            //ulong 0~18,446,744,073,709,551,615


            byte level = 50;
            short attack = 1500;
            int gold = 1234567;
            long exp = 99999999999999999l;

            Console.WriteLine("=== 캐릭터 정보 ===");
            Console.WriteLine($"레벨 : {level}");
            Console.WriteLine($"공격력 : {attack}");
            Console.WriteLine($"골드 : {gold:N0}골드");
            Console.WriteLine($"경험치 : {exp:n0}");

            Console.WriteLine("\n=== 타입별 최대값 ===");
            Console.WriteLine($"byte 최대값 : {byte.MaxValue}");
            Console.WriteLine($"short 최대값 : {short.MaxValue}");
            Console.WriteLine($"int 최대값 : {int.MaxValue:N0}");
            Console.WriteLine($"long 최대값 : {long.MaxValue:n0}");





        }
    }
}
