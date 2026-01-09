using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int consoleWidth = 48;
            int consoleHeight = 20;

            Console.SetWindowSize(consoleWidth, consoleHeight);
            Console.SetBufferSize(consoleWidth, consoleHeight);
            Console.CursorVisible = false;

            // Area Setting
            int getTreeX = consoleWidth - 2;
            int getTreeY = consoleHeight / 2;

            int shopX = 0;
            int shopY = consoleHeight / 2;

            int exitX = consoleWidth / 2;
            int exitY = 18;

            // Loading Setting
            int loadingDelay = 100;
            int loadingDelay99 = 1000;

            // Player Status
            string playerName = "";
            string equipEx = "";
            int playerMoney = 0;
            int attackDelay = 1000;

            // Player Inventory
            int woodUnique = 0;
            int woodRare = 0;
            int woodNormal = 0;

            int weaponLegend = 0;
            int weaponUnique = 0;
            int weaponEpic = 0;
            int weaponRare = 0;
            int weaponNormal = 0;

            // Item Price
            int woodUniquePrice = 3000;
            int woodRarePrice = 500;
            int woodNormalPrice = 100;


            ConsoleKeyInfo keyInfo;

            int posX = consoleWidth / 2; int posY = consoleHeight / 2;

            Console.WriteLine("플레이어 이름을 입력하세요.");
            Console.Write(": ");
            playerName = Console.ReadLine();

            // Scene #000: Loading...
            Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [                         ]         ");
            Thread.Sleep(loadingDelay);
            Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■                        ]         ");
            Thread.Sleep(loadingDelay); Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■                       ]         ");
            Thread.Sleep(loadingDelay); Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■                      ]         ");
            Thread.Sleep(loadingDelay); Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■■                     ]         ");
            Thread.Sleep(loadingDelay); Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■■■                    ]         ");
            Thread.Sleep(loadingDelay); Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■■■■                   ]         ");
            Thread.Sleep(loadingDelay); Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■■■■■                  ]         ");
            Thread.Sleep(loadingDelay); Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■■■■■■                 ]         ");
            Thread.Sleep(loadingDelay); Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■■■■■■■                ]         ");
            Thread.Sleep(loadingDelay); Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■■■■■■■■               ]         ");
            Thread.Sleep(loadingDelay); Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■■■■■■■■■              ]         ");
            Thread.Sleep(loadingDelay); Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■■■■■■■■■■             ]         ");
            Thread.Sleep(loadingDelay); Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■■■■■■■■■■■            ]         ");
            Thread.Sleep(loadingDelay); Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■■■■■■■■■■■■           ]         ");
            Thread.Sleep(loadingDelay); Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■■■■■■■■■■■■■          ]         ");
            Thread.Sleep(loadingDelay);
            Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■■■■■■■■■■■■■■         ]         ");
            Thread.Sleep(loadingDelay);
            Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■■■■■■■■■■■■■■■        ]         ");
            Thread.Sleep(loadingDelay);
            Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■■■■■■■■■■■■■■■■       ]         ");
            Thread.Sleep(loadingDelay);
            Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■■■■■■■■■■■■■■■■■      ]         ");
            Thread.Sleep(loadingDelay);
            Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■■■■■■■■■■■■■■■■■■     ]         ");
            Thread.Sleep(loadingDelay);
            Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■■■■■■■■■■■■■■■■■■■    ]         ");
            Thread.Sleep(loadingDelay);
            Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■■■■■■■■■■■■■■■■■■■■   ]         ");
            Thread.Sleep(loadingDelay);
            Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■■■■■■■■■■■■■■■■■■■■■  ]         ");
            Thread.Sleep(loadingDelay);
            Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■■■■■■■■■■■■■■■■■■■■■■ ]         ");
            Thread.Sleep(loadingDelay99);
            Console.Clear();
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                   Loading...                 ");
            Console.WriteLine("                                              ");
            Console.WriteLine("          [■■■■■■■■■■■■■■■■■■■■■■■■■]         ");
            Thread.Sleep(loadingDelay);

            // Game Running
            while (true)
            {
                // 장비 자동 교체
                if (weaponLegend >= 1) { Console.ForegroundColor = ConsoleColor.Green; equipEx = "레전드"; Console.ResetColor(); }
                else if (weaponUnique >= 1) { Console.ForegroundColor = ConsoleColor.Yellow; equipEx = "유니크"; Console.ResetColor(); }
                else if (weaponEpic >= 1) { Console.ForegroundColor = ConsoleColor.Magenta; equipEx = "에픽"; Console.ResetColor(); }
                else if (weaponRare >= 1) { Console.ForegroundColor = ConsoleColor.Blue; equipEx = "레어"; Console.ResetColor(); }
                else { equipEx = "일반"; }

                // 착용 장비에 따른 공격 속도
                if(equipEx == "레전드") { attackDelay = 10; }
                else if(equipEx == "유니크") { attackDelay = 100; }
                else if(equipEx == "에픽") { attackDelay = 300; }
                else if(equipEx == "레어") { attackDelay = 500; }
                else { attackDelay = 1000; }

                Console.Clear();

                Console.WriteLine($"{playerName}");
                Console.WriteLine($"소지금: {playerMoney:N0}골드");
                Console.WriteLine("I : 인벤토리 열기 | P : 캐릭터 정보 열기" );

                Console.SetCursorPosition(getTreeX, getTreeY);
                Console.Write("🌳");
                Console.SetCursorPosition(shopX, shopY);
                Console.Write("🏠");
                Console.SetCursorPosition(exitX, exitY);
                Console.Write("❌");


                Console.SetCursorPosition(posX, posY);
                Console.Write("💀");


                // 숲 : 나무 캐기
                while (posX == getTreeX && posY == getTreeY)
                {
                    Console.Clear();
                    Console.WriteLine("━━━━━ 나무캐기 ━━━━━");
                    Console.WriteLine("인벤토리");
                    Console.WriteLine("빛나는 나무  : " + woodUnique + "개");
                    Console.WriteLine("질 좋은 나무 : " + woodRare + "개");
                    Console.WriteLine("나뭇가지     : " + woodNormal + "개");
                    Console.WriteLine($"소지금       : {playerMoney:N0}골드");
                    Console.WriteLine("");
                    Console.WriteLine("Enter: 나무 캐기");
                    Console.WriteLine("X: 돌아가기");
                    Console.Write(": ");


                    string inputNumber = Console.ReadLine();

                    if (inputNumber == "x")
                    {
                        posX = posX - 2;
                        Console.Write("... Press Enter Key");
                        break;
                    }
                    else
                    {
                        for (int i = 0; i < 10; i++)
                        {

                            Console.Write("■■");
                            Thread.Sleep(attackDelay);
                        }

                        Random random = new Random();

                        int randomNum = random.Next(1, 11);

                        if (randomNum == 1) { Console.WriteLine("\n빛나는 나무 획득!"); woodUnique++; }
                        else if (randomNum >= 2 && randomNum < 5) { Console.WriteLine("\n질 좋은 나무 획득!"); woodRare++; }
                        else { Console.WriteLine("\n나뭇가지 획득..."); woodNormal++; }
                        Console.Write(": Press Enter Key");
                        break;
                    }
                }
                // 상점 가기
                while (posX == shopX && posY == shopY)
                {
                    Console.Clear();
                    Console.WriteLine("━━━━━━ 상 점 ━━━━━━");
                    Console.WriteLine("1. 장비  뽑기");
                    Console.WriteLine("2. 나무  판매");
                    Console.WriteLine("3. 장비  교환");
                    Console.WriteLine("4. 상점 나가기");
                    Console.WriteLine("");
                    Console.WriteLine($"소지금: {playerMoney:N0}골드");
                    Console.Write(": ");

                    string inputNumber = Console.ReadLine();

                    switch (inputNumber)
                    {
                        case "1": // 장비 뽑기
                            if (playerMoney >= 1000)
                            {
                                Console.Clear();
                                Console.WriteLine("장비를 10회 뽑습니다.");
                                for (int i = 0; i <= 10; i++)
                                {
                                    Random random = new Random();

                                    int randomNum = random.Next(1, 10001);

                                    if (randomNum == 1) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("레전드 도끼 획득!"); weaponLegend++; Console.ResetColor(); }
                                    else if (randomNum >= 2 && randomNum <= 100) { Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("유니크 도끼 획득!"); weaponUnique++; Console.ResetColor(); }
                                    else if (randomNum >= 101 && randomNum <= 500) { Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("에픽 도끼 획득!"); weaponEpic++; Console.ResetColor(); }
                                    else if (randomNum >= 501 && randomNum <= 1500) { Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("레어 도끼 획득!"); weaponRare++; Console.ResetColor(); }
                                    else { Console.WriteLine("일반 도끼 획득..."); weaponNormal++; }
                                    Thread.Sleep(500); // 딜레이 0.5초
                                }
                                playerMoney -= 1000;
                            }
                            else
                            {
                                Console.WriteLine("소지금이 부족합니다.");
                                Console.WriteLine("메뉴로 돌아갑니다.");
                                Thread.Sleep(1000);
                            }
                            break;
                        case "2": // 나무 판매
                            Console.Clear();
                            Console.WriteLine("나무 가격표");
                            Console.WriteLine("빛나는 나무: " + woodUniquePrice);
                            Console.WriteLine("질 좋은 나무: " + woodRarePrice);
                            Console.WriteLine("나뭇가지: " + woodNormalPrice);

                            Console.WriteLine("인벤토리");
                            Console.WriteLine("빛나는 나무  : " + woodUnique + "개");
                            Console.WriteLine("질 좋은 나무 : " + woodRare + "개");
                            Console.WriteLine("나뭇가지     : " + woodNormal + "개");
                            Console.WriteLine($"소지금       : {playerMoney:N0}골드");

                            if (woodUnique > 0)
                            {
                                Console.Write("판매할 빛나는 나무 개수를 입력하세요 :");
                                int sellCount = int.Parse(Console.ReadLine());
                                if (sellCount > woodUnique)
                                {
                                    Console.WriteLine($"빛나는 나무를 {woodUnique}개 판매했습니다.");
                                    Console.WriteLine($"{woodUniquePrice * woodUnique:N0}골드 획득!");
                                    playerMoney += woodUniquePrice * woodUnique;
                                    woodUnique = 0;
                                }
                                else
                                {
                                    Console.WriteLine($"빛나는 나무를 {sellCount}개 판매했습니다.");
                                    Console.WriteLine($"{woodUniquePrice * sellCount:N0}골드 획득!");
                                    playerMoney += woodUniquePrice * sellCount;
                                    woodUnique -= sellCount;
                                }
                            }
                            if (woodRare > 0)
                            {
                                Console.Write("판매할 질 좋은 나무 개수를 입력하세요 :");
                                int sellCount = int.Parse(Console.ReadLine());
                                if (sellCount > woodRare)
                                {
                                    Console.WriteLine($"빛나는 나무를 {woodRare}개 판매했습니다.");
                                    Console.WriteLine($"{woodRarePrice * woodRare:N0}골드 획득!");
                                    playerMoney += woodRarePrice * woodRare;
                                    woodRare = 0;
                                }
                                else
                                {
                                    Console.WriteLine($"빛나는 나무를 {sellCount}개 판매했습니다.");
                                    Console.WriteLine($"{woodRarePrice * sellCount:N0}골드 획득!");
                                    playerMoney += woodRarePrice * sellCount;
                                    woodRare -= sellCount;
                                }
                            }
                            if (woodNormal > 0)
                            {
                                Console.Write("판매할 빛나는 나무 개수를 입력하세요 :");
                                int sellCount = int.Parse(Console.ReadLine());
                                if (sellCount > woodNormal)
                                {
                                    Console.WriteLine($"빛나는 나무를 {woodNormal}개 판매했습니다.");
                                    Console.WriteLine($"{woodNormalPrice * woodNormal:N0}골드 획득!");
                                    playerMoney += woodNormalPrice * woodNormal;
                                    woodNormal = 0;
                                }
                                else
                                {
                                    Console.WriteLine($"빛나는 나무를 {sellCount}개 판매했습니다.");
                                    Console.WriteLine($"{woodNormalPrice * sellCount:N0}골드 획득!");
                                    playerMoney += woodNormalPrice * sellCount;
                                    woodNormal -= sellCount;
                                }
                            }

                            break;
                        case "3": // 장비 교환
                            Console.WriteLine("조만간 업데이트 예정입니다...");
                            Thread.Sleep(1000);
                            break;
                        case "4":
                            Console.WriteLine("마을로 돌아갑니다.");
                            posX += 2;
                            Thread.Sleep(500);
                            continue;
                        default:
                            Console.WriteLine("잘못 선택하셨습니다.");
                            break;
                    }
                }
                while (posX == exitX && posY == exitY)
                {
                    Console.Clear();
                    Console.WriteLine("게임을 종료하시겠습니까?\n");
                    Console.WriteLine("1. 게임 종료");
                    Console.WriteLine("2. 돌아가기");
                    Console.Write(": ");
                    string inputNumber = Console.ReadLine();
                    if (inputNumber == "1")
                    {
                        Environment.Exit(0);
                    }
                    else if (inputNumber == "2")
                    {
                        exitY = exitY + 1;
                        break ;
                    }
                    else
                    {
                        exitY = exitY + 1;
                        break;
                    }
                }

                    keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: if (posY > 3) posY--; break;
                    case ConsoleKey.DownArrow: if (posY < consoleHeight - 2) posY++; break;
                    case ConsoleKey.LeftArrow: if (posX > 0) posX = posX - 2; break;
                    case ConsoleKey.RightArrow: if (posX < consoleWidth - 2) posX = posX + 2; break;
                    case ConsoleKey.P:
                        double attackSpeed = 1000 / attackDelay;
                        Console.Clear();
                        Console.WriteLine("===== 캐릭터 정보 =====");
                        Console.WriteLine($"닉네임: {playerName}");
                        Console.WriteLine($"착용 도끼 등급: {equipEx}");
                        Console.WriteLine($"공격 속도: {attackSpeed}");
                        Console.WriteLine($"소지금: {playerMoney}골드");
                        Console.WriteLine("");
                        Console.WriteLine("캐릭터 정보 닫기 : Press Enter Key...");
                        string inputNumber = Console.ReadLine();
                        break;
                    case ConsoleKey.I:
                        Console.Clear();
                        Console.WriteLine("===== 인벤토리 =====");
                        Console.WriteLine($"레전드 도끼: {weaponLegend}개");
                        Console.WriteLine($"유니크 도끼: {weaponUnique}개");
                        Console.WriteLine($"에픽 도끼: {weaponEpic}개");
                        Console.WriteLine($"레어 도끼: {weaponRare}개");
                        Console.WriteLine($"일반 도끼: {weaponNormal}개");
                        Console.WriteLine($"빛나는 나무: {woodUnique}개");
                        Console.WriteLine($"질 좋은 나무: {woodRare}개");
                        Console.WriteLine($"나뭇가지: {woodNormal}개");
                        Console.WriteLine($"소지금: {playerMoney}골드");
                        Console.WriteLine("");
                        Console.WriteLine("인벤토리 닫기 : Press Enter Key...");
                        inputNumber = Console.ReadLine();
                        break;
                        // case ConsoleKey.Spacebar: selectNum = 0; break;
                        //case ConsoleKey.Escape:
                        //    Console.Clear();
                        //    Console.WriteLine("게임을 종료하시겠습니까? (Any/x");
                        //    inputNumber = Console.ReadLine();
                        //    if(inputNumber == "x" || inputNumber == "X")
                        //    {
                        //        break;
                        //    }
                        //    else
                        //    {
                        //        goto exit;
                        //    }
                }
            }

        }
    }
}
