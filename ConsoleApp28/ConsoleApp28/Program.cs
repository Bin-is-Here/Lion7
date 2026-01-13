using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp28
{
    internal class Program
    {

        // 메서드 오버로딩
        // 매개변수의 갯수가 다른경우 같은 함수 이름을 사용할 수 있다.
        static void Attack()
        {
            Console.WriteLine("기본공격");
            Console.WriteLine("데미지: 50");
        }
        static void Attack(string target)
        {
            Console.WriteLine($"{target} 기본공격");
            Console.WriteLine("데미지: 50");
        }

        //static string Attack(string target)
        //{
        //    Console.WriteLine($"{target} 기본공격");
        //    Console.WriteLine("데미지: 50");
        //    return "aa";
        //} // 매개변수만 다른경우는 불가능. 오류 발생.
        static void Attack(string target, int damage)
        {
            Console.WriteLine($"{target} 기본공격");
            Console.WriteLine($"데미지: {damage}");
        }

        // 스킬 공격(매개변수 3개) -> 오버로딩 사용하여 수정하기
        //static void Attack()
        //{
        //    Console.WriteLine($"✨ 스킬 발동: {skillName}");
        //    Console.WriteLine($"⚔️ {target}에게 {damage} 데미지!");
        //}
        static void Attack(string skillName, string target, int damage)
        {
            Console.WriteLine($"✨ 스킬 발동: {skillName}");
            Console.WriteLine($"⚔️ {target}에게 {damage} 데미지!");
        }



        // 기본 매개변수(Default Parameters) 매개변수에 기본값을 지정하면 호출 시 생략이 가능하다.
        static void CastFireBall(string target, int damage = 100, int manaCost = 30) // 값을 초기화 하듯이 값을 넣는다.
        {
            Console.WriteLine($" 파이어볼 시전!");
            Console.WriteLine($" 대상: {target}");
            Console.WriteLine($" 데미지: {damage}");
            Console.WriteLine($" 마나 - {manaCost}");
        }


        // 예제 아이템 사용 함수
        static void UseItem(string itemName, int heal)
        {
            Console.WriteLine($"{itemName} 사용!");
            Console.WriteLine($"회복량: {heal} HP");
        }

        // 예제 소환 마법 함수
        static void SummonMonster(string monsterName, int monsterLevel ,int count = 1)
        {
            Console.WriteLine($"{monsterName} 소환!");
            Console.WriteLine($"레벨: {monsterLevel}");
            Console.WriteLine($"수량: {count}마리");
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // 메서드 오버로딩
            Attack();
            Console.WriteLine();
            Attack("몬스터");
            Console.WriteLine();
            Attack("몬스터, 100");

            // 스킬 공격
            Attack("강한공격", "몬스터", 200);

            Console.WriteLine();

            // 기본 매개변수 활용
            CastFireBall("고블린", 150, 40);
            Console.WriteLine();
            CastFireBall("오크", 20);
            Console.WriteLine();
            CastFireBall("드래곤");
            Console.WriteLine();
            // CastFireBall("슬라임", , 50); // 이렇게는 불가능.
            CastFireBall("슬라임", manaCost: 50); // 매개변수를 직접 호출하여 직접 대입하면 원하는 것만 변경이 가능

            Console.WriteLine();

            Console.WriteLine("=== 아이템 사용===\n");
            UseItem("회복포션", 50);
            UseItem("고급 회복포션", 100);
            Console.WriteLine("=== 소환 마법===\n");
            SummonMonster("슬라임", 1);
            SummonMonster("고블린", 5);
            SummonMonster("드래곤", 50, 3);



        }
    }
}
