using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            MainGame mainGame = new MainGame();
            mainGame.Initialize();
            mainGame.Progress();

        }
    }
}
