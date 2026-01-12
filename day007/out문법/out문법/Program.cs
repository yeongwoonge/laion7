using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out문법
{
    internal class Program
    {
        static void Attack(out int attack,out int defense)
        {
            attack = 10;
            defense = 30;

            attack++;
            defense++;
        }
        static void Main(string[] args)
        {
            int attack;
            int defense=20;
            Attack(out attack, out defense);
            Console.WriteLine($"공{attack}");
            Console.WriteLine($"방{defense}");
        }
    }
}
