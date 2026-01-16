using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 추상클
{
    public abstract class Character 
    {
        public int hp;
        public string name;
        public int maxhp;
        public int speed;
        public Character(string _name, int _maxhp, int _speed)
        {
            name = _name;
            maxhp = _maxhp;
            hp = maxhp;
            speed = _speed;
        }
        public abstract void Job();
    }
    public class Mage : Character
    {
        public int mana;
        public int manapower;
        public Mage(string _name) : base(_name,120,4)
        {
            mana = 150;
            manapower = 100;
        }
        public override void Job()
        {
            Console.WriteLine($"[{name}] 김마법");
            Console.WriteLine($"hp: {hp}/{maxhp}");
            Console.WriteLine($"마력: {manapower}");
            Console.WriteLine($"마나: {mana}");
            Console.WriteLine($"이동속도: {speed}");
        }
    }
    public class Archer : Character
    {
        public int arrow;
        public int attack;
        public Archer(string _name) : base(_name , 150, 6)
        {
            arrow = 50;
            attack = 100;
        }
        public override void Job()
        {
            Console.WriteLine($"[{name}] 이궁수");
            Console.WriteLine($"hp: {hp}/{maxhp}");
            Console.WriteLine($"공격력: {attack}");
            Console.WriteLine($"화살: {arrow}");
            Console.WriteLine($"이동속도: {speed}");
        }
    }
    public class Warrior : Character
    {
        public int defense;
        public int attack;
        public Warrior(string _name) : base(_name, 200, 5)
        {
            defense = 50;
            attack = 80;
        }
        public override void Job()
        {
            Console.WriteLine($"[{name}] 이궁수");
            Console.WriteLine($"hp: {hp}/{maxhp}");
            Console.WriteLine($"공격력: {attack}");
            Console.WriteLine($"방어력: {defense}");
            Console.WriteLine($"이동속도: {speed}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Character> list = new List<Character>();
            list.Add(new Mage("마법사"));
            list.Add(new Archer("궁수"));
            list.Add(new Warrior("전사"));


            foreach (Character m in list)
            {
                m.Job();
            }

        }
    }
}
