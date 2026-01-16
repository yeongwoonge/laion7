using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 상속자들
{
    public class Character
    {
        public virtual void Render()
        {
            Console.WriteLine("캐릭터");
        }
    }
    public class Warrior : Character
    {
        public override void Render()
        {
            Console.WriteLine("전사");
        }
    }
    public class Mage : Character
    {
        public override void Render()
        {
            Console.WriteLine("마법사");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Character> characters = new List<Character>();
            Character character = new Mage();
            character.Render();
        }
    }
}
