using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 실습예제
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 문제 1: 온도에 따른 옷차림 추천
            Console.Write("온도: ");
            int temp = int.Parse(Console.ReadLine());
            Console.WriteLine($"현재 온도: {temp}ºC");
            if (temp >= 30)
            {
                Console.WriteLine("매우 더워요! 반팔과 반바지를 입으세요.");
            }
            else if (temp >= 20)
            {
                Console.WriteLine("적당해요! 긴팔 티셔츠를 입으세요.");
            }
            else if (temp >= 10)
            {
                Console.WriteLine("쌀쌀해요! 가디건이나 자켓을 챙기세요.");
            }
            else if (temp >= 0)
            {
                Console.WriteLine("추워요! 코트를 입으세요.");
            }
            else
            {
                Console.WriteLine("매우 추워요! 패딩과 목도리가 필요해요.");
            }

            //문제 2: 게임 캐릭터 직업 선택

            Console.Write("직업 선택 (1:전사, 2:마법사, 3:궁수, 4:도적) : ");
            string userChoice = Console.ReadLine();
            string className = "";
            string classInfo = "";
            string classStartStat1 = "";
            string classStartStat1Value = "";
            string classStartStat2 = "";
            string classStartStat2Value = "";
            bool validChoice = true;
            switch (userChoice)
            {
                case "1":
                case "전사":
                    className = "전사";
                    classInfo = "높은 체력과 방어력";
                    classStartStat1 = "HP";
                    classStartStat1Value = "+50";
                    classStartStat2 = "공격력";
                    classStartStat2Value = "+10";
                    break;
                case "2":
                case "마법사":
                    className = "마법사";
                    classInfo = "강력한 마법 공격";
                    classStartStat1 = "마나";
                    classStartStat1Value = "+100";
                    classStartStat2 = "마법력";
                    classStartStat2Value = "+20";
                    break;
                case "3":
                case "궁수":
                    className = "궁수";
                    classInfo = "원거리 공격 특화";
                    classStartStat1 = "민첩";
                    classStartStat1Value = "+15";
                    classStartStat2 = "크리티컬";
                    classStartStat2Value = "+10%";
                    break;
                case "4":
                case "도적":
                    className = "도적";
                    classInfo = "빠른 속도와 회피";
                    classStartStat1 = "민첩";
                    classStartStat1Value = "+20";
                    classStartStat2 = "회피율";
                    classStartStat2Value = "+15%";
                    break;
                default:
                    validChoice = false;
                    break;
            }
            if (validChoice)
            {
                Console.WriteLine($"===캐릭터 생성===");
                Console.WriteLine($"{className} - {classInfo}");
                Console.WriteLine($"시작 스탯: {classStartStat1} {classStartStat1Value}, {classStartStat2} {classStartStat2Value}");
            }
            else
            {
                Console.WriteLine("유효하지 않은 입력입니다.");
            }

            int postionPrice = 100;
            int playerGold = 500;
            Console.Write("포션 몇 개를 구매하시겠습니까? ");
            string input = Console.ReadLine();
            if(int.TryParse(input,out int postionBuyCount))
            {   
                int postionTotalPrice = postionBuyCount * postionPrice;
                if (postionBuyCount <= 0)
                {
                    Console.WriteLine("유효하지 않은 입력입니다.");
                }
                else if(postionTotalPrice <= playerGold)
                {
                    int remainedGold = playerGold - postionTotalPrice;
                    Console.WriteLine($"총 가격 : {postionTotalPrice}");
                    Console.WriteLine($"구매 완료! {remainedGold}G 남았습니다.");
                }
                else
                {
                    int needGold = postionTotalPrice - playerGold;
                    Console.WriteLine($"총 가격 : {postionTotalPrice}");
                    Console.WriteLine($"구매 실패.. {needGold}G 부족합니다.");
                }
            }
            else
            {
                Console.WriteLine("유효하지 않은 입력입니다.");
            }



        }
    }
}
