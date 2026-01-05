using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.ComponentModel.Design;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("안");
            Thread.Sleep(100); // 1/1000초 단위. 1000 입력시 1초
            Console.Clear();
            Console.WriteLine("안녕");
            Thread.Sleep(100); // 프로그램 1초 슬립(멈춤)
            Console.Clear();
            Console.WriteLine("안녕하");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("안녕하세");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("안녕하세요");
            Thread.Sleep(100);

            Console.Write("반");
            Thread.Sleep(100);
            Console.Write("갑");
            Thread.Sleep(100);
            Console.Write("습");
            Thread.Sleep(100);
            Console.Write("니");
            Thread.Sleep(100);
            Console.Write("다");

            // 과제
            // 지난시간 만들었던 UI 하나 정해서 자유롭게 비주얼하게 만들기



        }
    }
}
