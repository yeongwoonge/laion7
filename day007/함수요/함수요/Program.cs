using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 함수요
{
    internal class Program
    {
        static int GetNumber(int a)
        {
            int j = 1;
            for (int i = 0; i < a; i++)
            {
                j *= a;
            }
            return j;
        }

        static string Hi(string name)
        {
            return name+"님 접속";
        }


        static void Main(string[] args)
        {
            int num = GetNumber(4);
            Console.WriteLine(num);

            string name = Hi("요루");
            Console.WriteLine(name);
        }
    }
}
