using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클래스
{
    class Character // class 정의하삼
    {
        public string name;  // public 은 다른곳에서 사용가능하게함
        public int level;    // 반대는 private, 클래스 내에서만 사용 가능
        public int hp;
        public int maxHp = 100;
        public int mp;
        public int maxMp = 100;

        // 생성자 클래스 안에서 레전드 함수 기능
        public Character() // 비워두면 default 값으로 생성중
        {
            name = "홍길동";
            level = 1;
            hp = 66;
            mp = 80;
        }
        
        public Character(string _name, int _level , int _hp, int _mp) //인자가 있는 생성자
        {
            name = _name;
            level = _level;
            hp = _hp;
            mp = _mp;
        }
        public void Showstats()
        {
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"레벨 : {level}");
            Console.WriteLine($"체력 : {hp}/{maxHp}");
            Console.WriteLine($"마나 : {mp}/{maxMp}");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            //객체를 만드삼
            Character playerInfo = new Character("김진수",3,67,22);
            Character playerInfo2 = new Character("양영식",55,17,62);
            playerInfo.Showstats();
            playerInfo2.Showstats();

        }
    }
}
