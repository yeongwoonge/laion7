using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연산자_예제
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseAttack = 50;
            int weaponDamage = 30;
            int totalAttack = baseAttack + weaponDamage;

            Console.WriteLine("=== 공격력 계산 ===");
            Console.WriteLine("기본 공격력: " + baseAttack);
            Console.WriteLine("무기 공격력: " + weaponDamage);
            Console.WriteLine("총 공격력: " + totalAttack);

            int playerHealth = 100;
            int damageTaken = 25;
            playerHealth -= damageTaken;
            Console.WriteLine("\n=== 체력 계산 ===");
            Console.WriteLine("받은 피해량: " + damageTaken);
            Console.WriteLine("남은 체력: " + playerHealth);

            int monsterKilled = 5;
            int expPerMonster = 100;
            int totalExp = monsterKilled * expPerMonster;
            Console.WriteLine("\n=== 경험치 계산 ===");
            Console.WriteLine("처치한 몬스터 수: " + monsterKilled + "마리");
            Console.WriteLine("몬스터 당 경험치: " + expPerMonster);
            Console.WriteLine("총 경험치: "+totalExp );

            int totalGold = 1003;
            int playerCount = 4;
            int goldPerPlayer = totalGold / playerCount;
            int remainingGold = totalGold % playerCount;
            Console.WriteLine("\n=== 골드 분배 ===");
            Console.WriteLine("총 골드: " + totalGold+"G");
            Console.WriteLine("플레이어 수: " + playerCount + "명");
            Console.WriteLine("플레이어 당 골드: " + goldPerPlayer+"G");
            Console.WriteLine("남은 골드: " + remainingGold);


        }
    }
}
