using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        // ref
        static int AttackRef(ref int a)
        {
            Console.WriteLine($"공격력: {a}");
            a++;
            return a;
        }

        // out
        static void AttackOut(int a, int d, out int attack, out int defense)
        {
            attack = a; defense = d;

            attack++;
            defense++;
        }


        static void AttackRefOut(ref int z, out int attack, out int defense)
        {
            attack = 10;
            defense = 11;

            z++;

            Console.WriteLine(z); // 출력: 6
            attack++;
            defense++;
        }


        static void Main(string[] args)
        {

            // ref 키워드 참조 -> 변수의 참조를 전달하여 함수 내에서 원본 값을 직접 수정할 수 있다.

            int a = 10;
            a = AttackRef(ref a);

            Console.WriteLine($"a 값: {a}");


            // out : 함수에서 여러 값을 반환할 때 사용.
            // 일반 함수의 경우 return 값을 여러개 가져올 수 없기 때문에 return값이 여러개 반환되기를 원한다면 out 키워드를 사용할 수 있다.

            int attack;
            int defense;

            AttackOut(10, 20, out attack, out defense);

            Console.WriteLine($"공격력 : {attack}");
            Console.WriteLine($"방어력 : {defense}");



            int x; int y; int z = 5;

            AttackRefOut(ref z, out y, out x);

            Console.WriteLine(z + 1); // 출력 : 7

            Console.WriteLine($"{z}, {y}, {x}"); // 출력: 6, 11, 12

        }
          

        
       
    }
}
