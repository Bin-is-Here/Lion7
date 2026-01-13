using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {

        // 일반 함수
        static void Swap1(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // ref 함수
        static void Swap2(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }



        static void Main(string[] args)
        {

            // ref 사용 예시

            int x = 10;
            int y = 20;

            // x와 y의 값을 바꾸고 싶은 경우 새로운 변수를 만들어서 교환을 진행해야 한다.
            // swap
            Swap1(x, y);
            Console.WriteLine("x:" + x + " y:" + y); // 값 안바뀜. 바꾸는 코드가 일반함수 내부에서만 동작하기 때문.

            Swap2(ref x, ref y);
            Console.WriteLine("x:" + x + " y:" + y); // 값이 바뀜. ref 키워드 활용하여 내부 주소값에 직접 접근하여 값 수정.


        }
    }
}
