using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Dictionary<TKey, TValue> - 키-값 쌍

            Dictionary<string, int> stats = new Dictionary<string, int>();

            // 데이터 추가
            stats.Add("HP", 100);
            stats.Add("MP", 100);
            stats.Add("공격력", 50);
            stats.Add("방어력", 50);
            stats.Add("민첩", 60);

            // 출력 방법
            Console.WriteLine(stats["HP"]);

            // 순회 출력
            Console.WriteLine("=== 캐릭터 스탯 ===");
            foreach (KeyValuePair<string, int> stat in stats)
            {
                Console.WriteLine($"{stat.Key}\t: {stat.Value}");
            }

            // 키 존재 확인
            Console.Write("검색할 스탯 입력 : ");
            string searchStat = Console.ReadLine();
            if (stats.ContainsKey(searchStat))
            {
                Console.WriteLine(stats[searchStat]);
            }
            else
            {
                Console.WriteLine("해당 스탯이 없습니다.");
            }

            // Dictionary 컬렉션을 이용하여 구현하기

            int playerMoney = 600;

            Dictionary<string, int> item = new Dictionary<string, int>();
            item.Add("회복 포션", 50);
            item.Add("마나 포션", 40);
            item.Add("강철 검", 500);
            item.Add("가죽 갑옷", 300);
            item.Add("마법 반지", 1000);

            Console.WriteLine("=== 상점 아이템===");
            foreach (KeyValuePair<string, int> itemList in item)
            {
                Console.WriteLine($"{itemList.Key}\t: {itemList.Value:N0} 골드");
            }
            Console.Write("구매할 아이템을 입력하세요 : ");
            string buyItem = Console.ReadLine();
            if (item.ContainsKey(buyItem))
            {
                int price = item[buyItem];
                if (playerMoney >= item[buyItem]) {
                    Console.WriteLine($"{buyItem} 구매 성공!");
                    Console.WriteLine($"남은 골드 : {playerMoney - item[buyItem]}");
                }
            }
            else
            {
                Console.WriteLine("해당 아이템이 없습니다");
            }


        }
    }
}
