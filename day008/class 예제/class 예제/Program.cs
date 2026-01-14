using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_예제
{
    class Character 
    {
        private string name = "없음";
        private int level = 0;
        private int hp = 0;
        private int maxHp = 100;
        private int mp = 0;
        private int maxMp = 100;

        public Character(string _name, int _level, int _hp, int _mp)
        {
            name = _name;
            level = _level;
            hp = _hp;
            mp = _mp;
        }
        public void ShowStats()
        {
            Console.WriteLine("============");
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"체력: {hp}/{maxHp}");
            Console.WriteLine($"마나: {mp}/{maxMp}");
            Console.WriteLine("============");
        }
        public void TakeDamage(int damage)
        {
            hp -= damage;
            if (hp < 0) hp = 0;
            Console.WriteLine($"{name}가(이) {damage} 데미지를 받았습니다");
            Console.WriteLine($"남은 체력: {hp}/{maxHp}");
        }
        public void Heal(int heal)
        {
            hp += heal;
            if (hp>maxHp) hp = maxHp;
            Console.WriteLine($"{name}가(이) {heal} 체력을 회복했습니다");
            Console.WriteLine($"남은 체력: {hp}/{maxHp}");
        }

    } 

    internal class Program
    {
        static void Main(string[] args)
        {
            //Character cha = new Character("기사",38,97,64);
            //cha.ShowStats();
            //cha.TakeDamage(40);
            //cha.TakeDamage(40);
            //cha.Heal(30);
            //Character cha2 = new Character("법사", 21, 37, 94);
            //cha2.ShowStats();

            Character[] arr =
            {
                new Character("기사", 38, 97, 64),
                new Character("마법사", 50, 44, 99),
                new Character("도적",77,85,70)
            };
            foreach( Character c in arr)
            {
                c.ShowStats();
            }   

        }
    }
}
