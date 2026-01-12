using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 함수활영
{
    internal class Program
    {
        static void Greeting(string playerName)
        {
            Console.WriteLine($"반가워요 {playerName}씨");
        }
        static void PlayerInfo(string job, int level)
        {
            Console.WriteLine($"직업 : {job}");
            Console.WriteLine($"레벨 : {level}");
        }

        static void HealthBar(int currentHp, int maxHp, int barLength)
        {
            Console.Write($"HP [");
            int filledLength = (int)((double)currentHp / maxHp*barLength);
            for (int i = 0; i < barLength; i++)
            {
                if (i < filledLength)
                {
                    Console.Write("■");
                }
                else
                {
                    Console.Write("□");
                }
                
            }
            Console.WriteLine($"] {currentHp}/{maxHp}");
        }

        static void Damage(string attacker , string target, int damage)
        {
            Console.WriteLine($"{attacker}의 공격");
            Console.WriteLine($"{target}에게 {damage} 뎀");
        }

        static void Main(string[] args)
        {
            Greeting("홍길동");
            Console.WriteLine();
            PlayerInfo("전사", 50);
            Console.WriteLine();

            HealthBar(76, 100, 20);
            HealthBar(33, 100, 20);
            HealthBar(100, 100, 20);
            Console.WriteLine();

            Damage("길동이", "고블린", 85);
            Console.WriteLine();
            Damage("드래곤", "길동이", 33);
        }

    }
}
