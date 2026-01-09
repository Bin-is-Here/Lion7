using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch(); //c언어 함수 가져옴

        static void Main(string[] args)
        {
            

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            }; // 배열 문자열로 그리기

            string missile = "->";

            int playerX = 0;
            int playerY = 12;

            List<int> missilePosX = new List<int>();
            List<int> missilePosY = new List<int>();


            // ConsoleKeyInfo keyInfo;

            Console.CursorVisible = false;

            // 지연 방법: 시간을 계산해서 1초 루프만들기
            int dwTime = Environment.TickCount; // 1/1000초가 흐른다.

            while (true)
            {
                // 1초 루프
                if(dwTime + 30 < Environment.TickCount)
                {
                    // 현재 시간 세팅
                    dwTime = Environment.TickCount;

                    Console.Clear();

                    // Key 영역
                    int pressKey; //정수형 변수 선언해서 키 값 받기

                    if(Console.KeyAvailable) // 키가 눌렸는지 체크
                    {
                        pressKey = _getch(); // 아스키값을 사용
                        if (pressKey == 224) pressKey = _getch(); // 아스키코드의 앞에 224를 빼주면서 키가 바로 작동할 수 있도록 오류를 수정

                        switch (pressKey)
                        {
                            case 72: // 위쪽방향
                                playerY--;
                                if (playerY < 1) playerY = 1;
                                break;
                            case 75: //왼쪽 화살표키
                                playerX--;
                                if (playerX < 0)
                                    playerX = 0;
                                break;
                            case 77:  //오른쪽
                                playerX++;
                                if (playerX > 75)
                                    playerX = 75;
                                break;
                            case 80: //아래
                                playerY++;
                                if (playerY > 21)
                                    playerY = 21;
                                break;
                            case 32: // 스페이스바
                                missilePosX.Add(playerX + 3);
                                missilePosY.Add(playerY + 1);
                                // -> 미사일 날리기

                                break;
                        }

                    }

                    for(int i = 0; i < player.Length; i++)
                    {
                        // 콘솔 좌표 설정
                        Console.SetCursorPosition(playerX, playerY + i);
                        // 문자열 배열 출력
                        Console.WriteLine(player[i]);
                    }

                    for (int i = 0; i < missilePosX.Count; i++)
                    {
                        Console.SetCursorPosition(missilePosX[i], missilePosY[i]);
                        Console.WriteLine(missile);
                        missilePosX[i]++;

                        if (missilePosX[i] > 78)
                        {
                            missilePosX.RemoveAt(i);
                            missilePosY.RemoveAt(i);
                        }
                    }
                    


                }

                
            }






        }
    }
}
