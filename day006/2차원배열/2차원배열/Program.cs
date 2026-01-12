using System;

namespace _2차원배열
{
    class result
    {
        public string Name;
        public int Kor;
        public int Eng;
        public int Mat;
        public int Sci;
        public result(string name, int kor, int eng, int mat, int sci)
        {
            Name = name;
            Kor = kor;
            Eng = eng;
            Mat = mat;
            Sci = sci;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            // 방법 1: 크기만 지정
            //int[,] grid = new int[3, 4];  // 3행 4열

            //// 방법 2: 선언과 동시에 초기화
            //int[,] numbers = new int[2, 3]
            //{
            //    { 1, 2, 3 },
            //    { 4, 5, 6 }
            //};

            //// 방법 3: new 생략 (간단한 초기화)
            //int[,] scores =
            //{
            //    { 90, 85, 88 },
            //    { 92, 78, 95 },
            //    { 87, 91, 84 }
            //};
            //Console.WriteLine(scores[1,1]);
            //int[,] array = new int[3, 4];

            //// 전체 요소 개수
            //int totalElements = array.Length;  // 12 (3 x 4)

            //// 특정 차원의 길이
            //int rows = array.GetLength(0);     // 3 (행 개수)
            //int cols = array.GetLength(1);     // 4 (열 개수)

            //// Rank: 배열의 차원 수
            //int dimensions = array.Rank;       // 2


            //string[,] seat = new string[3, 3];
            //string[] seatAlpha= { "A", "B", "C" };
            //string[] seatNum = { "1", "2", "3" };
            //seat[1, 1] = "예약됨";
            //for (int i= 0; i < seat.GetLength(0); i++)
            //{

            //    for (int j = 0; j < seat.GetLength(1); j++)
            //    {
            //        seat[i, j] = seatAlpha[i] + seatNum[j];
            //        Console.Write($"[{seat[i,j]}]");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"첫 번재 좌석 : {seat[0,0]}");
            //Console.WriteLine($"중앙 좌석 : {seat[(seat.GetLength(0) - 1)/2, (seat.GetLength(1) - 1)/2]}");
            //Console.WriteLine($"마지막 좌석 : {seat[seat.GetLength(0)-1,seat.GetLength(1)-1]}");

            //// 배열을 이용한 2d 게임맵
            //int[,] map = new int[5, 5]
            //{
            //    {0,0,1,0,0},
            //    {0,2,1,0,3},
            //    {0,0,1,0,0},
            //    {0,1,1,0,0},
            //    {0,0,0,0,9},
            //};
            //Console.WriteLine("==던전맵==");
            //Console.WriteLine("0:통로 1:벽 2:몬스터 3:보물 9:출구\n");
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //for (int i = 0; i < map.GetLength(0); i++)
            //{
            //    for(int j = 0; j < map.GetLength(1);j++)
            //    {
            //        switch (map[j, i])
            //        {
            //            case 0:
            //                Console.Write("○ ");
            //                break;
            //            case 1:
            //                Console.Write("● ");
            //                break;
            //            case 2:
            //                Console.Write("👹 ");
            //                break;
            //            case 3:
            //                Console.Write("💰 ");
            //                break;
            //            case 9:
            //                Console.Write("🚪 ");
            //                break;
            //                default:
            //                Console.Write("?? ");
            //                break;
            //        }

            //    }
            //    Console.WriteLine("");
            //}
            //string[] subjects = { "국어", "영어", "수학", "과학" };

            //result[] arr = new result[3];
            //arr[0] = new result("김철수", 85, 90, 88, 92);
            //arr[1] = new result("이영희", 78, 85, 90, 87);
            //arr[2] = new result("박민수", 92, 88, 95, 90);
            //float average = 0f; 
            //Console.WriteLine("== 성적표 ===");

            //Console.Write($"이름＃　");
            //for (int i=0;i< subjects.Length; i++) Console.Write($"{subjects[i]}　");
            //Console.WriteLine("평균");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    result student = arr[i];
            //    average = (float)(student.Kor + student.Eng + student.Mat + student.Sci) / 4;
            //    Console.Write($"{student.Name}　{student.Kor}　　{student.Eng}　　{student.Mat}　　{student.Sci}　　{average}");
            //    Console.WriteLine();
            //}
            //Console.WriteLine("== 과목별 평균 ==");
            //float korTotal = 0f;
            //float engTotal = 0f;
            //float matTotal = 0f;
            //float sciTotal = 0f;
            //for (int i=0; i < arr.Length; i++)
            //{
            //    result student = arr[i];
            //    korTotal = korTotal + student.Kor;
            //    engTotal = engTotal + student.Eng;
            //    matTotal = matTotal + student.Mat; 
            //    sciTotal = sciTotal + student.Sci;
            //}
            //Console.WriteLine($"국어 평균 : {korTotal/3:f1}");
            //Console.WriteLine($"영어 평균 : {engTotal/3:f1}");
            //Console.WriteLine($"수학 평균 : {matTotal/3:f1}");
            //Console.WriteLine($"과학 평균 : {sciTotal/3:f1}");
            //
            string[][] raid = new string[3][];
            raid[0] = new string[] { "전사", "힐러", "마법사", "궁수" };
            raid[1] = new string[] { "도적" , "전사" , "힐러"};
            raid[2] = new string[] { "마법사", "궁수", "힐러", "주술사" ,"탱커"};
            Console.WriteLine("===레이드파티구성===");
            for(int i = 0; i < raid.Length; i++)
            {
                Console.WriteLine($"파티 {i+1} {raid[i].Length}명");
                for (int j = 0; j < raid[i].Length; j++)
                {
                    Console.WriteLine($" - {raid[i][j]}");
                }
            }
            


        }
    }
}
