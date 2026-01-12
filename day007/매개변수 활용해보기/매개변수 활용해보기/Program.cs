using System;

namespace 매개변수_활용해보기
{
    internal class Program
    {

        static void Info(string name, int att, int def, int dex, int luk)
        {
            Console.Clear();
            Console.WriteLine($"이름:{name}");
            Console.WriteLine($"공격려ㄱ:{att}");
            Console.WriteLine($"방어력:{def}");
            Console.WriteLine($"민첩:{dex}");
            Console.WriteLine($"행운:{luk}");
            
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("이름 입력 ㄱㄱ");
            string name = Console.ReadLine();
            Info(name,100, 20,30,1); // 
        }
    }
}
