using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 연산자
            // 값을 계산하거나 조작을 할 때 사용
            // 단항, 산술, 관계형, 논리, 비트연산자 등 다양한 종류가 있음

            int aa = 5, bb = 3;
            int sum = aa + bb; // 산술연산자 사용
            bool isEqual = (aa == bb); // 관계형 연산자 사용

            Console.WriteLine($"합: {sum}");
            Console.WriteLine($"a와 b가 같은가? {isEqual}");

            // 연산자의 종류
            /*
                산술 연산자: 사칙연산(+, -, *, /)
                비교 연산자: 크기비교(==, !=, <, >, <=, >=
                논리 연산자: 논리 판단(&&, ||, !)
                대입 연산자: 값 저장(=, +=, -=, *=, /=)
                증감 연산자: 1씩 증가/감소(++, --)
                                                            */

            // 1.단항 연산자 =========================================================================================================================
            int number = 5;
            Console.WriteLine(+number); // 양수 출력 : 5
            Console.WriteLine(-number); // 음수 출력 : -5

            bool flag = true;
            Console.WriteLine(flag);  // 출력: True
            Console.WriteLine(!flag); // 출력: False

            // 2.산술 연산자 =========================================================================================================================
            int a = 10, b = 3;
            Console.WriteLine(a + b); // 덧셈 : 13
            Console.WriteLine(a - b); // 뺄셈 : 7
            Console.WriteLine(a * b); // 곱셈 : 30
            Console.WriteLine(a / b); // 나눗셈 : 3 나머지는 버림
            Console.WriteLine(a % b); // 나머지 : 1

            // 문자열 연결 연산자
            string firstName = "Alice";
            string lastName = "Smith";
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine($"{firstName} {lastName}");

            // 3.할당 연산자 =========================================================================================================================
            int x = 5;
            int y = 4;
            x += y; // x = x + y;
            Console.WriteLine("합계 : " + x);

            x = 5;
            x -= y; // 출력: 1
            Console.WriteLine("합계 : " + x);

            x = 5;
            x *= y; // 출력: 20
            Console.WriteLine("합계 : " + x);

            x = 5;
            x /= y; // 출력: 1
            Console.WriteLine("합계 : " + x);

            x = 5;
            x %= y; // 출력: 1
            Console.WriteLine("합계 : " + x);

            string ss = "sss";
            string dd = "ddd";

            ss += dd;
            Console.WriteLine(ss); //?????????? 이게 되네

            // 4.증감 연산자 ++ -- ===================================================================================================================
            int i = 3;

            i++; // 후위 증가
            Console.WriteLine(i);

            --i; // 전위 감소
            Console.WriteLine(i);

            // 전후위 증가 시 주의할 점
            int count = 5;
            Console.WriteLine(++count); // 출력값: 6, count값: 6
            count = 5;
            Console.WriteLine(count++); // 출력값: 5, count값: 6


            // 5.관계형 연산자 =======================================================================================================================

            a = 5;
            b = 10;

            Console.WriteLine(a < b);
            Console.WriteLine(a > b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

            // 6. 논리 연산자 ========================================================================================================================

            bool aTrue = true;
            bool bTrue = true;

            // AND : 둘 다 True일 때 true 이외에는 false를 반환
            Console.WriteLine(aTrue && bTrue);
            aTrue = true;
            bTrue = false;
            Console.WriteLine(aTrue && bTrue);
            aTrue = false;
            bTrue = true;
            Console.WriteLine(aTrue && bTrue);
            aTrue = false;
            bTrue = false;
            Console.WriteLine(aTrue && bTrue);

            // OR : 둘 중 하나라도 True라면 True값 출력. 모두 false일 경우 false 출력
            aTrue = true;
            bTrue = true;
            Console.WriteLine(aTrue || bTrue);
            aTrue = true;
            bTrue = false;
            Console.WriteLine(aTrue || bTrue);
            aTrue = false;
            bTrue = true;
            Console.WriteLine(aTrue || bTrue);
            aTrue = false;
            bTrue = false;
            Console.WriteLine(aTrue || bTrue);

            // ! : True는 False로, False는 True로 출력.
            bool aaa = true;
            Console.WriteLine(!aaa); // false 출력

        }
    }
}
