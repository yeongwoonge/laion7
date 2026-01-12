using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_키워드
{
    internal class Program
    {

        static int attack(ref int b)
        {
            Console.WriteLine($"공격력 : {b}");
            b++;
            return b;
        }
        static void Main(string[] args)
        {
            int a = 10;
            attack(ref a);
            Console.WriteLine(a);
        }
    }
}
