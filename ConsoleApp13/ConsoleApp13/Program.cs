using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 제어문
            // 1.순차문 : 코드가 위에서 아래로 순서대로 실행된다.

            // 2.조건문(if else문)
            int score = 85;

            if (score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B 학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C 학점");
            }
            else
            {
                Console.WriteLine("F 학점");
            }
            Console.WriteLine("if else문 끝난 후 실행되는 구간");

            // if문만 사용도 가능하다.
            int a = 10;
            if (a == 10) { Console.WriteLine("a가 " + a + "입니다."); } // 코드가 간결할 경우 한줄에 작성할 수 있음
            if (a != 10) Console.WriteLine("a는 " + a + "가 아닙니다."); // 한 줄 작성의 경우 {} 생략이 가능

            else Console.WriteLine("else문도 한 줄 작성의 경우 {} 생략이 가능하다."); // 한 줄 작성의 경우 {} 생략이 가능

            // 현재 체력: 30 / 100
            // 체력이 30보다 낮은 경우
            // ⚠️ 경고: 체력이 위험합니다!
            // 회복 아이템을 사용하세요!
            // 💊 체력이 50 % 이하입니다.

            // ⚔️ 적이 사거리 안에 있습니다!
            // 공격 가능

            Console.WriteLine("\n");

            int playerHP = 30;
            int maxHP = 100;

            int enemyDistance = 3;
            int attackPange = 5;

            if (playerHP == 0)
            {
                Console.WriteLine("💀 게임 오버!");
                Console.WriteLine("부활 지점에서 다시 시작합니다.");
            }
            else
            {
                if (playerHP <= 30)
                {
                    Console.WriteLine("⚠️ 경고: 체력이 위험합니다!");
                    Console.WriteLine("회복 아이템을 사용하세요!");
                }
                if (playerHP <= maxHP * 0.5) Console.WriteLine("💊 체력이 50 % 이하입니다.");

                if (attackPange >= enemyDistance)
                {
                    Console.WriteLine("⚔️ 적이 사거리 안에 있습니다!");
                    Console.WriteLine("공격 가능");
                }
            }


            // 아이템 구매 시스템
            int playerGold = 500;
            int itemPrice = 250;
            string itemName = "강철검";

            Console.WriteLine("=== 상점 ===");
            Console.WriteLine($"아이템: {itemName}");
            Console.WriteLine($"가격: {itemPrice}");
            Console.WriteLine($"소지금: {playerGold}");
            Console.WriteLine();

            if (playerGold >= itemPrice)
            {
                // 구매 가능
                playerGold -= itemPrice;
                Console.WriteLine("구매 성공!");
                Console.WriteLine($"{itemName}을 획득했습니다.");
                Console.WriteLine($"남은 골드: {playerGold}");
            }
            else
            {
                // 구매 불가
                int needGold = itemPrice - playerGold;
                Console.WriteLine("골드가 부족합니다!");
                Console.WriteLine($"필요한 골드: {needGold}골드 더 필요");
            }

            // 점수에 따른 등급 판정
            int gScore = 8500;
            string rank = "브론즈";
            string itemGrade = "일반";
            int gold = 0;

            Console.WriteLine("=== 게임 랭크 시스템 ===");
            Console.Write("점수를 입력하세요: ");
            gScore = int.Parse(Console.ReadLine());

            if (gScore >= 10000)
            {
                rank = "SSS 레전드";
                itemGrade = "전설";
                gold = 10000;
            }
            else if (gScore >= 8000)
            {
                rank = "SS 마스터";
                itemGrade = "영웅";
                gold = 5000;
            }
            else if (gScore >= 6000)
            {
                rank = "S 다이아";
                itemGrade = "희귀";
                gold = 3000;
            }
            else if (gScore >= 4000)
            {
                rank = "A 플레티넘";
                itemGrade = "고급";
                gold = 1500;
            }
            else
            {
                rank = "B 골드";
                itemGrade = "일반";
                gold = 500;
            }
            Console.WriteLine($"등급: {rank}");
            Console.WriteLine($"보상: {itemGrade} 아이템 + 골드 {gold:N0}");






            Console.OutputEncoding = Encoding.UTF8;

            // 캐릭터 상태 판정
            Console.WriteLine("\n=== 캐릭터 상태 ===");
            int health = 50;
            //헬스값을 입력받아서 테스트해보시오.
            Console.Write("현재 체력을 입력하세요: ");
            health = int.Parse(Console.ReadLine());

            if (health >= 80)
            {
                Console.WriteLine("💚 상태: 매우 좋음");
            }
            else if (health >= 60)
            {
                Console.WriteLine("🟢 상태: 좋음");
            }
            else if (health >= 40)
            {
                Console.WriteLine("🟡 상태: 보통");
            }
            else if (health >= 20)
            {
                Console.WriteLine("🟠 상태: 위험");
            }
            else
            {
                Console.WriteLine("🔴 상태: 매우 위험!");
            }


        }
    }
}
