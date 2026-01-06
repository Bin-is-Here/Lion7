using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // var를 사용하여 변수 선언
            // var 키워드는 컴파일러가 변수의 데이터 형식을 자동으로 추론한다.
            // 선언 시 반드시 초기화해야 한다.
            // 읽기 쉽고 유연하지만, 남용하지 않도록 타입 추론을 명확히 이해

            var name = "Alice"; // 문자열로 추론
            var age = 25; // 정수로 추론
            var isStudent = true; // 논리값으로 추론

            Console.WriteLine($"이름: {name} \n나이: {age} \n학생 여부: {isStudent}");

            // 데이터 타입 확인하는 법
            var a = 3.1;
            var b = 3.14f;

            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());

            // 변수의 기본값을 default 키워드로 설정하기
            // 데이터 형식에 따라 기본값을 설정할 수 있다.
            // 예: 숫자는 0, 문자열은 null, 논리값은 false.
            int defaultInt = default;       // 0
            string defaultString = default; // null
            bool defaultBool = default;     // false

            Console.WriteLine($"정수 기본값: {defaultInt}");
            Console.WriteLine($"문자열 기본값: {defaultString}");
            Console.WriteLine($"논리 기본값: {defaultBool}");

            // 1.암시적 변환(작은 타입 -> 큰 타입)
            int smallNumber = 100;
            long bigNumber = smallNumber; // int에서 long으로 자동 변환
            double doubleNumber = smallNumber; // int에서 double로 자동 변환

            Console.WriteLine("\n=== 암시적 변환 ===");
            Console.WriteLine($"int: {smallNumber}");
            Console.WriteLine($"long: {bigNumber}");
            Console.WriteLine($"double: {doubleNumber}");
            Console.WriteLine($"int type: {smallNumber.GetType()}");
            Console.WriteLine($"long type: {bigNumber.GetType()}");
            Console.WriteLine($"double type: {doubleNumber.GetType()}");

            // 2.명시적 변환(큰 타입 -> 작은 타입)
            double pi = 3.14159;
            int intPi = (int)pi; // 소수점 아래 값을 버림(명시적 변환 필요)

            Console.WriteLine("\n=== 명시적 변환 ===");
            Console.WriteLine($"double : {pi}");
            Console.WriteLine($"int로 변환 : {intPi}"); // 3.14...

            // int, float, double, char, long -> 기존부터 존재
            // string -> 사용하기 쉽도록 이후에 클래스로 만들어진 것

            // 3. 문자열을 숫자로 변환
            string scoreText = "95";
            int score = int.Parse(scoreText); // 문자열 -> 정수로 변환

            string priceText = "19.99";
            double price = double.Parse(priceText); // 문자열 -> 실수로 변환

            Console.WriteLine("\n=== 문자열 변환 ===");
            Console.WriteLine($"점수(문자열) : {scoreText} -> 숫자 {score}");
            Console.WriteLine($"가격(문자열) : {priceText} -> 숫자 {price}");

            // 4. 숫자롤 문자열로 변환
            int playerLevel = 50;
            string levelText = playerLevel.ToString();

            Console.WriteLine("=== 숫자를 문자열로 변환 ===");
            Console.WriteLine($"레벨(숫자): {playerLevel} -> 문자열 : {levelText}");


            // ⚠️ 형식 변환 주의사항


            // 1. 명시적 변환 시 데이터 손실
            double value = 9.8;
            int result = (int)value;  // 9.8 → 9 (소수점 버려짐!)

            // 2. 범위 초과
            int bigValue = 300;
            byte smallValue = (byte)bigValue;  // 오버플로우 발생!

            // 3. 잘못된 문자열 변환
            string text = "abc";
            // int num = int.Parse(text);  // ❌ 런타임 오류!

            // 안전한 변환: TryParse 사용
            if (int.TryParse(text, out int num))
            {
                Console.WriteLine($"변환 성공: {num}");
            }
            else
            {
                Console.WriteLine("변환 실패!");
            }

        }
    }
}
