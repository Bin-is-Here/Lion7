using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    // 미사일 클래스
    public class BULLET
    {
        public int posX;
        public int posY;
        public bool isFire;
    }

    // 플레이어 클래스
    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch(); //c언어 함수 가져옴

        public int playerPosX; // 플레이어 X좌표
        public int playerPosY; // 플레이어 Y좌표

        public BULLET[] playerBullet = new BULLET[20]; // 20개를 먼저 생성 후 준비된 미사일을 활용 유니티로 오브젝트풀
        public BULLET[] playerBulletLeft = new BULLET[20];
        public BULLET[] playerBulletRight = new BULLET[20];
        public int score = 0;

        // 아이템 객체 생성
        public Item item = new Item();
        public int itemCount = 0;

        public Player() // 생성자
        {
            // 플레이어 좌표 초기화
            playerPosX = 0;
            playerPosY = 12;

            for (int i = 0; i < playerBullet.Length; i++) // 총알 20개 초기화
            {
                playerBullet[i] = new BULLET(); // 객체 생성
                playerBullet[i].posX = 0;
                playerBullet[i].posY = 0;
                playerBullet[i].isFire = false;

                playerBulletLeft[i] = new BULLET(); // 객체 생성
                playerBulletLeft[i].posX = 0;
                playerBulletLeft[i].posY = 0;
                playerBulletLeft[i].isFire = false;

                playerBulletRight[i] = new BULLET(); // 객체 생성
                playerBulletRight[i].posX = 0;
                playerBulletRight[i].posY = 0;
                playerBulletRight[i].isFire = false;
            }

        }



        public void GameMain()
        {
            // 키 입력 부분
            KeyControl();
            // 플레이어 그리기
            PlayerDraw();
            // UI점수
            UIScore();

            if (item.itemLife)
            {
                //item.itemMove();
                item.ItemDraw();
                // 아이템 충돌
                CrashItem();
            }

        }

        public void CrashItem()
        {
            if(playerPosY + 1 == item.itemPosY)
            {
                if(playerPosX >= item.itemPosX - 2 && playerPosX <= item.itemPosX + 2)
                {
                    item.itemLife = false;

                    if (itemCount < 3) itemCount++;
                    for(int i = 0; i < playerBullet.Length; i++)
                    {
                        playerBullet[i] = new BULLET(); //객체생성
                        playerBullet[i].posX = 0;
                        playerBullet[i].posY = 0;
                        playerBullet[i].isFire = false;

                        playerBulletLeft[i] = new BULLET(); //객체생성
                        playerBulletLeft[i].posX = 0;
                        playerBulletLeft[i].posY = 0;
                        playerBulletLeft[i].isFire = false;

                        playerBulletRight[i] = new BULLET(); //객체생성
                        playerBulletRight[i].posX = 0;
                        playerBulletRight[i].posY = 0;
                        playerBulletRight[i].isFire = false;
                    }
                }
            }
        }

        public void KeyControl()
        {
            int pressKey; // 정수형 변수 선언 키값 받음

            if (Console.KeyAvailable) // 키가 눌렸을 때
            {
                pressKey = _getch(); // 아스키값
                if (pressKey == 224) pressKey = _getch();

                switch (pressKey)
                {
                    case 72: // 위쪽
                        playerPosY--;
                        if (playerPosY < 1)
                            playerPosY = 1;
                        break;
                    case 75: // 왼쪽
                        playerPosX--;
                        if (playerPosX < 0)
                            playerPosX = 0;
                        break;
                    case 77: // 오른쪽
                        playerPosX++;
                        if (playerPosY > 75)
                            playerPosY = 75;
                        break;
                    case 80: // 아래쪽
                        playerPosY++;
                        if (playerPosY > 21)
                            playerPosY = 21;
                        break;
                    case 32: // 스페이스바
                        //총알 발사
                        for (int i = 0; i < playerBullet.Length; i++)
                        {
                            // 미사일이 false일 때 발사 가능
                            if (playerBullet[i].isFire == false)
                            {
                                playerBullet[i].isFire = true;
                                // 플레이어 앞에서 미사일 발사
                                playerBullet[i].posX = playerPosX + 5;
                                playerBullet[i].posY = playerPosY + 1;
                                // 한발씩 쏠거임
                                break;
                            }

                        }
                        // 총알 왼쪽
                        for (int i = 0; i < 20; i++)
                        {
                            //미사일이 false 발사가능
                            if (playerBulletLeft[i].isFire == false)
                            {
                                playerBulletLeft[i].isFire = true;
                                //플레이어 앞에서 미사일 쏘기 + 5
                                playerBulletLeft[i].posX = playerPosX + 5;
                                playerBulletLeft[i].posY = playerPosY;
                                //한발씩 쏘겠다.
                                break;
                            }
                        }
                        // 총알 오른쪽
                        for (int i = 0; i < 20; i++)
                        {
                            //미사일이 false 발사가능
                            if (playerBulletRight[i].isFire == false)
                            {
                                playerBulletRight[i].isFire = true;
                                //플레이어 앞에서 미사일 쏘기 + 5
                                playerBulletRight[i].posX = playerPosX + 5;
                                playerBulletRight[i].posY = playerPosY + 2;
                                //한발씩 쏘겠다.
                                break;
                            }
                        }
                        break;


                }

            }
        }

        // 미사일 그리기
        public void BulletDraw()
        {
            string bullet = "->"; // 미사일 모습

            for (int i = 0; i < playerBullet.Length; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet[i].isFire == true)
                {
                    // 좌표 설정 -> 중간 위치 보정을 위해 x - 1, 충돌 미스 방지
                    Console.SetCursorPosition(playerBullet[i].posX - 1, playerBullet[i].posY);

                    // 총알 출력
                    Console.Write(bullet);

                    playerBullet[i].posX++; // 미사일 오른쪽으로 날아가기

                    if (playerBullet[i].posX > 78)
                    {
                        playerBullet[i].isFire = false; // 미사일 다시 발사 준비 상태
                    }

                }
            }
        }
        //미사일 그리기2
        public void BulletDraw2()
        {
            string bullet = "->"; //미사일모습

            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBulletLeft[i].isFire == true)
                {
                    //좌표설정 -> 중간위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(playerBulletLeft[i].posX - 1, playerBulletLeft[i].posY);
                    //총알 출력
                    Console.Write(bullet);

                    playerBulletLeft[i].posX++; //미사일 오른쪽으로 날라가기

                    if (playerBulletLeft[i].posX > 78)
                    {
                        playerBulletLeft[i].isFire = false;  //미사일 false 다시 준비상태
                    }
                }
            }
        }
        // 미사일 그리기3
        public void BulletDraw3()
        {
            string bullet = "->"; //미사일모습

            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBulletRight[i].isFire == true)
                {
                    //좌표설정 -> 중간위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(playerBulletRight[i].posX - 1, playerBulletRight[i].posY);
                    //총알 출력
                    Console.Write(bullet);

                    playerBulletRight[i].posX++; //미사일 오른쪽으로 날라가기

                    if (playerBulletRight[i].posX > 78)
                    {
                        playerBulletRight[i].isFire = false;  //미사일 false 다시 준비상태
                    }
                }
            }
        }

        public void PlayerDraw()
        {
            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            }; // 배열 문자열로 그리기

            for (int i = 0; i < player.Length; i++)
            {
                // 콘솔 좌표 설정 player PosX, PosY
                Console.SetCursorPosition(playerPosX, playerPosY + i);
                // 문자열 배열 출력
                Console.WriteLine(player[i]);
            }
        }

        public void UIScore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : " + score);
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }

        // 충돌처리
        public void CrashEnemyAndBullet(Enemy enemy)
        {
            for(int i = 0; i < playerBullet.Length; i++)
            {
                // 살아있는 미사일
                if (playerBullet[i].isFire == true)
                {
                    // 미사일과 적의 y값이 같을 때
                    if (playerBullet[i].posY == enemy.enemyPosY)
                    {
                        if (playerBullet[i].posX >= (enemy.enemyPosX - 1) && playerBullet[i].posX <= (enemy.enemyPosX + 1)) // 충돌
                        {
                            // 아이템
                            item.itemLife = true;
                            item.itemPosX = enemy.enemyPosX;
                            item.itemPosY = enemy.enemyPosY;


                            Random rand = new Random();
                            enemy.enemyPosX = 75;
                            enemy.enemyPosY = rand.Next(2, 22);

                            playerBullet[i].isFire = false; // 미사일 준비상태로 되돌리기

                            score += 100; // 점수 스코어
                        }
                    }
                }
            }
            // 미사일2
            for (int i = 0; i < playerBullet.Length; i++)
            {
                // 살아있는 미사일
                if (playerBulletLeft[i].isFire == true)
                {
                    // 미사일과 적의 y값이 같을 때
                    if (playerBulletLeft[i].posY == enemy.enemyPosY)
                    {
                        if (playerBulletLeft[i].posX >= (enemy.enemyPosX - 1) && playerBulletLeft[i].posX <= (enemy.enemyPosX + 1)) // 충돌
                        {
                            // 아이템
                            item.itemLife = true;
                            item.itemPosX = enemy.enemyPosX;
                            item.itemPosY = enemy.enemyPosY;


                            Random rand = new Random();
                            enemy.enemyPosX = 75;
                            enemy.enemyPosY = rand.Next(2, 22);

                            playerBulletLeft[i].isFire = false; // 미사일 준비상태로 되돌리기

                            score += 100; // 점수 스코어
                        }
                    }
                }
            }
            // 미사일3
            for (int i = 0; i < playerBullet.Length; i++)
            {
                // 살아있는 미사일
                if (playerBulletRight[i].isFire == true)
                {
                    // 미사일과 적의 y값이 같을 때
                    if (playerBulletRight[i].posY == enemy.enemyPosY)
                    {
                        if (playerBulletRight[i].posX >= (enemy.enemyPosX - 1) && playerBulletRight[i].posX <= (enemy.enemyPosX + 1)) // 충돌
                        {
                            // 아이템
                            item.itemLife = true;
                            item.itemPosX = enemy.enemyPosX;
                            item.itemPosY = enemy.enemyPosY;


                            Random rand = new Random();
                            enemy.enemyPosX = 75;
                            enemy.enemyPosY = rand.Next(2, 22);

                            playerBulletRight[i].isFire = false; // 미사일 준비상태로 되돌리기

                            score += 100; // 점수 스코어
                        }
                    }
                }
            }
        }

    }

    // 적
    public class Enemy
    {
        public int enemyPosX; //X좌표
        public int enemyPosY; //Y좌표

        public Enemy()
        {
            //적 좌표 초기화
            enemyPosX = 77;
            enemyPosY = 12;
        }

        public void EnemyDraw()//적그리기
        {
            string enemy = "<-0->"; //문자열로 표현
            Console.SetCursorPosition(enemyPosX, enemyPosY);
            Console.Write(enemy); //출력
        }

        public void EnemyMove()
        {
            Random rand = new Random(); //랜덤
            enemyPosX--; //왼쪽으로 움직임

            if (enemyPosX < 2) //화면 왼쪽 넘어가면 새로 좌표 잡기
            {
                enemyPosX = 75;
                enemyPosY = rand.Next(2, 22); //2~21
            }
        }
    }

    // 아이템 클래스
    public class Item
    {
        public string itemName;
        public string itemSprite;
        public int itemPosX = 0;
        public int itemPosY = 0;
        public bool itemLife = false;

        public void ItemDraw()
        {
            Console.SetCursorPosition(itemPosX, itemPosY);
            itemSprite = "item★";
            Console.Write(itemSprite);
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            // 플레이어 생성
            Player player = new Player();
            Enemy enemy = new Enemy(); // 적 생성

            // 콘솔 속도 만들기 frame 속도 (60fps)
            int dwTime = Environment.TickCount; // 1/1000초

            while (true)
            {
                // 0.05초 지연
                if(dwTime + 50 < Environment.TickCount)
                {
                    // 현재 시간 세팅
                    dwTime = Environment.TickCount;
                    Console.Clear();

                    // 플레이어
                    player.GameMain();
                    // 총알
                    if (player.itemCount == 0)
                    {
                        player.BulletDraw();
                    }
                    else if (player.itemCount == 1)
                    {
                        player.BulletDraw2();
                        player.BulletDraw3();
                    }
                    else
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                        player.BulletDraw3();
                    }
                    // 적 이동
                    enemy.EnemyMove();
                    // 적 그리기
                    enemy.EnemyDraw();

                    // 충돌처리
                    player.CrashEnemyAndBullet(enemy);


                } // 0.05초 루프 생성
            }


        }
    }

}