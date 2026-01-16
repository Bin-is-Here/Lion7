using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    // 인터페이스(interface)
    // : 메서드 시그니처만 정의하는 계약서. 구현은 클래스가 담당한다.
    // ex) 인터페이스: 운전 방법(엑셀, 브레이크, 핸들), 구현 클래스: 자동차, 트럭(각자 방식대로 구현)
    // ex) 인터페이스: "공격 가능"(Attack 메서드 요구), 구현: 전사는 검으로, 마법사는 마법으로

    // 추상클래스는 변수, 함수 구현이 가능하다.
    // | 특징         |   추상 클래스          | 인터페이스 |
    // |------        |-------------          |-----------|
    // | 키워드       | abstract class        | interface |
    // | 상속         | 단일 상속만            | 다중 구현 가능 |
    // | 구현         | 일부 메서드 구현 가능   | 메서드 시그니처만 |
    // | 필드         | 가능                   | 불가능(C# 8.0 이전) |
    // | 생성자       | 가능                   | 불가능 |
    // | 접근 제한자   | 가능                  | 모두 public |
    // | 용도         | IS-A 관계             | CAN-DO 관계 |


    interface IAttackable
    {
        void Attack(string target);
        int GetAttackPower();
    }

    interface IDefendable
    {
        void Defend();
        int GetDefensePower();
    }

    class Knight : IAttackable, IDefendable // Alt + Enter로 빠르게 코드 구현. 여러개의 인터페이스를 동시에 상속받을 수도 있다.(유동적)
    {

        public string name;
        public int attackPower;
        public int defensePower;

        public Knight()
        {
            name = "검사";
            attackPower = 10;
        }

        public void Attack(string target)
        {
            Console.WriteLine($"검으로 {target} 공격");
        }

        public void Defend()
        {
            Console.WriteLine($"기사가 방어모드중입니다.");
        }

        public int GetAttackPower()
        {
            return attackPower;
        }

        public int GetDefensePower()
        {
            return defensePower;
        }

    }

    class Mage : IAttackable
    {

        public string name;
        public int intPower;

        public void Attack(string target)
        {
            Console.WriteLine($"마법으로 {target} 공격");
        }

        public int GetAttackPower()
        {
            return intPower;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Knight knight = new Knight();
            knight.Attack("오크");
            knight.Defend();

            Mage mage = new Mage();
            mage.Attack("고블린");

            Console.WriteLine("===========================================");

            // 인터페이스 타입으로 배열 생성
            IAttackable[] attacker = new IAttackable[2];
            attacker[0] = knight;
            attacker[1] = mage;

            IDefendable defender = new Knight();
            defender.Defend();

            foreach(IAttackable att in attacker)
            {
                att.Attack("고블린");
            }


        }
    }
}
