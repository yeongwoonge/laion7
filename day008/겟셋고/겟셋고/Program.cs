using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 겟셋고
{
    class character
    {
        //private int a;
        //public void setA(int _a) 
        //{
        //    a = _a;
        //}
        //public int getA(int _a) 
        //{
        //    return a;
        //}
        public int a { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            character character = new character();
            character.a = 10;
            Console.WriteLine(character.a);
        }
    }
}
