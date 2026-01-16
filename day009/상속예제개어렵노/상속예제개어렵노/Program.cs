using System;
using System.Collections.Generic;

namespace 상속예제
{
    public class Item
    {
        public string Name;
        public double Price;
        public Item(string _name, double _price)
        {
            Name = _name;
            Price = _price;
        }

        public virtual double GetFinalPrice()
        {
            return Price;
        }
    }

    public class Weapon : Item
    {
        public Weapon() : base("엑스칼리버", 1000) { }

        public override double GetFinalPrice()
        {
           return Price * 0.9; 
        }
    }

    public class Armor : Item
    {
        public Armor() : base("강철갑옷", 2000) { }

        public override double GetFinalPrice()
        {
            return Price * 0.8;
        }
    }

    public class Potion : Item
    {
        public Potion() : base("빨간물약", 500) { }

        public override double GetFinalPrice()
        {
            return Price * 0.5;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Item> shopItemList = new List<Item>();
            shopItemList.Add(new Weapon());
            shopItemList.Add(new Armor());
            shopItemList.Add(new Potion());

            Console.WriteLine("=== 영수증 ===");
            foreach (Item item in shopItemList)
            {
                Console.WriteLine($"[{item.Name}] 판매가: {item.GetFinalPrice()}원 (원가 {item.Price})");
            }
            double total = 0;
            foreach (Item item in shopItemList)
            {
                total += item.GetFinalPrice();
            }
            Console.WriteLine($"----------------\n총 합계 : {total}원");
        }
    }
}