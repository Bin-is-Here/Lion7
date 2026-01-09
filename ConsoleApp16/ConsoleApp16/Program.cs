using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 연습 예제 1
            // 오늘의 온도를 입력받아 적절한 옷차림을 추천하는 프로그램을 작성하세요.
            // 요구사항
            // 온도 30도 이상 : "매우 더워요! 반팔과 반바지를 입으세요."
            // 온도 20도 이상 30도 미만 : "적당해요! 긴팔과 티셔츠를 입으세요."
            // 온도 10도 이상 20도 미만 : "쌀쌀해요! 가디건이나 자켓을 챙기세요."
            // 온도 0도 이상 10도 미만 : "추워요! 코트를 입으세요."
            // 온도 0도 미만 : "매우 추워요! 패딩과 목도리가 필요해요."

            // if else문 사용

            Console.Write("현재 기온을 입력하세요: ");
            int temperature = int.Parse(Console.ReadLine());

            if (temperature >= 30)
            {
                Console.WriteLine("매우 더워요! 반팔과 반바지를 입으세요.");
            }
            else if (temperature >= 20 && temperature < 30)
            {
                Console.WriteLine("적당해요! 긴팔 티셔츠를 입으세요.");
            }
            else if (temperature >= 10 && temperature < 20)
            {
                Console.WriteLine("쌀쌀해요! 가디건이나 자켓을 챙기세요.");
            }
            else if (temperature >= 0 && temperature < 10)
            {
                Console.WriteLine("추워요! 코트를 입으세요.");
            }
            else
            {
                Console.WriteLine("매우 추워요! 패딩과 목도리가 필요해요.");
            }


            // 연습 예제 2
            // 사용자가 선택한 번호에 따라 게임 캐릭터의 직업 정보를 출력하는 프로그램을 작성하세요.

            // switch문 사용

            // 1번. 전사 : "높은 체력과 방어력 / 시작 스탯: HP +50, 공격력 + 10"
            // 1번. 마법사 : "강력한 마법 공격 / 시작 스탯: 마나 +100, 마법력 +20"
            // 1번. 궁수 : "원거리 공격 특화 / 시작 스탯: 민첩 +15, 크리티컬 +10%"
            // 1번. 도적 : "빠른 속도와 회피 / 시작 스탯: 민첩 +20, 회피율 +15%"
            // 그 외: "잘못된 선택입니다. 1 ~ 4 중에서 선택해주세요."

            string[] jobList = { "전사", "마법사", "궁수", "도적" };
            string jobExplain = "";
            string jobStat = "";

            Console.WriteLine("==== 직업 ====");
            Console.WriteLine($"1.{jobList[0]} 2.{jobList[1]} 3.{jobList[2]} 4.{jobList[3]}");
            Console.Write("해당 직업의 번호를 입력하세요: ");
            int jobNumber = int.Parse(Console.ReadLine());

            switch (jobNumber)
            {
                case 1:
                    jobExplain = "높은 체력과 방어력";
                    jobStat = "HP +50, 공격력 + 10";
                    break;
                case 2:
                    jobExplain = "강력한 마법 공격";
                    jobStat = "마나 +100, 마법력 +20";
                    break;
                case 3:
                    jobExplain = "원거리 공격 특화";
                    jobStat = "민첩 +15, 크리티컬 +10%";
                    break;
                case 4:
                    jobExplain = "빠른 속도와 회피";
                    jobStat = "민첩 +20, 회피율 +15%";
                    break;
                default:
                    Console.WriteLine("잘못된 선택입니다. 1 ~ 4 중에서 선택해주세요.");
                    break;

            }

            Console.WriteLine("=== 캐릭터 생성 ===");
            Console.WriteLine($"{jobList[jobNumber - 1]} - {jobExplain}");
            Console.WriteLine($"시작 스탯: {jobStat}");



        }
    }
}
