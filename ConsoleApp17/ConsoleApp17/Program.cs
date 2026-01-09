using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // int i = 0;

            // while문 : 조건식이 true인 동안 계속 반복
            //while (true)
            //{

            //    Console.WriteLine("무한루프");
            //    i++;

            //}

            // 예제: 10부터 1까지 카운트다운
            Console.WriteLine("\n=== 예제: 카운트다운 ===");
            int countdown = 10;

            while (0 < countdown)
            {
                Console.WriteLine(countdown);
                countdown--;
            }

            // 예제3: 합계 구하기(1,2,3,4,5)
            int sum = 0;
            int j = 1;
            while (j <= 5)
            {
                sum = sum + j;
                j++;
                Console.WriteLine(sum);
            }

            // 예제4: 특정 값까지 반복
            Console.WriteLine("\n=== 목표 달성하기 ===");
            int coins = 0;
            int target = 50;
            int day = 0;

            while (coins < target)
            {
                day++;
                coins += 10;
                Console.WriteLine($"{day}일차 : 코인 {coins}개");
            }
            Console.WriteLine($"목표 달성! {day}일 걸렸습니다.");



            // do-while문

            int x = 5;
            do
            {
                Console.WriteLine("최소 한 번 실행됩니다.");
                x--;

            } while (x > 0); // ; 필수. 조건이 아래서 들어가기 때문에 do 영역이 먼저 실행이 되고 조건문이 발동(최소 1번은 발동)


            // do-while 예제

            string choice;
            int totalPrice = 0;

            do
            {
                // 메뉴 출력
                Console.Clear();
                Console.WriteLine("\n메뉴판");
                Console.WriteLine("1. 짜장면 - 5,000원");
                Console.WriteLine("2. 짬뽕 - 6,000원");
                Console.WriteLine("3. 탕수육 - 15,000원");
                Console.WriteLine("4. 볶음밥 - 7,000원");
                Console.WriteLine("0. 주문 완료");
                Console.WriteLine($"현재 주문 금액: {totalPrice:N0}원");
                Console.WriteLine("===========================");
                Console.Write("메뉴 번호를 선택하세요: ");

                choice = Console.ReadLine();

                // 메뉴 선택 처리
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("짜장면 추가! (+5,000원)");
                        totalPrice += 5000;
                        break;
                    case "2":
                        Console.WriteLine("짬뽕 추가! (+6,000원)");
                        totalPrice += 6000;
                        break;
                    case "3":
                        Console.WriteLine("탕수육 추가! (+15,000원)");
                        totalPrice += 15000;
                        break;
                    case "4":
                        Console.WriteLine("볶음밥 추가! (+7,000원)");
                        totalPrice += 7000;
                        break;
                    default:
                        Console.WriteLine("주문을 완료했습니다.");
                        break;
                }


            } while (choice != "0"); // 0을 입력할 때까지 반복
            Console.WriteLine($"총 주문 금액: {totalPrice:N0}원");


            // break; : 반복문(혹은 코드) 멈춤
            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine(i);
            } // 출력: 0 1 2 3 4

            // continue : 현재 반복을 건너뛰고 다음 반복으로 넘어감. 코드를 건너뜀
            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                    continue;
                Console.WriteLine(i);
            } // 0 1 2 3 4 6 7 8 9 10

            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0) // 나머지가 0인경우 건너뜀
                {
                    continue;
                }
                Console.WriteLine(i); // 홀수만 출력
            }

            // go to : 프로그램 흐름을 원하는대로 바꾼다. 특정 구간으로 넘어감. 신중히 사용해야 한다. 정말 필요한게 아니라면 사용하지 않는게 좋음

            int n = 1;
            comeBack:
            if(n <= 5)
            {
                Console.WriteLine(n);
                n++;
                goto comeBack; // 레이블로 이동
            }




        }
    }
}
