using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 상수 : 값을 변경할 수 없는 변수
            const double Pi = 3.14159; // 상수 Pi 선언 및 초기화
            const int MaxScore = 100; // 정수형 상수 선언 및 초기화

            // 출력
            Console.WriteLine("Pi: " + Pi);
            Console.WriteLine($"Max Score: {MaxScore}");
            // Pi = 3.14; 오류 발생

            // **실행 결과 : **

            // === 게임 설정 ===
            // 최대 플레이어: 4명
            // 시작 골드: 1000G
            // 버전 : 1.0.0

            const int MAX_PLAYER = 4;
            const int START_GOLD = 1000;
            const string GAME_VERSION = "1.0.0";

            Console.WriteLine("=== 게임 설정 ===");
            Console.WriteLine("최대 플레이어: " + MAX_PLAYER + "명");
            Console.WriteLine($"시작 골드: {START_GOLD}G");
            Console.WriteLine("버전: " + GAME_VERSION);

        }
    }
}
