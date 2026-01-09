using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // 2차원 for문
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"i:{i} j:{j}");
                }
                Console.WriteLine();
            }


            // === 예제 1: 사각형 그리기 ===
            // ⬜ ⬜ ⬜
            // ⬜ ⬜ ⬜
            // ⬜ ⬜ ⬜

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write("⬜");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("⬜⬜⬜");
            }

            Console.WriteLine("\n");

            //=== 예제 2: 숫자 표 ===
            //1 2 3
            //1 2 3
            //1 2 3

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write((j, i));
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == i || (j + i) % 5 == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }


            Console.WriteLine("\n");

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write($"{i}*{j}={i * j} ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n");

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 2; j <= 5; j++)
                {
                    Console.Write($"{j}*{i}={i * j} ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n");


            //🏠 🟩 🟩 🟩
            //🟩 🟩 🟩 🟩
            //🟩 🟩 🟩 🟩
            //🟩 🟩 🟩 🎯

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if(i==1 && j == 1)
                    {
                        Console.Write("🏠");
                    }
                    else if(i == 4 && j == 4)
                    {
                        Console.Write("🎯");
                    }
                    else
                    {
                        Console.Write("🟩");
                    }
                }
                Console.WriteLine();
            }

            



        }
    }
}
