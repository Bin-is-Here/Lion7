using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 비트 연산자
            int x = 5; // 0101(2)
            int y = 3; // 0011(2)

            Console.WriteLine(x & y); // 1 0001(2)
            Console.WriteLine(x | y); // 7 0111(2)
            Console.WriteLine(x ^ y); // 6 0110(2)
            Console.WriteLine(~x);    // -6 1111 1111 1111 1111 1111 1111 1111 1010(2)

            string binary = Convert.ToString(x & y, 2);
            Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");
            binary = Convert.ToString(x | y, 2);
            Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");
            binary = Convert.ToString(x ^ y, 2);
            Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");
            binary = Convert.ToString(~x, 2);
            Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");

            // 쉬프트 연산자 : 비트를 좌우로 이동시킨다. << >>

            int value = 4;                 // 0100
            string binary2 = Convert.ToString(value <<1, 2);
            Console.WriteLine($"8비트 : {binary2.PadLeft(8, '0')}"); // 1000
            binary2 = Convert.ToString(value >> 1, 2);
            Console.WriteLine($"8비트 : {binary2.PadLeft(8, '0')}"); // 0010

            Console.WriteLine("\n");

            int inventory = 0; // 0000 0000
            Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");

            // 슬롯 번호
            int slot1 = 1;
            int slot2 = 2;

            //슬롯 0에 활을 추가
            inventory = inventory | (1 << slot1); // 2번째로 1추가
            Console.WriteLine($"슬롯 {slot1}에 활 추가");
            Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");

            //슬롯 0에 활을 추가
            inventory = inventory | (1 << slot2); // 2번째로 1추가
            Console.WriteLine($"슬롯 {slot2}에 지팡이 추가");
            Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");


        }
    }
}
