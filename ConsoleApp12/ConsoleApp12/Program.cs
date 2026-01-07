using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 삼항연산자 -> (조건) ? True : False
            int a = 10, b = 20;
            int max = (a > b) ? a : b; // ?왼쪽의 값이 True면  : 좌측, False면 : 우측의 값을 출력
            Console.WriteLine(max);

            int score = 85;
            string result = (score >= 60) ? "합격" : "불합격";

            Console.WriteLine("=== 시험 결과 ===");
            Console.WriteLine($"점수: {score}");
            Console.WriteLine($"결과: {result}");

            Console.WriteLine("\n");

            // 예제. 레벨에 따른 승급
            // 레벨: 45
            // 50보다 크면 고급, 50~30 사이면 중급, 그 이하는 초급

            int playerLevel = 45;
            int grade1 = 50;
            int grade2 = 30;

            string grade = (playerLevel > grade1) ? "고급" :
                           (playerLevel >= grade2) ? "중급" : "초급";

            Console.WriteLine("=== 플레이어 등급 ===");
            Console.WriteLine($"레벨: {playerLevel}");
            Console.WriteLine($"등급: {grade}");

            Console.WriteLine("\n");

            // health = 30;
            // maxHealth = 100;
            // healthStatus 70 안전 70~30 주의 30이하 위험

            int health = 30;
            int maxHealth = 100;
            int healthPer = health * maxHealth / 100;

            int safe = 70;
            int danger = 30;

            string status = (health > safe) ? "안전" :
                            (health >= danger) ? "주의" : "위험";

            Console.WriteLine("=== 건강 상태 ===");
            Console.WriteLine($"체력: {healthPer}%");
            Console.WriteLine($"상태: {status}");


            int exHealth = 30;
            int exMaxHealth = 100;
            string exHealthStatus = (exHealth >= exMaxHealth * 0.7) ? "안전" :
                                   (exHealth >= exMaxHealth * 0.3) ? "주의" : "위험"; // 0.7, 0.3을 곱해서 % 추출

            Console.WriteLine("\n=== 체력 상태 ===");
            Console.WriteLine($"현재 체력: {exHealth}/{exMaxHealth}");
            Console.WriteLine($"상태 : {exHealthStatus}\n");

            // 연산자 우선순위
            // 1. 곱셈이 덧셈보다 우선
            int result1 = 10 + 2 * 5;
            Console.WriteLine(result1); // 출력 20
            // 2. 괄호로 우선순위 변경
            int adjustedResult = (10 + 2) * 5;
            Console.WriteLine(adjustedResult); // 출력 60



            // 예제 2: 데미지 계산
            int baseDamage = 50;
            int bonusDamage = 20;
            double criticalMultiplier = 1.5;

            // 잘못된 계산
            double damage1 = baseDamage + bonusDamage * criticalMultiplier;
            // 올바른 계산
            double damage2 = (baseDamage + bonusDamage) * criticalMultiplier;

            Console.WriteLine("\n=== 크리티컬 데미지 계산 ===");
            Console.WriteLine($"기본 데미지: {baseDamage}");
            Console.WriteLine($"보너스 데미지: {bonusDamage}");
            Console.WriteLine($"크리티컬 배율: {criticalMultiplier}배");
            Console.WriteLine($"잘못된 계산: {damage1}");  // 80.0
            Console.WriteLine($"올바른 계산: {damage2}");  // 105.0

        }
    }
}
