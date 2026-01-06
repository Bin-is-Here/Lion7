using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 사용자 입력을 문자열로 받기
            Console.Write("이름을 입력하세요 : ");
            string uuserName = Console.ReadLine(); // 사용자로부터 입력 받기(문자열로 입력받음)

            Console.Write("안"); // 입력값 출력
            Thread.Sleep(100);
            Console.Write("녕");
            Thread.Sleep(100);
            Console.Write("하");
            Thread.Sleep(100);
            Console.Write("세");
            Thread.Sleep(100);
            Console.Write("요");
            Thread.Sleep(100);
            Console.Write(",");
            Thread.Sleep(100);
            Console.Write(uuserName);
            Thread.Sleep(100);
            Console.Write("님");
            Thread.Sleep(100);
            Console.Write("!");
            Thread.Sleep(100);

            // 형식 변환
            // 문자열을 정수로 변환(int.Parse, Convert)
            /*
             int.Parse : 정수로 변환. 숫자만 넣는것 권장
             Convert   : 
             */

            Console.Write("\n나이를 입력하세요: ");
            string input = Console.ReadLine();
            int age = int.Parse(input);
     
            Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!");


            // 이진수를 정수로 변환
            Console.Write("2진수를 입력하세요: ");

            string binaryInput = Console.ReadLine();
            Console.WriteLine($"입력한 이진수 : {binaryInput}");

            int decimalValue = Convert.ToInt32(binaryInput, 2); // 2진수 -> 10진수 변환
            Console.WriteLine($"10진수로 변환 : {decimalValue}");

            // 정수를 이진수로 변환
            string binaryOutput = Convert.ToString(decimalValue, 2); // 10진수 -> 2진수 변환

            Console.WriteLine($"다시 2진수로 변환 : {binaryOutput}");

            // 예제

            // === 캐릭터 생성 ===
            // 캐릭터 이름을 입력하세요: 홍길동
            // 환영합니다, 홍길동님!
            // 시작 레벨을 입력하세요: 5
            // 홍길동님의 시작 레벨은 5입니다.

            Console.WriteLine("=== 캐릭터 생성 ===");
            Console.Write("캐릭터 이름을 입력하세요 : ");
            string userName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("=== 캐릭터 생성 ===");
            Console.Write("시작 레벨을 입력하세요: ");
            string inputLevel = Console.ReadLine();
            int startLevel = int.Parse(inputLevel);
            Console.Clear();


            Console.Write("\n환");
            Thread.Sleep(100);
            Console.Write("영");
            Thread.Sleep(100);
            Console.Write("합");
            Thread.Sleep(100);
            Console.Write("니");
            Thread.Sleep(100);
            Console.Write("다");
            Thread.Sleep(100);
            Console.Write(",");
            Thread.Sleep(100);
            Console.Write(userName);
            Thread.Sleep(100);
            Console.Write("님");
            Thread.Sleep(100);
            Console.Write("!");
            Thread.Sleep(100);

            Console.WriteLine();
            Console.Write(userName);
            Thread.Sleep(100);
            Console.Write("님");
            Thread.Sleep(100);
            Console.Write("의 ");
            Thread.Sleep(100);
            Console.Write("시");
            Thread.Sleep(100);
            Console.Write("작 ");
            Thread.Sleep(100);
            Console.Write("레");
            Thread.Sleep(100);
            Console.Write("벨");
            Thread.Sleep(100);
            Console.Write("은 ");
            Thread.Sleep(100);
            Console.Write(startLevel);
            Thread.Sleep(100);
            Console.Write("입");
            Thread.Sleep(100);
            Console.Write("니");
            Thread.Sleep(100);
            Console.Write("다");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(100);


        }
    }
}
