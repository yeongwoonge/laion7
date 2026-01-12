using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 리스트트트
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 선언 방법
            //List<int> numbers = new List<int>();           // 빈 리스트
            //List<string> names = new List<string>();       // 문자열 리스트
            //List<float> prices = new List<float>();        // 실수 리스트

            //// 초기값과 함께 선언
            //List<int> scores = new List<int> { 85, 90, 78, 95 };
            //List<string> items = new List<string> { "검", "방패", "포션" };

            //// C# 3.0 이후 간단한 초기화
            //var players = new List<string> { "철수", "영희", "민수" };

            //items.Add("회복포션");
            //items.Add("마나포션");
            //Console.WriteLine(items[1]);

            //List<string> inventory = new List<string>();
            //Console.WriteLine("=== 도적 인벤토리 시스템");
            //inventory.Add("회복포션");
            //inventory.Add("마나포션");
            //inventory.Add("강철검");
            //inventory.Remove("강철검");
            //inventory.Insert(1, "대가리");
            //inventory.RemoveAt(0);
            //inventory[0] = "초록포션";
            //Console.WriteLine("아이템 3개 추가");
            //Console.WriteLine($"인벤토리 {inventory.Count}개: ");
            //for (int i = 0; i < inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i}] {inventory[i]}");
            //}

            Dictionary<string,int> dict = new Dictionary<string, int>();
            dict.Add("HP", 90);
            dict.Add("MP", 85);
            dict["SP"] = 88;
            Console.WriteLine(dict["HP"]);
            foreach(KeyValuePair<string,int> stat in dict)
            {
                Console.WriteLine($"{stat.Key}: {stat.Value}");
            }
            string searchStat = "방어력";
            if(dict.ContainsKey(searchStat))
            {
                Console.WriteLine($"{searchStat}: {dict[searchStat]}");
            }
            else
            {
                Console.WriteLine("해당 능력치 없음");
            }


        }
    }
}
