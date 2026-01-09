using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel.Design.Serialization;

namespace 대장장이키우기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            // 대장장이 키우기 게임 만들기

            // 1. 나무 캐기 -> 돈 수급
            // 2. 장비 뽑기
            // 3. 나가기

            // 나무 캐는데 딜레이를 주어 좋은 장비를 착용 시 시간이 짧아지도록 설정
            // 나무를 캐면 질 좋은 나무와 질이 좋지 않은 나무를 따로 획득하여 판매 시 돈 차등 지급

            Random rand = new Random();

            Console.WriteLine(" 대장장이 키우기");

            int playerMoney = 100;
            int input;
            int rnd;
            string equipEx = "F";
            int Delay = 1000;

            switch (equipEx)
            {
                case "F":
                    Delay = 1000;
                    break;
                case "C":
                    Delay = 900;
                    break;
                case "B":
                    Delay = 800;
                    break;
                case "A":
                    Delay = 700;
                    break;
                case "S":
                    Delay = 500;
                    break;
                case "SS":
                    Delay = 200;
                    break;
                case "SSS":
                    Delay = 100;
                    break;

            }


            Thread.Sleep(500);

            while (true)
            {
                Console.Clear(); // 화면 초기화
                Console.WriteLine("1. 나무 캐기");
                Console.WriteLine("2. 장비 뽑기");
                Console.WriteLine("\n0. 게임 종료");
                Console.WriteLine($"\n현재 소지금: {playerMoney:N0}원");
                Console.WriteLine("===================================");
                Console.Write(": ");
                input = int.Parse(Console.ReadLine());

                if (input == 1) // 나무 캐기
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("━━━━━ 나무캐기 ━━━━━");
                        Console.WriteLine("Press Enter Key");
                        Console.WriteLine("");
                        Console.WriteLine("소지금 : " + playerMoney);
                        Console.WriteLine("X: 돌아가기");
                        Console.Write(": ");

                        string inputNumber = Console.ReadLine();


                        if (inputNumber == "x")
                        {
                            Console.WriteLine("뒤로가기");
                            break;
                        }
                        else
                        {
                            for (int i = 0; i < 10; i++)
                            {

                                Console.Write("■■");
                                Thread.Sleep(Delay);
                            }
                            playerMoney += 100;
                        }
                    }
                }
                else if (input == 2) // 장비 뽑기
                {
                    if (playerMoney >= 1000) // 돈이 있는지 확인 후 뽑기
                    {
                        playerMoney -= 1000;

                        for (int i = 0; i <= 10; i++)
                        {
                            rnd = rand.Next(1, 10001);

                            if (rnd == 1) Console.WriteLine("도끼 등급 SSS");
                            else if (rnd >= 2 && rnd <= 6) Console.WriteLine("도끼 등급 SS");
                            else if (rnd >= 7 && rnd <= 17) Console.WriteLine("도끼 등급 S");
                            else if (rnd >= 18 && rnd <= 38) Console.WriteLine("도끼 등급 A");
                            else if (rnd >= 39 && rnd <= 69) Console.WriteLine("도끼 등급 B");
                            else if (rnd >= 39 && rnd <= 69) Console.WriteLine("도끼 등급 C");
                            else Console.WriteLine("도끼 등급 C");
                            Thread.Sleep(500); // 딜레이 0.5초
                        }
                    }
                    else
                    {
                        Console.WriteLine("소지 금액이 부족합니다.");
                        Thread.Sleep(500); // 딜레이 0.5초
                    }
                }
                else if(input == 3) // 인벤토리 확인
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("━━━━━ 인벤토리 ━━━━━");
                        Console.WriteLine("소지금 : " + playerMoney);
                        Console.WriteLine($"착용 도끼 등급: ");
                        Console.WriteLine("X: 돌아가기");
                        Console.Write(": ");

                        string inputNumber = Console.ReadLine();

                        if (inputNumber == "0")
                        {
                            Console.WriteLine("뒤로가기");
                            break;
                        }

                    }

                }
                else if (input == 0)
                {
                    Console.WriteLine("게임을 종료합니다.");
                    Environment.Exit(0);
                }



                //switch (input)
                //{
                //    case 1:
                //        break;
                //    case 1:
                //        break;
                //    case 1:
                //        break;
                //    default:
                //        break;
                //}

            }


        }
    }
}
