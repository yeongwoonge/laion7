using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 증감_연산자
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //a++; // 후위증가
            //Console.WriteLine(a);
            //a--; // 후위감소
            //a--;
            //Console.WriteLine(a);
            //++a; // 전위증가
            //++a;
            //++a;
            //Console.WriteLine(a);
            //--a; // 전위감소
            //--a;
            //--a;
            //--a;
            //Console.WriteLine(a);

            //int a = 10;
            //int result = a++; // 후위증가, int result = a; a = a+1;
            //Console.WriteLine($"a = {a}, result = {result}");

            //a = 10;
            //result = ++a; // 전위증가, int result = a+1; a = a+1;
            //Console.WriteLine($"a = {a}, result = {result}");

            Console.WriteLine("=== 몬스터 처치 ===");
            string entityGoblin = "고블린";
            string entityOrc = "오크";
            string entityDragon = "드래곤";
            int killCount = 0;

            Console.WriteLine($"{entityGoblin} 처치! (킬 카운트: {++killCount})");
            Console.WriteLine($"{entityOrc} 처치! (킬 카운트: {++killCount})");
            Console.WriteLine($"{entityDragon} 처치! (킬 카운트: {++killCount})");
            Console.WriteLine($"총 처치 수: {killCount}마리");

            Console.WriteLine("=== 사격 ===");
            int remainedBullets = 30;
            Console.WriteLine($"발사 ! 남은 총알: {--remainedBullets}발");
            Console.WriteLine($"발사 ! 남은 총알: {--remainedBullets}발");
            Console.WriteLine($"발사 ! 남은 총알: {--remainedBullets}발");

            Console.WriteLine("=== 카운트 다운 ===");
            int countdown = 3;
            Console.WriteLine(countdown--);
            Console.WriteLine(countdown--);
            Console.WriteLine(countdown--);

        }
    }
}
