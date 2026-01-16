using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 상속_ㅅㅅ
{
    class Character
    {
        // public , private , protected 사용
        // 상속되어있는 자식이 사용 가능하게 열어주는 접근제어자
        protected string name;
        protected int lv;
        protected int hp;
        protected int maxHp;
        protected int attack;
        protected int defense;

        public Character(string characterName)
        {
            name = characterName;
            lv = 1;
            maxHp = 100;
            hp = maxHp;
            attack = 30;
            defense = 10;
            Console.WriteLine($"캐릭터 {name} 생성 완료");
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"레벨 : {lv}");
            Console.WriteLine($"체력 : {hp}/{maxHp}");
            Console.WriteLine($"공격력 : {attack}");
            Console.WriteLine($"방어력 : {defense}");
        }
    }
    class Warrior : Character
    {
        private int rage;
        public Warrior(string name) : base(name)
        {
            attack = 60;
            defense = 40;
            maxHp = 150;
            hp = maxHp;
            rage = 0;

            Console.WriteLine($"직업 : 전사");
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"분노 : {rage}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior("김귀순쉼");
            
            warrior.ShowInfo();
        }
    }
}
