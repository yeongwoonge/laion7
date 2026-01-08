using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 제어문
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int score = 75; 

            //if (score >= 90 )
            //{
            //    Console.WriteLine("A학점");
            //}

            //else if (score>=70)
            //{
            //    Console.WriteLine("B학점");
            //}

            //else if (score >= 50)
            //{
            //    Console.WriteLine("C학점");
            //}
            //else
            //{
            //    Console.WriteLine("F학점");
            //}

            //int a = 11;
            //int b = 10;
            //if (a == b)
            //{
            //    Console.WriteLine("a는 "+b+"입니다.");
            //}
            //else
            //{
            //    Console.WriteLine("a는 "+b+"이 아닙니다.");
            //}
            //int currentHealth = 30;
            //int maxHealth = 100;
            //Console.WriteLine("---------------");
            //Console.WriteLine($"현재 체력: {currentHealth}/{maxHealth}");
            //if (currentHealth == 0)
            //{
            //    Console.WriteLine($"게임 오버!");
            //    Console.WriteLine($"부활 지점에서 다시 시작합니다.");
            //}
            //else if (currentHealth <= maxHealth * 0.3)
            //{
            //    Console.WriteLine($"경고: 체력이 위험합니다!");
            //    Console.WriteLine($"회복 아이템을 사용하세요!");
            //}
            //else if ( currentHealth <= maxHealth * 0.5)
            //{
            //    Console.WriteLine($"체력이 50% 이하입니다.");
            //}
            //Console.WriteLine("---------------");

            //int enemyDistance = 5;
            //int attackRange = 3;
            //if (attackRange >= enemyDistance)
            //{
            //    Console.WriteLine("적이 사거리 내에 있습니다!");
            //    Console.WriteLine("공격 가능!");
            //}
            //else
            //{
            //    Console.WriteLine("적이 사거리 밖에 있습니다!");
            //    Console.WriteLine("공격 불가능!");
            //}
            //Console.WriteLine("---------------");

            //int playerGold = 111;
            //int itemPrice = 250;
            //string itemName = "강철 검";
            //Console.WriteLine("===상점===");
            //Console.WriteLine($"아이템: {itemName}");
            //Console.WriteLine($"가격: {itemPrice}");
            //Console.WriteLine($"소지금: {playerGold}\n");
            //if (playerGold >= itemPrice)
            //{
            //    playerGold -= itemPrice;
            //    Console.WriteLine("구매 성공!");
            //    Console.WriteLine($"{itemName}을 획득했습니다!");
            //    Console.WriteLine($"남은 골드: {playerGold}");
            //}
            //else
            //{
            //    int needGold = itemPrice - playerGold;
            //    Console.WriteLine("골드가 부족합니다.");
            //    Console.WriteLine($"필요한 골드: {needGold}골드가 더 필요합니다");
            //}
            //Console.WriteLine("\n====던전 입장====");
            //int playerLevel = 48;
            //int requiredLevel = 50;
            //if (playerLevel >= requiredLevel)
            //{
            //    Console.WriteLine("던전에 입장합니다.");
            //    Console.WriteLine("전투 준비!");
            //}
            //else
            //{
            //    int needLevel = requiredLevel - playerLevel;
            //    Console.WriteLine("레벨이 부족합니다.");
            //    Console.WriteLine($"던전에 입장하려면 {needLevel}레벨이 더 필요합니다.");
            //}

            //int score = 0;
            //score = int.Parse(Console.ReadLine());
            //string rank;

            //Console.WriteLine("===게임 랭킹 시스템===");
            //Console.WriteLine($"점수 : {score}");

            //if (score >= 10000)
            //{
            //    rank = "SSS";
            //    Console.WriteLine($"등급 : {rank} (레전드)");
            //    Console.WriteLine("보상 : 전설아이템 + 10000 골드");
            //}
            //else if(score >= 8000)
            //{
            //    rank = "SS";
            //    Console.WriteLine($"등급 : {rank} (최상급)");
            //    Console.WriteLine("보상 : 영웅아이템 + 5000 골드");
            //}
            //else if(score >= 5000)
            //{
            //    rank = "S";
            //    Console.WriteLine($"등급 : {rank} (상급)");
            //    Console.WriteLine("보상 : 희귀아이템 + 2000 골드");
            //}
            //else if(score >= 3000)
            //{
            //    rank = "A";
            //    Console.WriteLine($"등급 : {rank} (중급)");
            //    Console.WriteLine("보상 : 고급아이템 + 1000 골드");
            //}
            //else
            //{
            //    rank = "B";
            //    Console.WriteLine($"등급 : {rank} (초급)");
            //    Console.WriteLine("보상 : 초보아이템 + 500 골드");
            //}

            Console.WriteLine("\n === 캐릭터 상태 ===");
            int originHealth = 100;
            Console.Write("현재 체력을 입력하세요 (0~100): ");
            int health = int.Parse(Console.ReadLine());
            Console.WriteLine($"체력: {health}/{originHealth}");
            if (health >= 80)
            {
                Console.WriteLine("상태: 매우 좋음");
            }
            else if (health >= 60)
            {
                Console.WriteLine("상태: 좋음");
            }
            else if ( health >= 40)
            {
                Console.WriteLine("상태: 보통");
            }
            else if ( health >= 20)
            {
                Console.WriteLine("상태: 위험");
            }
            else
            {
                Console.WriteLine("상태: 매우 위험");
            }





        }
    }
}
