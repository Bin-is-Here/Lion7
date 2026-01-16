using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{

    // 부모클래스(기반 클래스, Base Class)
    class Parent
    {
        // 공통 맴버
    }

    // 자식클래스(파생 클래스, Derived Class)
    class Child : Parent // : Parant로 상송
    {
        // 상속받은 맴버 + 추가 맴버
    }

    // 메서드 오버라이딩
    class OverrideParent
    {
        public virtual void Method() // virtual: 재정의 가능
        {

        }
    }

    class OverrideChild : OverrideParent
    {
        public override void Method()
        {

        }
    }







    // 부모클래스 : 기본 캐릭터
    class Character
    {
        // public, private, protected -> 상속되어있는 자식이 사용 가능하도록 하는 접근제어자
        protected string name;
        protected int level;
        protected int hp;
        protected int maxHp;
        protected int attack;
        protected int defence;


        public Character(string _characterName)
        {
            name = _characterName;
            level = 0;
            maxHp = 100;
            hp = maxHp;
            attack = 30;
            defence = 20;

            Console.WriteLine($"캐릭터 {name} 생성!");
        }

        public virtual void CharacterInfo()
        {
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"레벨 : {level}");
            Console.WriteLine($"체력 : {hp}/{maxHp}");
            Console.WriteLine($"공격력 : {attack}");
            Console.WriteLine($"방어력 : {defence}");
        }

    }

    // 자식클래스 : 전사
    class Warrior : Character
    {
        private int rage; // 전사만의 고유 속성

        public Warrior(String _name) : base(_name) // base 키워드로 부모 생성자 호출 때 매개변수 전달
        {
            name = _name; // base.name과 동일. 부모클래스의 필드를 명시적으로 호출
            attack = 60;
            defence = 40;
            maxHp = 150;
            hp = maxHp;
            rage = 0;

            

            Console.WriteLine("직업 : 전사");
        }


        public override void CharacterInfo()
        {
            base.CharacterInfo(); // 부모 클래스의 CharacterInfo 호출 (base 키워드 사용)
            Console.WriteLine($"분노 : {rage}");
        }

    }



        // 상속관계에서 자식을 호출하면
        // -> 자식 호출
        // -> 부모 생성자 -> 자식 생성자 -> 자식 소멸자 -> 부모 소멸자 순으로 호출

    internal class Program
    {
        static void Main(string[] args)
        {

            Character character = new Character("초보자");

            character.CharacterInfo();
            Console.WriteLine("=====================================");

            Character character2 = new Warrior("누구?"); // 자식으로 new 할당하면
            character2.CharacterInfo(); // 재정의 상태 -> 메서드 오버라이드로 자식 함수 호출

            Warrior warrior = new Warrior("워리어");

            warrior.CharacterInfo();

            // 메서드 오버라이딩



        }
    }
}
