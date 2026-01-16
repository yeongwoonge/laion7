using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 상속자들예제
{
    public class Animal
    {
        protected string name;
        public Animal(string _name)
        {
            name = _name;            
        }
        public void Sleep()
        {
            Console.WriteLine($"{name}가 잠을 잡니다.");
        }
        public virtual void ShowTalent() { }
    }
    public class Panda : Animal
    {
        public Panda(string _name) : base(_name)
        {
            name = _name;
        }
        public override void ShowTalent()
        {
            Console.WriteLine("데구르르... 그냥 구르기");
        }
    }
    public class Lion : Animal
    {
        public Lion(string _name) : base(_name)
        {
            name = _name;
        }
        public override void ShowTalent()
        {
            Console.WriteLine("사자후를 내뿜습니다. 쿠왕!");
        }
    }
    public class Monkey : Animal
    {
        public Monkey(string _name) : base(_name)
        {
            name = _name;
        }
        public override void ShowTalent()
        {
            Console.WriteLine("우끼끼~ 나무를 탑니다.");
        }
        public void SpecialTalent()
        {
            Console.WriteLine("동전 던지면서 레전드 묘기를 부립니다");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===동물농장===");
            List<Animal> animalList = new List<Animal>();
            animalList.Add(new Lion("사자"));
            animalList.Add(new Monkey("몽키"));
            animalList.Add(new Panda("판다"));
            foreach(Animal animal in animalList)
            {
                animal.Sleep();
                animal.ShowTalent();
                Monkey monkey = animal as Monkey;
                if (monkey != null) monkey.SpecialTalent();
            }
        }
    }
}
