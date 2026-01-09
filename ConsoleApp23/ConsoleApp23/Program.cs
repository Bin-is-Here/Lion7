using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // 다차원배열
            // 방법 1: 크기만 지정
            int[,] grid = new int[3, 4];  // 3행 4열

            // 방법 2: 선언과 동시에 초기화
            int[,] numbers = new int[2, 3] // 3개짜리가 2개.
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            // 방법 3: new 생략 (간단한 초기화)
            int[,] scores =
            {
                { 90, 85, 88 },
                { 92, 78, 95 },
                { 87, 91, 84 }
            };

            // 배열 크기 확인
            int[,] array = new int[3, 4];

            // 전체 요소 개수
            int totalElements = array.Length; // 12 (3 x 4)

            // 특정 차원의 길이
            int rows = array.GetLength(0); // 3 (행의 개수)
            int cols = array.GetLength(1); // 4 (열의 개수)

            // Rank: 배열의 차원 수
            int dimensions = array.Rank; // 2



            // 좌석 배치도
            Console.WriteLine("=== 좌석 배치도 ===");

            string[,] seatNumber = new string[3, 5]
            {
                {"A1", "A2", "A3", "A4", "A5"},
                {"B1", "B2", "B3", "B4", "B5"},
                {"C1", "C2", "C3", "C4", "C5"}
            };
            for (int i = 0; i < seatNumber.GetLength(0); i++)
            {
                for (int j = 0; j < seatNumber.GetLength(1); j++)
                {
                    Console.Write($"[{seatNumber[i, j]}]");
                }
                Console.WriteLine();
            }

            // 첫 번째 좌석 : A1
            // 중앙 좌석 : B3
            // 마지막 좌석 : C5

            Console.WriteLine($"[{seatNumber[0, 0]}]");
            Console.WriteLine($"[{seatNumber[seatNumber.GetLength(0) / 2, seatNumber.GetLength(1) / 2]}]");
            Console.WriteLine($"[{seatNumber[seatNumber.GetLength(0) - 1, seatNumber.GetLength(1) - 1]}]");


            // 맵 구상
            // 2D 게임 맵
            int[,] map = new int[5, 5]
            {
                { 0, 0, 1, 0, 0 },
                { 0, 2, 1, 0, 3 },
                { 0, 0, 1, 0, 0 },
                { 1, 1, 1, 0, 0 },
                { 0, 0, 0, 0, 9 }
            };

            Console.WriteLine("== 던전 맵 == ");
            Console.WriteLine("0: 통로, 1: 벽, 2: 몬스터, 3: 보물, 9: 출구\n");

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    switch (map[i, j])
                    {
                        case 0:
                            Console.Write("⬜ ");
                            break;
                        case 1:
                            Console.Write("⬛ ");
                            break;
                        case 2:
                            Console.Write("👹 ");
                            break;
                        case 3:
                            Console.Write("💎 ");
                            break;
                        case 9:
                            Console.Write("🚪 ");
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine();
            }

            // 성적표 배열
            string[] title = { "국어", "영어", "수학", "과학" };
            string[] name = { "김철수", "이영희", "박민수" };
            int[,] point = new int[3, 4]
            {
                { 85, 90, 88, 92, },
                { 78, 85, 90, 87, },
                { 92, 88, 95, 90, }
            };

            Console.WriteLine("=== 성적표 ===");
            Console.Write("이름  ");
            for (int i = 0; i < title.Length; i++)
            {
                Console.Write($"{title[i]} ");
            }
            Console.WriteLine("평균");
            Console.WriteLine("--------------------------------------------");

            for (int i = 0; i < point.GetLength(0); i++)
            {
                double sumPoint = 0;
                Console.Write($"{name[i]} ");
                for (int j = 0; j < point.GetLength(1); j++)
                {
                    Console.Write($"{point[i, j]}   ");
                    sumPoint += (point[i, j]);
                }
                double studentAvgPoint = (double)sumPoint / point.GetLength(1);
                Console.Write($"{studentAvgPoint:F1}");

                Console.WriteLine();
            }

            Console.WriteLine("===과목별 평균===");
            for(int i = 0;i < point.GetLength(1); i++)
            {
                int sum = 0;
                for(int j = 0;j < point.GetLength(0); j++)
                {
                    sum += point[j, i];
                }
                double avg = (double)sum / point.GetLength(0);
                Console.WriteLine($"{title[i]}: {avg:F1}점");
            }




        }
    }
}
