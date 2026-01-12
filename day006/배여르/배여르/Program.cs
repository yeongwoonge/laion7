using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 배여르
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 배열 << 크기 고정 제일 중요함
            //int[] scores = new int[5];

            //int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            //int[] values = { 10, 20, 30, 40, 50 };

            //scores[1] = 11; scores[2] = 12; scores[3] = 13; scores[4] = 14; scores[0] = 10;
            //Console.WriteLine(scores[1] + scores[2]);

            //for (int i= 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //    Console.WriteLine(values[i]);
            //}

            //string[] inventory = new string[5];


            //for (int i=0;i < inventory.Length; i++)
            //{
            //    Console.Write($"추가할 아이템을 입력해주세요 : ");
            //    inventory[i] = Console.ReadLine();
            //    Console.WriteLine($"남은 횟수 : {4-i}");
            //}
            //Console.WriteLine($"{ inventory[0]}을 사용했다");
            //inventory[0] = "비어있음";
            //Console.WriteLine("\n=== 인벤토리 ====");
            //for (int i = 0; i < inventory.Length; i++)
            //{
            //    Console.WriteLine($"[{i + 1}] {inventory[i]}");
            //}

            //int[] characterStatValue = { 100, 50, 80, 60, 45 };
            //string[] characterStat = { "체력", "마나", "공격력", "방어력", "민첩" };
            //Console.WriteLine("=== 캐릭터 스탯 ===");
            //for (int i=0; i< characterStat.Length; i++)
            //{
            //    Console.WriteLine($"{characterStat[i]} : {characterStatValue[i]}");
            //}

            //string[] dailyQuestMonsterName = { "고블린", "오크", "슬라임", "드래곤", "좀비" };
            //int[] dailyQuestHaveDone = { 5, 3, 8, 2, 7 };
            //int[] dailyQuestComplete = { 5, 5, 5, 5, 5 };
            //Console.WriteLine("=== 일일 퀘스트 진행도 ===");
            //for (int i = 0; i < dailyQuestMonsterName.Length; i++)
            //{
            //    string status = dailyQuestHaveDone[i] >= dailyQuestComplete[i] ? "완료" : "진행중";
            //    Console.WriteLine($"{dailyQuestMonsterName[i]} 퇴치 : {dailyQuestHaveDone[i]} / {dailyQuestComplete[i]} {status}");
            //}
            //int[] scores = { 85, 92, 78, 95, 88 };

            ////배열 길이
            //Console.WriteLine("총 점수 개수: " + scores.Length);

            ////배열 순회
            //Console.WriteLine("개별 점수");
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine($"플레이어 {i + 1} : {scores[i]}점");
            //}


            ////합계 계산
            //int sum = 0;

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    sum += scores[i];
            //}

            //Console.WriteLine($"총점 : {sum}점");
            //Console.WriteLine($"평균 : {(float)sum / (float)scores.Length}점");


            //int[] scores = { 85, 92, 78, 95, 88 };
            //int scoresMax =0;
            //int scoresMin =100;
            //for (int i = 0; i< scores.Length; i++)
            //{
            //    if (scores[i] > scoresMax)
            //    {
            //        scoresMax = scores[i];
            //    }
            //    if(scores[i] < scoresMin)
            //    {
            //        scoresMin = scores[i];
            //    }
            //}
            //Console.WriteLine($"최고 점수 : {scoresMax}점");
            //Console.WriteLine($"최저 점수 : {scoresMin}점");

            //Console.WriteLine(" === array 메서드 === ");
            //int[] scores = { 85, 92, 78, 95, 88 };
            //int[] sortedScore = (int[])scores.Clone();

            //Array.Sort(sortedScore);
            //Console.WriteLine("오름차순");
            //for (int i = 0; i < sortedScore.Length; i++)
            //{
            //    Console.WriteLine($"{sortedScore[i]}점");
            //}
            //Array.Reverse(sortedScore);
            //Console.WriteLine("내림차순");
            //for (int i = 0; i < sortedScore.Length; i++)
            //{
            //    Console.WriteLine($"{sortedScore[i]}점");
            //}
            //foreach(int score in sortedScore)
            //{
            //    Console.WriteLine(score);
            //}

            //int[] scores = { 85, 92, 78, 95, 88 };

            //int searchScore = 92;
            //int index = Array.IndexOf(scores, searchScore);
            //Console.WriteLine($"{searchScore}점의 위치: 인덱스 {index}");
            //Console.WriteLine("찾은값 : " + scores[index]);
            string[] a = { "11", "2a", "34", "4gg" };

            foreach (string index in a)
            {
                Console.WriteLine(index);
            }



        } 
    }
}
