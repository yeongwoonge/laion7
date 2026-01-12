using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 매게변수
{
    internal class Program
    {
        static void ItemPotionUse(string item, int value ) 
        {
            Console.WriteLine($"{item}사용");
            Console.WriteLine($"회복량: {value}HP");
            Console.WriteLine();

        }

        static void Summon(string name, int level , int amount)
        {
            Console.WriteLine($"{name}소환");
            Console.WriteLine($"레벨:{level}");
            Console.WriteLine($"수량:{amount}마리");
            Console.WriteLine(
                );
        }
        static void Main(string[] args)
        {
            ItemPotionUse("회복포션",25);
            ItemPotionUse("고급회복포션",50);
            Summon("슬라임",1,1);
            Summon("고블린",5,1);
            Summon("드래곤",100,3);

        }
    }
}
