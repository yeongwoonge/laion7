using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace 클래스예제2
{
    class Monster
    {
        private string name="X";
        private int lv=1;
        private int hp=1;
        private int dmg=1;
        private int def=1;
        private int exp=1;
        public Monster(string _name, int _lv)
        {
            name = _name;
            lv = _lv;
            hp = 50 * lv;
            dmg = 10 * lv;
            def = 5 * lv; 
            exp = 10 * lv;
        }
        public void ShowStats()
        {
            Console.WriteLine($"👾 {name} (Lv.{lv})");
            Console.WriteLine($"   HP: {hp}");
            Console.WriteLine($"   공격력: {dmg}");
            Console.WriteLine($"   방어력: {def}");
            Console.WriteLine($"   경험치: {exp}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Monster> monList = new List<Monster>()
            {
                new Monster("슬라임",1),
                new Monster("고블린",4),
                new Monster("오크",10),
                new Monster("트롤",15),
                new Monster("드래곤",30),
            };
            //foreach (Monster m in monList)
            //{
            //    m.ShowStats();
            //}
            Random rand = new Random();
            Console.WriteLine("==== 몬스터 발견!!!!! ====");
            monList[rand.Next(0, monList.Count)].ShowStats();
        }
        
    }
}
