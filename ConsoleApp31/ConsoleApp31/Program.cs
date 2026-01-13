using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {

        // 1부터 n까지의 합 구하기
        static int SumToN(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            return n + SumToN(n - 1); // n + (n-1)까지의 합
        }

        static void Main(string[] args)
        {

            // 재귀 함수: 자기자신을 호출. 탈출 루트가 없으면 무한이 반복되다가 오버플로우 오류 발생
            int count = 10;
            int sum = SumToN(count);

            Console.WriteLine($"1부터 {count}까지의 합 = {sum}");

        }
    }
}
