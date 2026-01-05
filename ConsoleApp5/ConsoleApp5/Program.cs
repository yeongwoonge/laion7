using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("┌────────────────────────────────────┐");
            //Console.WriteLine("│　　　　　　　　　　　　　　　　　　│");
            //Console.WriteLine("│　　　　　　게임　　시작　　　　　　│");
            //Console.WriteLine("│　　　　　　　　　　　　　　　　　　│");
            //Console.WriteLine("└────────────────────────────────────┘");

            int keys = 4 ;
            string keysMode = $"{keys}B TUNES" ;
            string songName = "Watch Your Step" ;
            string composer = "XeoN";
            string difficulty = "NORMAL ★★★★☆☆☆☆☆☆☆☆☆☆☆" ;

            int scoreBreak = 0;
            int scoreMax90 = 37;
            int scoreBestcombo = 1539;
            int scoreMax100 = 354;
            double accuracy = 98.56;
            string scoreAccuracy = $"{accuracy}%";

            Console.WriteLine($"　　　┌────┐ {keysMode}　　　　　　");
            Console.WriteLine($"　　　│　　│ {songName}　　　　　　");
            Console.WriteLine($"　　　└────┘ {composer}　　　　　　");
            Console.WriteLine($"　　　{difficulty}　　　　　　");

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine($"　　　　　　│\\/\\/\\│　　　　　　");
            Console.WriteLine($"　　　　　　└─────┘　　　　　");
            Console.WriteLine($"　　　　　　 ───── {scoreBreak}　　　　");
            Console.WriteLine($"　　　　　　(      　　　　　　");
            Console.WriteLine($"　　　　{scoreMax100}  ───── {scoreMax90}　　　　");
            Console.WriteLine($"　　　　　　      )　　　　　　");
            Console.WriteLine($"　　　　　　 ───── {scoreAccuracy}　　　　");
            Console.WriteLine($"　　　　　　 {scoreBestcombo}　　　　　　 ");






        }
    }
}
