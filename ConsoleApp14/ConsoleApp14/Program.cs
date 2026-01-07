using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // 조건문 Switch문
            int day = 3;

            switch (day)
            {
                case 1:
                    Console.WriteLine("월요일");
                    break;
                case 2:
                    Console.WriteLine("화요일");
                    break;
                case 3:
                    Console.WriteLine("수요일");
                    break;
                default:
                    Console.WriteLine("유효하지 않은 요일");
                    break;
            }

            switch (day) // case 몰아쓰는것도 가능(case내 아무 내용이 없을 때만 가능)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("수요일");
                    break;
                default:
                    Console.WriteLine("유효하지 않은 요일");
                    break;

            }

            // Switch문 예제
            // 캐릭터 선택화면을 switch문으로 만드시요

            Console.WriteLine("캐릭터를 선택하세요");
            Console.WriteLine("1.전사");
            Console.WriteLine("2.마법사");
            Console.WriteLine("3.궁수");
            Console.WriteLine("4.도적");
            Console.Write(": ");
            int selectNumber = int.Parse(Console.ReadLine());
            string selectJob = "none";
            string charStat = "none";
            string charWeapon = "none";
            string charAbility = "none";

            switch (selectNumber)
            {
                case 1:
                    selectJob = "전사";
                    charAbility = "높은 체력과 방어력";
                    charWeapon = "검, 도끼";
                    charStat = "HP + 50, 공격력 + 10";
                    break;
                case 2:
                    selectJob = "마법사";
                    charAbility = "강력한 마법 공격";
                    charWeapon = "지팡이, 마법서";
                    charStat = "마나 + 100, 마법력 + 20";
                    break;
                case 3:
                    selectJob = "궁수";
                    charAbility = "원거리 공격 특화";
                    charWeapon = "활, 석궁";
                    charStat = "민첩 + 15, 크리티컬 + 10%";
                    break;
                case 4:
                    selectJob = "도적";
                    charAbility = "빠른 속도와 치명타";
                    charWeapon = "단검, 쌍검";
                    charStat = "민첩 + 20, 회피율 +15%";
                    break;
                default:
                    Console.WriteLine("잘못 선택하셨습니다.");
                    break;
            }

            Console.WriteLine($"직업: {selectJob}");
            Console.WriteLine($"특성: {charAbility}");
            Console.WriteLine($"주 무기: {charWeapon}");
            Console.WriteLine($"스탯: {charStat}");


            // 아이템 타입별 설명
            Console.WriteLine("\n=== 아이템 정보 ===");
            string itemType = "weapon";

            switch (itemType)
            {
                case "weapon":
                    Console.WriteLine("🗡️ 무기 - 공격력 증가");
                    break;
                case "armor":
                    Console.WriteLine("🛡️ 방어구 - 방어력 증가");
                    break;
                case "potion":
                    Console.WriteLine("🧪 물약 - 체력/마나 회복");
                    break;
                case "accessory":
                    Console.WriteLine("💍 장신구 - 특수 능력 부여");
                    break;
                default:
                    Console.WriteLine("❓ 알 수 없는 아이템");
                    break;
            }

            // 요일별 이벤트
            Console.WriteLine("\n=== 오늘의 이벤트 ===");
            int dayOfWeek = 3;  // 0:일, 1:월, 2:화, 3:수, 4:목, 5:금, 6:토

            switch (dayOfWeek)
            {
                case 0:
                    Console.WriteLine("🎁 일요일: 경험치 2배");
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("📅 평일: 일반 보상");
                    break;
                case 5:
                    Console.WriteLine("💰 금요일: 골드 2배");
                    break;
                case 6:
                    Console.WriteLine("🎲 토요일: 아이템 드롭률 2배");
                    break;
                default:
                    Console.WriteLine("잘못된 요일");
                    break;
            }



        }
    }
}
