using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 10, y = 20, z = 30;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine("커지는 숫자 {0:D3},{1:D3},{2:D3}",x,y,z);

            //int age = 20;
            ////Console.WriteLine("나이: {0}",age);
            //string name = "철수";
            ////Console.WriteLine("나이: {0}, 이름: {1}",age,name);

            //Console.WriteLine($"나이 : {age}");
            int age = 20;
            string message = $"내 나이는 {age}살이야";
            Console.WriteLine(message);

            int posX = 0, posY = 50, posZ = 100;

            Console.WriteLine("X 좌표 : "+posX+", Y 좌표 : "+posY+", Z 좌표 : "+posZ);
            Console.WriteLine("X 좌표 : {0}, Y 좌표 : {1}, Z 좌표 : {2}",posX,posY,posZ);
            Console.WriteLine($"X 좌표 : {posX}, Y 좌표 : {posY}, Z 좌표 : {posZ}");

            int red = 255, green = 128, blue = 0;
            Console.WriteLine("RED : " + red + ", GREEN : " + green + ", BLUE : " + blue);
            Console.WriteLine("RED : {0}, GREEN : {1}, BLUE : {2}", red, green, blue);
            Console.WriteLine($"RED : {red}, GREEN : {green}, BLUE : {blue}");
           

        }
    }
}
