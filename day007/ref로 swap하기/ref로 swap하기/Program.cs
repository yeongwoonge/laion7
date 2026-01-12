using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref로_swap하기
{
    internal class Program
    {

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b; 
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 10; int b = 20;
            int c = 30; int d = 40;
            Swap(ref a, ref b);
            Swap(ref c, ref d);
            Console.WriteLine(a+"+"+b);
            Console.WriteLine(c+"+"+d);
        }
    }
}
