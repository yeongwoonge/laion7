using System;
namespace Tistory
{
    internal class Program
    {
        public class Parent //부모 클래스
        {
            public void print()
            {
                Console.WriteLine("Parent 클래스의 print 함수입니다.");
            }
        }

        public class Child : Parent //Parent 클래스 상속
        {
            public void print() //메서드 오버라이딩
            {
                Console.WriteLine("Child 클래스에서 재정의한 print 함수입니다.");
            }
        }

        static void Main(string[] args)
        {
            Parent p = new Parent();    //Parent 클래스 객체 p 생성
            Child c = new Child();      //Child 클래스 객체 c 생성

            p.print();  //p 객체의 print() 메서드 호출
            c.print();  //c 객체의 print() 메서드 호출
        }
    }
}