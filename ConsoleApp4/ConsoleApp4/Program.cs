using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 숫자 데이터 형식: 정수와 실수를 다룰 때 사용하는 다양한 타입

            int integerNum = 10; // 정수 데이터
            float floatNum = 3.14f; // 단정밀도 실수. C#에서는 float형 자료형 마지막에 f를 작성하지 않으면 오류가 발생한다.
            double doubleNum = 3.14159; // 배정밀도 실수

            Console.WriteLine(integerNum); // 출력 : 10
            Console.WriteLine(floatNum); // 출력 : 3.14
            Console.WriteLine(doubleNum); // 출력 : 3.14159

            // 게임 캐릭터 스탯
            int level = 50;
            int attack = 1500;
            int gold = 1234567;
            long experinence = 9999999999L;

            Console.WriteLine("=== 캐릭터 정보 ===");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"공격력: {attack}");
            Console.WriteLine($"소지금: {gold:N0}골드"); // N0 : 천 단위 구분
            Console.WriteLine($"경험치: {experinence:N0}");

            // 타입별 최대값 확인
            Console.WriteLine("\n=== 타입별 최대값 ===");
            Console.WriteLine($"byte 최대값: {byte.MaxValue}");
            Console.WriteLine($"short 최대값: {short.MaxValue}");
            Console.WriteLine($"int 최대값: {int.MaxValue:N0}");
            Console.WriteLine($"long 최대값: {long.MaxValue:N0}");

            // 실수 데이터 형식 : 소수점을 포함한 숫자를 표현
            float singlePrecision = 3.14f; // 단정밀도 실수(4byte)
            double doublePrecision = 3.1415926535; // 배정밀도 실수(8byte)
            decimal highPrecision = 3.1415926535897932384626433833m; // 고정밀도 실수(16byte). 게임쪽에서는 거의 사용하지 않음

            Console.WriteLine(singlePrecision);
            Console.WriteLine(doublePrecision);
            Console.WriteLine(highPrecision);

            // 접미사 사용: 숫자의 데이터 형식을 명시
            int integerValue = 100; // 기본 정수형(int)
            long longValue = 100L; // 정수형(long)
            float floatValue = 3.14f; // 실수형(float)
            double doubleValue = 3.14; // 기본 실수형(double)
            decimal decimalValue = 3.14m; // 고정밀도 실수형(decimal)

            Console.WriteLine(integerValue);
            Console.WriteLine(longValue);
            Console.WriteLine(floatValue);
            Console.WriteLine(doubleValue);
            Console.WriteLine(decimalValue);

            // 문자 데이터 형식 char : C#에서는 2byte 크기로 Unicode 표준을 사용한다.
            char letter = 'A'; // 문자 'A' 저장
            char symbol = '#'; // 특수 기호 저장
            char number = '9'; // 숫자 형태의 문자 저장

            Console.WriteLine(letter);
            Console.WriteLine(symbol);
            Console.WriteLine(number);

            // 예제 출력
            // ==== 캐릭터 능력치 ====
            // float   이동속도 5.5
            // double  공격속도 1.25
            // decimal 아이템 가격 12.99

            float moveSpeed = 5.5f;
            double attackSpeed = 1.25;
            decimal itemPrice = 12.99m;

            Console.WriteLine("=== 캐릭터 능력치===");
            Console.WriteLine($"이동속도: {moveSpeed}");
            Console.WriteLine($"공격속도: {attackSpeed}");
            Console.WriteLine($"아이템 가격: {itemPrice}");

            // 문자열 데이터 형식 string : 여러 문자를 저장
            string greeting = "Hello, World!"; // 문자열 저장
            string name = "Alice"; // 이름 저장

            Console.WriteLine(greeting);
            Console.WriteLine(name);

            // 실전 예제
            // 문자(char)
            char grade = 'A';
            char cSymbol = '★';

            // 문자열(string)
            string playerName = "홍길동";
            string welcomeMessage = "게임에 오신 것을 환영합니다!";
            string emptyString = ""; // 빈 문자열도 가능

            // **실행 결과 **
            // === RPG 게임 ===
            // 플레이어: 홍길동
            // 등급: A등급 ★
            // 게임에 오신 것을 환영합니다!

            Console.WriteLine("\n=== RPG 게임 ===");
            Console.WriteLine($"플레이어: {playerName}");
            Console.WriteLine($"등급: {grade}등급 {cSymbol}");
            Console.WriteLine(welcomeMessage);

            // 논리 데이터 형식 bool : 참(True) 또는 거짓(False)
            bool isRunning = true;
            bool isFinished = false;

            Console.WriteLine(isRunning);
            Console.WriteLine(isFinished);

            // 실전 예제
            // === 게임 상태 ===
            // 게임 실행중: True
            // 일시정지: False
            // 열쇠 소지: False
            // 문 열림: False
            // 플레이어 생존: True

            // === 캐릭터 상태 ===
            // 체력: 80
            // 건강 상태: True
            // 위험 상태: False

            bool isGameRunning = true;
            bool isPaused = false;
            bool hasKey = false;
            bool isOpenDoor = false;
            bool isPlayerAlive = true;

            Console.WriteLine("=== 게임 상태===");
            Console.WriteLine($"게임 실행중: {isGameRunning}");
            Console.WriteLine($"일시정지: {isPaused}");
            Console.WriteLine($"열쇠 소지: {hasKey}");
            Console.WriteLine($"문 열림: {isOpenDoor}");
            Console.WriteLine($"플레이어 생존: {isPlayerAlive}");

            int HP = 80;
            bool health = true;
            bool danger = false;

            Console.WriteLine($"\n=== 캐릭터 상태 ===");
            Console.WriteLine($"체력: {HP}");
            Console.WriteLine($"건강 상태: {health}");
            Console.WriteLine($"위험 상태: {danger}");

            // 아이템 소지 여부
            bool hasWeapon = true;
            bool hasArmor = false;
            bool hasPotion = true;

            Console.WriteLine("\n=== 인벤토리 ===");
            Console.WriteLine($"무기 보유: {(hasWeapon ? "있음" : "없음")}"); // 삼항연산자
            Console.WriteLine($"방어구 보유: {(hasArmor ? "있음" : "없음")}");
            Console.WriteLine($"포션 보유: {(hasPotion ? "있음" : "없음")}");

            // 닷넷 형식: 기본 형식의 닷넷 표현
            System.Int32 s_number = 123; // int의 닷넷 형식
            System.String text = "Hello"; // string의 닷넷 형식
            System.Boolean flag = true; // bool의 닷넷 형식

            Console.WriteLine(s_number);
            Console.WriteLine(text);
            Console.WriteLine(flag);

            // 래퍼 형식
            int wNumber = 123;
            string numberAsString = wNumber.ToString(); // 정수를 문자열로 변환
            // string numberAsString = number << 오류 발생

            bool wFlag = true;
            string flagAsString = wFlag.ToString(); // 논리값을 문자열로 변화

            Console.WriteLine(numberAsString); // 출력: 123("123")
            Console.WriteLine(flagAsString); // 출력: True("True")


        }
    }
}
