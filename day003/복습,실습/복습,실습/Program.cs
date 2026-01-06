using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 복습_실습
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 문제 1: RPG 체력 계산기
            int playerMaxHealth = 100;
            int playerCurrentHealth = 80;
            int monsterAttackDamage = 25;
            int healingPotionAmount = 30;
            int poisonDamage = 5;
            Console.WriteLine("= RPG 체력 계산기 =");
            Console.WriteLine($"초기 체력      : {playerCurrentHealth}/{playerMaxHealth}");
            Console.WriteLine($"데미지 {-monsterAttackDamage}     : {playerCurrentHealth -= monsterAttackDamage}/{playerMaxHealth}");
            Console.WriteLine($"회복 +{healingPotionAmount}       : {playerCurrentHealth += healingPotionAmount}/{playerMaxHealth}");
            Console.WriteLine($"독 데미지 {-poisonDamage}   : {playerCurrentHealth -= poisonDamage}/{playerMaxHealth}");

            // 문제 2: 경험치와 레벨 계산
            int expPerMonster = 150;
            int monstersKilled = 3;
            int expForLevelUp = 500;
            int currentExp = monstersKilled * expPerMonster;
            Console.WriteLine("\n\n= 경험치와 레벨 계산 =");
            Console.WriteLine($"처치한 몬스터  : {monstersKilled}마리");
            Console.WriteLine($"획득 경험치    : {currentExp}");
            Console.WriteLine($"레벨업까지 필요: {expForLevelUp-currentExp}");

            // 문제 3: 아이템 분배 시스템
            int totalGold = 1234;
            int partyMembers = 5;
            Console.WriteLine("\n\n= 아이템 분배 시스템 =");
            Console.WriteLine($"총 골드     : {totalGold}");
            Console.WriteLine($"파티원      : {partyMembers}");
            Console.WriteLine($"1인당 골드  : {totalGold/partyMembers}");
            Console.WriteLine($"남는 골드   : {totalGold%partyMembers}");

            // 문제 4: 던전 입장 가능 여부
            int playerLevel = 35;
            int requiredLevel = 30;
            int currentHp = 60;
            int maxHp = 100;
            bool levelCondition = playerLevel >= requiredLevel;
            bool hasKey = true;
            bool hpCondition = currentHp >= maxHp / 2;
            Console.WriteLine("\n\n= 던전 입장 가능 여부 =");
            Console.WriteLine("=== 던전 입장 조건 ===");
            Console.WriteLine($"레벨 조건 ({requiredLevel} 이상)  : {levelCondition}");
            Console.WriteLine($"열쇠 보유            : {hasKey}");
            Console.WriteLine($"체력 조건 ({maxHp/2}% 이상) : {hpCondition}");
            Console.WriteLine($"입장 가능            : {levelCondition && hpCondition && hasKey}");

            // 문제 5: 상점 할인 계산기
            float originalPrice = 5000f;
            float currentPrice = originalPrice;
            bool isVip = true;
            bool hasCoupon = true;
            if (isVip)
            {
                currentPrice=currentPrice - (originalPrice * 0.2f);
            }
            Console.WriteLine("\n\n = 상점 할인 계산기 =");
            Console.WriteLine($"원가              : {originalPrice}G");
            Console.WriteLine($"VIP 할인 (20%)    : {currentPrice}G");
            if (hasCoupon)
            {
                currentPrice = currentPrice - 500;
            }
            Console.WriteLine($"쿠폰 할인 (-500G) : {currentPrice}G");
            Console.WriteLine($"최종 가격         : {currentPrice}G");
            

        }
    }
}
