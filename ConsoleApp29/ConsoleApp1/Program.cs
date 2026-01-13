using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Attack(ref int c, out int attack, out int defense)
        {
            attack = 10;
            defense = 11;

            c++;

            Console.WriteLine(c); // 출력: 6
            attack++;
            defense++;
        }

        static void Main(string[] args)
        {
            int a; int b; int c = 5;

            Attack(ref c, out b, out a);

            Console.WriteLine(c+1); // 출력 : 7

            Console.WriteLine($"{c}, {b}, {a}"); // 출력: 6, 11, 12


        }
    }
}
