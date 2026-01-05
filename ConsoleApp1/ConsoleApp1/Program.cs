using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 변수 선언 : 데이터 타입과 변수 이름을 지정합니다.
            //int age; // 정수형 변수 age 선언
            //age = 25;

            //Console.WriteLine(age); // 콘솔창에 출력. cw + Enter 로 빠르게 자동완성 가능

            //// 레벨 100을 변수를 이용해서 출력하시오.
            //int level = 100;

            //Console.WriteLine(level);

            //// 리터럴 : 코드에서 고정된 값을 의미합니다.
            //int number = 10;   // 정수형 리터럴 (10이라는 값을 리터럴이라고 부른다.)
            //double pi = 3.14;  // 실수형 리터럴
            //char letter = 'A'; // 문자형 리터럴
            //string name = "Alice"; // 문자열 리터럴

            //Console.WriteLine(number); // 출력 : 10
            //Console.WriteLine(pi);     // 출력 : 3.14
            //Console.WriteLine(letter); // 출력 : A
            //Console.WriteLine(name);   // 출력 : Alice

            //Console.Write(number);
            //Console.Write(pi);

            //// 리터럴 연습
            //// 플레이스코어 100
            //// 파이 3.14
            //// 등급 'A'
            //// 플레이어이름 홍길동

            //int playScore = 100;
            //double pii = 3.14;
            //char grade = 'A';
            //string playerName = "홍길동";

            //// 결과 출력하기

            //Console.WriteLine("점수: " + playScore);
            //Console.WriteLine("파이 값: " + pii);
            //Console.WriteLine("등급: " + grade);
            //Console.WriteLine("플레이어: " + playerName);

            //// 변수 선언 후 값 저장
            //string greeting; // 문자열 변수를 선언
            //greeting = "안녕하세요~!"; // 변수에 값을 저장

            //// 출력하기
            //Console.WriteLine(greeting);

            //// 변수 초기화
            //int score = 100; // 정수형 변수 선언과 동시에 100으로 초기화
            //double temperature = 36.5; // 실수형 변수 선언과 동시에 초기화
            //string city = "Seoul"; // 문자열 변수 선언과 동시에 초기화

            //Console.WriteLine(score); // 출력 : 100
            //Console.WriteLine(temperature); // 출력 : 36.5
            //Console.WriteLine(city); // 출력 : Seoul

            //// 같은 데이터 타입의 변수를 쉼표로 구분하여 한 번에 선언
            //int x = 10, y = 20, z = 30;

            //Console.WriteLine(x); // 출력 : 10
            //Console.WriteLine(y); // 출력 : 20
            //Console.WriteLine(z); // 출력 : 30

            //// 여러가지 출력 방법
            //int w_age = 20;
            //Console.WriteLine("나이: {0}", w_age);

            //string w_name = "철수";
            //Console.WriteLine("이름: {0}, 나이: {1}", w_name, w_age);

            //int w_level = 10;
            //Console.WriteLine("나이: " + w_age); // w_age가 문자열로 자동 변환되어 출력되는 방식
            //Console.WriteLine($"나이: {w_age}"); // 유니티에서 많이 사용. 가독성 좋고 실무에서 가장 많이 사용
            //Console.WriteLine($"나이: {w_age}, 레벨: {w_level}"); // w_age, w_level의 타입이 바뀌지 않음

            // 3D 좌표 예시
            int posX = 0, posY = 50, posZ = 100;
            // 3가지 방식으로 출력해보세요.
            Console.WriteLine("X좌표: {0} Y좌표: {1} Z좌표: {2}", posX, posY, posZ);
            Console.WriteLine("X좌표: " + posX + " Y좌표: " + posY + " Z좌표: " + posZ);
            Console.WriteLine($"X좌표: {posX} Y좌표: {posY} Z좌표: {posZ}");

            // RGB 색상 값 예시
            int red = 255, green = 128, blue = 0;
            // 3가지 방식으로 출력해보세요.
            Console.WriteLine("red: {0} green: {1} blue: {2}", red, green, blue);
            Console.WriteLine("red: " + red + " green: " + green + " blue: " + blue);
            Console.WriteLine($"red: {red} green: {green} blue: {blue}");



        }
    }
}
