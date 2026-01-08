using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace while문
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while (i < 9)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //Console.WriteLine("\n===예제2 : 카운트다운 ===");
            //int countDown = 10;
            //while (countDown >= 0)
            //{
            //    Console.WriteLine(countDown);
            //    --countDown;
            //}

            //Console.WriteLine("===예제3: 합계구하기");
            //int sum = 0;
            //int i = 1;
            //while (i <= 5)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            //Console.WriteLine("\n=== 예제 4: 목표 달성하기 ===");
            //int coins = 0;
            //int target = 50;
            //int day = 0;

            //while (coins<target)
            //{
            //    day++;
            //    coins += 10;
            //    Console.WriteLine($"{day}일차 : 코인 {coins}개");
            //}
            //Console.WriteLine($"목표 달성~ 총 {day}일 걸렸습니다.");

            //int x = 5;
            //do
            //{
            //    Console.WriteLine(x);
            //    x--;
            //} while (x > 0);

            string choice;
            int totalPrice = 0;

            do
            {
                //메뉴출력
                Console.WriteLine("메뉴판");
                Console.WriteLine("1. 짜장면 - 5,000원");
                Console.WriteLine("2. 짬뽕 - 6,000원");
                Console.WriteLine("3. 탕수육 - 15,000원");
                Console.WriteLine("4. 볶음밥 - 7,000원");
                Console.WriteLine("0. 주문 완료");
                Console.WriteLine("=========================");
                Console.Write("메뉴 번호를 선택하세요: ");

                choice = Console.ReadLine();

                //메뉴 선택 처리
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("짜장면 추가! (+5,000원)");
                        totalPrice += 5000;
                        break;
                    case "2":
                        Console.WriteLine("짜장면 추가! (+6,000원)");
                        totalPrice += 6000;
                        break;
                    case "3":
                        Console.WriteLine("짜장면 추가! (+15,000원)");
                        totalPrice += 15000;
                        break;
                    case "4":
                        Console.WriteLine("짜장면 추가! (+7,000원)");
                        totalPrice += 7000;
                        break;
                    case "0":
                        Console.WriteLine("주문을 완료합니다.");
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다.");
                        break;
                }

                //0번 선택 전까지
                if (choice != "0")
                {
                    Console.WriteLine($"현재 총액: {totalPrice:N0}원");
                }



            } while (choice != "0"); //0을 입력할 때까지 반복

        }
    }
}
