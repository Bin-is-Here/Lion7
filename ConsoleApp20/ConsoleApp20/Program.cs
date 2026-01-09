using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int consoleWidth = 80;
            int consoleHeight = 25;

            const int targetX = 50;
            const int targetY = 20;

            Console.SetWindowSize(consoleWidth, consoleHeight); // 콘솔 창 크기 설정
            Console.SetBufferSize(consoleWidth, consoleHeight); // 버퍼 크기도 동일하게 설정(스크롤 방지)


            int posX = consoleWidth / 2, posY = consoleHeight / 2;

            

            ConsoleKeyInfo keyInfo; // Key 관련 정보

            Console.CursorVisible = false; // 콘솔 창에서 커서 제거

            while (true)
            {
                Console.Clear(); // 화면 지우기

                Console.SetCursorPosition(posX, posY); // 좌표
                Console.Write("●"); // 커서 현재 위치 출력


                Console.SetCursorPosition(targetX, targetY);
                Console.Write("🏠");

                if(posX == targetX && posY == targetY)
                {
                    Console.Clear();
                    Console.WriteLine("집에 도착했습니다.");
                    break;
                }



                keyInfo = Console.ReadKey(true); // 키 입력 받기(화면에 출력은 x)

                // 방향키 입력에 따른 좌표 변경
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: if (posY > 0) posY--; break;
                    case ConsoleKey.DownArrow: if (posY <  consoleHeight - 1) posY++; break;
                    case ConsoleKey.LeftArrow: if (posX > 0) posX--; break;
                    case ConsoleKey.RightArrow: if (posX < consoleWidth - 1) posX++; break;
                    // case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                    case ConsoleKey.Escape: break; // // Esc 키로 탈출
                    
                }
                
            }


        }
    }
}
