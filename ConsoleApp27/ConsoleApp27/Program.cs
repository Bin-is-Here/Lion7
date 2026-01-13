using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {

        static void Functions() // 함수 선언
        {
            Console.WriteLine("It is Function in C#!\n");
        }

        // 1단계 기본 함수 =============================================================================================
        static void SayHello()
        {
            Console.WriteLine("안녕하세요, 용사님");
            Console.WriteLine("모험을 시작합니다.");
        }

        static void GameStart() // 함수 정의: 게임 시작 화면 출력
        {
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║         ⚔ RPG 게임 시작 ⚔         ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
        }

        static void PrintSeparator() // 함수 정의: 구분선 출력
        {
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
        }


        // 2단계 매개변수가 있는 함수 ======================================================================================
        static void Attack(int att)
        {
            Console.WriteLine("공격력 전달받음: " + att);
        }

        // 매개변수 여러 개 넘기기
        static void Attack2(int att, int def)
        {
            Console.WriteLine("공격력 전달받음: " + att);
            Console.WriteLine("방여력 전달받음: " + def);
        }

        // 플레이어 이름 함수로 만들기
        static void PlayerName(string name, int att, int def, int dex, int luck)
        {
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"공격력: {att}");
            Console.WriteLine($"방어력: {def}");
            Console.WriteLine($"민첩: {dex}");
            Console.WriteLine($"운: {luck}");
        }

        // 2단계 활용
        static void GreetPlayer(string playerName)
        {
            Console.WriteLine($"환영합니다. {playerName}님!");
        }

        static void PlayerInfo(string job, int level)
        {
            Console.WriteLine($"직업: {job}");
            Console.WriteLine($"레벨: {level}");
        }

        static void DrawHealthBar(int current, int max, int barLength)
        {
            Console.Write("HP [");

            int filledLength = (int)((double)current / max * barLength);
            for (int i = 0; i < barLength; i++)
            {
                if (i < filledLength) Console.Write("■");
                else Console.Write("□");
            }
            Console.WriteLine($"] {current}/{max}");
        }

        static void AttackDamage(string attacker, string target, int damage) // 데미지 계산 출력
        {
            Console.WriteLine($"{attacker}의 공격");
            Console.WriteLine($"     {target}에게 {damage} 데미지!");
        }

        // 3단계 반환값이 있는 함수 ========================================================================================

        // 정수 반환
        static int GetNumber()
        {
            return 42;
        }
        // 문자열 반환
        static string GetPlayerName(string name)
        {
            return name;
        }
        static string ConnectMessage(string name)
        {
            return "'" + name + "'님이 접속하셨습니다.";
        }



        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //🗺 C# 메모리 구조 (완전판)
            //C#의 메모리는 크게 4개 영역으로 나뉩니다:

            //영역 설명 수명 크기
            //Stack 지역 변수, 매개변수 함수 종료 시 작음(~1MB)
            //Heap 동적 객체(new) GC가 정리 큼(~GB)
            //Static 정적 변수, 상수 프로그램 종료 시 중간
            //Code 프로그램 코드(IL) 프로그램 종료 시 중간


            //📖 Static 영역이란?
            //Static 영역은 프로그램 시작 시 할당되고, 프로그램 종료까지 유지되는 메모리 영역입니다.
            //특징
            //✅ 프로그램 시작 시 한 번만 할당
            //✅ 모든 인스턴스가 공유
            //✅ 프로그램 종료 시 해제
            //❌ 가비지 컬렉션 대상 아님

            //┌─── Code 영역 ───────────────┐
            //│ Program.Main() 코드         │
            //│ Player 클래스 정의           │
            //└─────────────────────────────┘

            //┌─── Static 영역 ─────────────┐
            //│ Player.PlayerCount = 0      │ ← 프로그램 전체에서 공유
            //└─────────────────────────────┘

            //┌─── Stack ───────────────────┐
            //│ localVar = 10               │
            //│ p1 = 0x1000 ────────┐       │
            //│ p2 = 0x2000 ────┐   │       │
            //└─────────────────┼───┼───────┘
            //                  │   │
            //┌─── Heap ────────▼───▼───────┐
            //│ 0x1000: Player              │
            //│ Name = null                 │
            //│ HP = 0                      │
            //│                             │
            //│ 0x2000: Player              │
            //│ Name = null                 │
            //│ HP = 0                      │
            //└─────────────────────────────┘


            // 함수(Function) 또는 메서드(Method)는 특정 작업을 수행하는 코드 블록이다.
            // 함수는 자판기와 같다 -> 버튼 누르면 (호출), 내부에서 작동하고(실행), 값이 나온다(반환)
            // 특징
            // 재사용성: 같은 코드를 여러 번 작성하지 않고 반복 사용이 가능
            // 가독성: 코드를 의미 있는 단위로 나누어 사용
            // 유지 보수 : 수정이 필요하면 한 곳만 고치면 됨
            // 디버깅: 문제 발생 시 원인 파악이 쉬움

            // 함수 선언은 Main 함수 밖에 선언
            // static 키워드를 사용해주어야 오류가 발생하지 않는다.
            // (Main함수가 static영역에 있어서 static 키워드를 사용해주지 않으면 Main에서 함수를 찾을 수가 없어서 오류 발생.
            // 함수의 기능 위주로 구현을 하면 좋다.(코드의 재사용성을 위해)

            // 기본 문법
            // 반환타입 함수이름(매개변수)
            // {
            //     return 반환값; // 반환 타입이 void가 아닐 경우
            // }

            Functions(); // 함수 호출

            // 1단계
            Console.WriteLine("아래 함수를 호출합니다.");
            SayHello();
            SayHello(); // 함수의 재사용 -> 쉽게 같은 코드를 여러번 사용할 수 있다.

            GameStart();
            PrintSeparator();
            SayHello();

            // 2단계
            Attack(100);
            Attack2(100, 50);

            PrintSeparator();
            PlayerName("Bin", 100, 50, 45, 50);

            // 2단계 활용
            GreetPlayer("Hellovin");
            Console.WriteLine();

            PlayerInfo("전사", 50);
            Console.WriteLine();

            DrawHealthBar(75, 100, 20);
            DrawHealthBar(30, 100, 20);
            DrawHealthBar(100, 100, 20);
            Console.WriteLine();

            AttackDamage("플레이어", "고블린", 85);
            Console.WriteLine();
            AttackDamage("고블린", "플레이어", 120);
            Console.WriteLine();

            // 3단계
            int num = GetNumber();
            Console.WriteLine(num);
            string userName = GetPlayerName("플레이어");
            Console.WriteLine(userName);
            string cm = ConnectMessage("유빈");
            Console.WriteLine(cm);

        }




    }
}
