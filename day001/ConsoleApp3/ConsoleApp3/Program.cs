using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //변수 선언후 값 저장
            //string greeting = "안녕하세요!"; //문자열 변수 선언 & 값 입력

            //Console.WriteLine(greeting);

            //변수 초기화
            //int score = 100; // 선언과 동시에 100으로 초기화 (왜 초기화라는 네임이지)
            //double temperature = 36.5;
            //string city = "Seoul";

            //Console.WriteLine(score);
            //Console.WriteLine(temperature);
            //Console.WriteLine(city);

            //int score;
            //Console.WriteLine(score);

            int health;
            health = 100;

            int maxHealth = 100;
            int damage = 15;
            Console.WriteLine("체력 : "+health+"/"+maxHealth);
            Console.WriteLine(damage+" 데미지를 입었다!");
            health = health - damage;
            Console.WriteLine("체력 : " + health + "/" + maxHealth);
            

        }
    }
}
