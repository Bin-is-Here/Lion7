using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            for (int i = 0; i < 5; i++) // for (초기화; 조건식; 증감식)
            {
                Console.WriteLine(i);
            }

            // for문 활용 예제
            //=== 몬스터 웨이브 시작 ===
            //👹 고블린 #1 생성!
            //👹 고블린 #2 생성!
            //👹 고블린 #3 생성!
            //👹 고블린 #4 생성!
            //👹 고블린 #5 생성!
            //총 5마리 생성 완료!

            int monsterCount = 5;

            Console.WriteLine("=== 몬스터 웨이브 시작 ===");
            for (int i = 0; i < monsterCount; i++)
            {
                Console.WriteLine($"👹 고블린 #{i + 1} 생성!");
            }
            Console.WriteLine($"총 {monsterCount}마리 생성 완료!");



            Console.WriteLine("\n=== 게임 시작 카운트다운 ===");
            int countNum = 5;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{countNum}...");
                countNum--;
            }
            Console.WriteLine("게임 시작\n");

            // for (; ; )
            // {
            //    무한 반복 루프
            // }

            // 랜덤함수
            // : 게임에서 매우 중요한 기능
            Random random = new Random();

            // 주요 메서드
            int number1 = random.Next();          // 0 ~ int.MaxValue
            int number2 = random.Next(10);        // 0 ~ 9
            int number3 = random.Next(1, 7);      // 1 ~ 6 ★★★중요
            double number4 = random.NextDouble(); // 0.0 ~ 1.0

            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);

            Console.WriteLine("\n");

            Console.Clear();

            // 검의 종류
            // 무한의 대검   10%
            // 카타나        20%
            // 엑스칼리버    30%
            // 정기점검      40%

            string sword = "무한의 대검";

            Console.WriteLine("무기 뽑기 20회 진행");

            Random randomNumber = new Random();
            int number = 0;

            int infinityEdge = 0; int katana = 0; int excalibur = 0; int checkSword = 0;

            for (int i = 0; i < 20; i++)
            {
                number = randomNumber.Next(1, 101);

                if (number >= 1 && number <= 10) { sword = "무한의 대검"; }
                else if (number >= 11 && number <= 30) { sword = "카타나"; }
                else if (number >= 31 && number <= 60) { sword = "엑스칼리버"; }
                else if (number >= 61 && number <= 100) { sword = "정기점검"; } 

                Console.WriteLine($"{number} {sword} 획득!");
                Thread.Sleep(500);

                switch (sword)
                {
                    case "무한의 대검":
                        infinityEdge++; break;
                    case "카타나":
                        katana++; break;
                    case "엑스칼리버":
                        excalibur++; break;
                    case "정기점검":
                        checkSword++; break;
                }

            }

            Console.WriteLine("=== 뽑기 결과 =================");
            Console.WriteLine($"무한의 대검: {infinityEdge}회, 카타나: {katana}회, 엑스칼리버: {excalibur}회, 정기점검: {checkSword}회");


        }
    }
}
