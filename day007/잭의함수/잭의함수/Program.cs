using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 잭의함수
{
    internal class Program
    {
        static int sumsum(int n)
        {
            if (n <= 0) return 0;
            return n + sumsum(n - 1);
        }


        static void Main(string[] args)
        {
            int sum = sumsum(10);
            Console.WriteLine(sum);
        }
    }
}
