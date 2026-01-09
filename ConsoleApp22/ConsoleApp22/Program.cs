using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // 반복문 기초에서 중요한 부분 - 게임을 구현하는 기초를 이해

            // 배열 - 보다 효율적으로 코드를 작성할 수 있는가에 대한 이해
            // - 학습 목표
            // - 다차원 배열로 2D 맵을 표현할 수 있다.
            // - List<T>로 동적 컬렉션을 관리할 수 있다.
            // - Dictionary로 키-값 쌍을 저장할 수 있다.
            // - foreach문으로 컬렉션을 순회할 수 있다.

            // 배열은 마치 사물함과 같습니다:
            // 사물함 번호로 각 칸을 구분(인덱스)
            // 모든 칸의 크기가 동일(같은 타입)
            // 한 번 만들면 칸 개수 변경 불가(고정 크기)

            // 📖 배열의 특징


            // 고정 크기: 선언 시 크기 결정, 변경 불가
            // 인덱스 접근: 0부터 시작하는 인덱스로 접근
            // 같은 타입: 모든 요소가 동일한 데이터 타입
            // 빠른 접근: 인덱스로 즉시 접근 가능

            //// 방법1
            //int count = 5;
            //int[] scores = new int[count];

            //scores[0] = 1; // 배열에 값 넣기
            //scores[1] = 2;
            //scores[2] = 3;
            //scores[3] = 4;
            //scores[4] = 5;
            //// scores[5] = 6; // overflow(OutOfRangeException) 오류 발생

            //// 방법2 : 초기값과 함께 선언
            //int[] numbers = new int[] { 10, 20, 30, 40, 50 };

            //// 방법3 : 간단한 초기화
            //int[] values = { 1, 2, 3, 4, 5 }; // 문법을 생략하여 간단히 작성

            //// 배열 값 출력
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine(scores[i]);
            //}

            //// 인벤토리 시스템(최대 5개)
            //string[] inventory = new string[5];

            //// 아이템 추가
            //inventory[0] = "회복 포션";
            //inventory[1] = "마나 포션";
            //inventory[2] = "강철 검";
            //inventory[3] = "가죽 갑옷";
            //inventory[4] = "마법 반지";

            //// 인벤토리 출력
            //Console.WriteLine("=== 인벤토리 ===");

            //for (int i = 0; i < inventory.Length; i++)
            //{
            //    Console.WriteLine($"[{i + 1}] {inventory[i]}");
            //}

            //// 아이템 추가. 입력을 받아서 추가하기
            //Console.WriteLine("\n");

            //string[] inven = new string[5];

            //for (int i = 0;i < inven.Length; i++)
            //{
            //    Console.Write($"{i+1}번째 추가할 아이템 입력 : ");
            //    string addItem = Console.ReadLine();
            //    inven[i] = addItem;
            //}

            //Console.WriteLine("\n===== 인벤토리 =====");

            //for (int i = 0; i < inven.Length; i++)
            //{
            //    Console.WriteLine($"[{i + 1}] {inven[i]}");
            //}

            //// 특정 아이템 사용
            //Console.WriteLine($"{inven[0]}를 사용했습니다.!");
            //inven[0] = "(비어있음)";

            //Console.WriteLine("\n===== 인벤토리 =====");

            //for (int i = 0; i < inven.Length; i++)
            //{
            //    Console.WriteLine($"[{i + 1}] {inven[i]}");
            //}

            // 플레이어 스탯 배열
            string[] playerStatusName = new string[5]; 
            playerStatusName[0] = "HP";
            playerStatusName[1] = "MP";
            playerStatusName[2] = "공격력";
            playerStatusName[3] = "방어력";
            playerStatusName[4] = "민첩";

            int[] playerStatusNum = { 100, 50, 80, 60, 45 };

            Console.WriteLine("\n===== 캐릭터 스탯 =====");

            for (int i = 0; i < playerStatusName.Length && i < playerStatusNum.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {playerStatusName[i]}: {playerStatusNum[i]}");
            }

            
            Console.WriteLine("\n===일일 퀘스트 진행도===");
            string[] monster = new string[] { "고블린", " 오 크", "슬라임", "드래곤", " 좀 비" };
            int[] killCount = { 5, 3, 8, 2, 7 };
            int required = 5;

            for (int i = 0; i < monster.Length && i < killCount.Length; i++)
            {
                string status = killCount[i] >= required ? "✅ 완료" : "⏳ 진행중...";
                Console.WriteLine($"{monster[i]} : {killCount[i]}/{required} {status}");
                //if (killCount[i] >= required)
                //{
                //    Console.WriteLine("✅ 완료");
                //}
                //else
                //{
                //    Console.WriteLine("⏳ 진행중...");
                //}
            }

            Console.WriteLine("\n");
            int[] scores = { 85, 92, 78, 95, 88 };

            // 배열 길이
            Console.WriteLine("총 점수 개수: " + scores.Length);
            // 배열 순회
            Console.WriteLine("개별 점수: ");
            for(int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"플레이어 { i + 1 } : {scores[i]}점");
            }
            // 합계 계산
            int sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            Console.WriteLine($"총점: {sum}점");
            Console.WriteLine($"평균: {(double)sum / (double)scores.Length}점");

            // 최고점 찾기
            int highScore = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                
                if ( scores[i] > highScore)
                {
                    highScore = scores[i];
                }
            }
            Console.WriteLine($"최고점: {highScore}점");

            // 최저점 찾기
            int lowScore = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {

                if (scores[i] < lowScore)
                {
                    lowScore = scores[i];
                }
            }
            Console.WriteLine($"최저점: {lowScore}점");

            // Array 클래스 메서드 활용
            Console.WriteLine("\n=== Array 메서드 ===");

            // 정렬
            int[] sortedScore = (int[])scores.Clone(); // 복사본 생성

            // 작은것부터 큰것 순서로 정렬(오름차순)
            Array.Sort(sortedScore);
            Console.WriteLine("오름차순 정렬: ");

            for (int i = 0;i < sortedScore.Length; i++)
            {
                Console.WriteLine(sortedScore[i]);
            }

            // for문보다 간결하게 코드 작성 가능
            // foreach문 : 반복문
            foreach (int scoreVar in sortedScore) // scoreVar라는 임의의 변수를 만들어서 sortedScore배열을 순회
            {
                Console.WriteLine(scoreVar);
            }


            // 큰것부터 작은것 순서로 정렬(내림차순)
            Array.Reverse(sortedScore);
            Console.WriteLine("내림차순 정렬: ");

            for (int i = 0; i < sortedScore.Length; i++)
            {
                Console.WriteLine(sortedScore[i]);
            }

            // for문보다 간결하게 코드 작성 가능
            // foreach문 : 반복문
            foreach(int scoreVar in sortedScore)
            {
                Console.WriteLine(scoreVar);
            }

            // 검색
            int searchScore = 92;
            int index = Array.IndexOf(scores, searchScore);
            Console.WriteLine($"{searchScore}점의 위치: 인덱스 {index}");
            Console.WriteLine($"찾은 값 : {scores[index]}"); 




        }
    }
}
