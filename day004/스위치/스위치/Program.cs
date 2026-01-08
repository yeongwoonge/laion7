using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 스위치
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //int day = 3;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    default:
            //        Console.WriteLine("유효하지 않은 요일");
            //        break;


            //Console.WriteLine("직업을 선택해주세요.");
            //Console.WriteLine("1. 마법사, 2. 전사, 3. 도적");
            //string jobName = Console.ReadLine();
            //switch (jobName)
            //{
            //    case "1":
            //    case "마법사":
            //        Console.WriteLine("===캐릭터 생성===");
            //        Console.WriteLine($"직업: 마법사");
            //        Console.WriteLine($"특성: 강력한 마법 공격");
            //        Console.WriteLine($"주 무기: 지팡이, 마법서");
            //        Console.WriteLine($"스탯: 마나 +100, 마법공격력 +20");
            //        break;
            //    case "2":
            //    case "전사":
            //        Console.WriteLine("===캐릭터 생성===");
            //        Console.WriteLine($"직업: 전사");
            //        Console.WriteLine($"특성: 그냥 공격");
            //        Console.WriteLine($"주 무기: 한손검, 대검");
            //        Console.WriteLine($"스탯: 근력 +20, 공격력 +20");
            //        break;
            //    case "3":
            //    case "도적":
            //        Console.WriteLine("===캐릭터 생성===");
            //        Console.WriteLine($"직업: 도적");
            //        Console.WriteLine($"특성: 은신 공격시 크리티컬 피해 증가");
            //        Console.WriteLine($"주 무기: 단검, 암기");
            //        Console.WriteLine($"스탯: 민첩 +20, 치명타피해 +20");
            //        break;
            //    default:
            //        Console.WriteLine("유효하지 않은 직업입니다");
            //        break;
            //}
            // 아이템 타입별 설명
            Console.WriteLine("\n=== 아이템 정보 ===");
            string itemType = "weapon";

            switch (itemType)
            {
                case "weapon":
                    Console.WriteLine("🗡️ 무기 - 공격력 증가");
                    break;
                case "armor":
                    Console.WriteLine("🛡️ 방어구 - 방어력 증가");
                    break;
                case "potion":
                    Console.WriteLine("🧪 물약 - 체력/마나 회복");
                    break;
                case "accessory":
                    Console.WriteLine("💍 장신구 - 특수 능력 부여");
                    break;
                default:
                    Console.WriteLine("❓ 알 수 없는 아이템");
                    break;
            }

            // 요일별 이벤트
            Console.WriteLine("\n=== 오늘의 이벤트 ===");
            int dayOfWeek = 3;  // 0:일, 1:월, 2:화, 3:수, 4:목, 5:금, 6:토

            switch (dayOfWeek)
            {
                case 0:
                    Console.WriteLine("🎁 일요일: 경험치 2배");
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("📅 평일: 일반 보상");
                    break;
                case 5:
                    Console.WriteLine("💰 금요일: 골드 2배");
                    break;
                case 6:
                    Console.WriteLine("🎲 토요일: 아이템 드롭률 2배");
                    break;
                default:
                    Console.WriteLine("잘못된 요일");
                    break;
            }



        }
    }
}


