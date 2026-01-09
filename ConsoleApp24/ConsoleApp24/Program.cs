using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 가변 배열
            string[][] raid = new string[3][];

            raid[0] = new string[] { "전사", "힐러", "마법사", "궁수" }; // 4명
            raid[1] = new string[] { "도적", "전사", "힐러" }; // 3명
            raid[2] = new string[] { "마법사", "궁수", "힐러", "전사", "탱커" }; // 5명

            Console.WriteLine("=== 레이드 파티 구성 ===");
            for (int i = 0; i < raid.Length; i++)
            {
                Console.WriteLine($"파티{i + 1} ({raid[i].Length}명): ");
                for (int j = 0; j < raid[i].Length; j++)
                {
                    Console.WriteLine($" - {raid[i][j]}");
                }
            }


            // 동적 배열
            // List : C#에서 가낭 많이 사용되는 동적배열 컬렉션
            // System.Collection.Generic 네임스페이스에 포함
            // 특징      |  배열  | List<T>
            // 크기      |  고정  |자동 조절
            // 추가/삭제 |  불가능 |  가능
            // 성능      |약간 빠름|약간 느림
            // 편의성    |  기본  |다양한 메서드 제공

            // 선언 방법
            List<int> numbers = new List<int>();           // 빈 리스트
            List<string> names = new List<string>();       // 문자열 리스트
            List<float> prices = new List<float>();        // 실수 리스트

            // 초기값과 함께 선언
            List<int> scores = new List<int> { 85, 90, 78, 95 };
            List<string> items = new List<string> { "검", "방패", "포션" };

            // C# 3.0 이후 간단한 초기화
            var players = new List<string> { "철수", "영희", "민수" };

            items = new List<string>();

            // Add: 끝에 추가
            items.Add("회복 포션");
            items.Add("마나 포션");

            // =================================================================================
            List<string> inventory = new List<string>();

            Console.WriteLine("=== 도적 인벤토리 시스템 ===");

            // 아이템 추가 (Add)
            inventory.Add("회복 포션");
            inventory.Add("마나 포션");
            inventory.Add("강철 검");
            Console.WriteLine("아이템 3개 추가");
            // 현재 인벤토리
            Console.WriteLine($"\n인벤토리 ({inventory.Count}개):");
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {inventory[i]}");
            }

            // Add함수 등으로 배열의 공간을 만들어 두었다면 index번호를 활용하여 값을 변경할 수 있다.
            inventory[0] = "초록 포션";
            Console.WriteLine($"\n인벤토리 ({inventory.Count}개):");
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {inventory[i]}");
            }

            // 특정 위치에 추가(Insert) // 덮어씌운게 아닌 늘어난 것이다.
            inventory.Insert(1, "전설 검");

            Console.WriteLine($"\n인벤토리 ({inventory.Count}개):");
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {inventory[i]}");
            }

            // 아이템 제거 (Remove)
            inventory.Remove("초록 포션");

            Console.WriteLine($"\n인벤토리 ({inventory.Count}개):");
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {inventory[i]}");
            }

            // 모두 삭제 RemoveAll
            // 특정 인덱스만 삭제 RemoveAt
            inventory.RemoveAt(0);
            inventory.RemoveAt(inventory.Count - 1);
            Console.WriteLine($"\n인벤토리 ({inventory.Count}개):");
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {inventory[i]}");
            }


        }
    }
}
