using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    // 추상클래스 : 불완전한 클래스로, 직접 객체를 생성할 수 없다. 반드시 상속받아 완성
    // ex) 추상: "유닛" = 추상적 개념. 구체적: "전사", "마법사" (실제 생성 가능)
    // 추상클래스 상속을 받고있다면 추상메서드를 상속받아서 꼭 구현해야 한다.

    abstract class AbstractClass // abstract 키워드
    {
        // 일반 맴버
        public int namalField;

        public void NormalField()
        {
            // 구현된 메서드
        }

        // 추상 메서드: 구현 없음
        public abstract void AbstractMethod();
    }

    public abstract class Character
    {
        public int hp;

        public abstract void Job();
    }

    public class Mage : Character
    {
        public override void Job()
        {
            Console.WriteLine("마법사 선택");
        }
    }

    public class Archer : Character
    {
        public override void Job()
        {
            Console.WriteLine("궁수 선택");
        }
    }

    // 유닛 생성 예제
    abstract class Job
    {
        protected string job;
        protected string name;
        protected int hp;
        protected int maxHp;
        protected int speed;

        public Job(string _userName, string _job, int _health, int _moveSpeed)
        {
            name = _userName;
            job = _job;
            maxHp = _health;
            hp = maxHp;
            speed = _moveSpeed;
        }

        public abstract void jobInfo();
    }

    class Warrior : Job
    {
        private int attack;
        private int defense;
        
        public Warrior(string _name, string _job) : base(_name, _job, 200, 5)
        {
            attack = 80;
            defense = 50;
        }

        public override void jobInfo()
        {
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"[{job}] {name}");
            Console.WriteLine($"HP: {hp}/{maxHp}");
            Console.WriteLine($"공격력: {attack}");
            Console.WriteLine($"방어력: {defense}");
            Console.WriteLine($"이동속도: {speed}");
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
        }

    }
    class Wizard : Job
    {
        private int magicPower;
        private int mana;

        public Wizard(string _name, string _job) : base(_name, _job, 120, 4)
        {
            magicPower = 150;
            mana = 100;
        }

        public override void jobInfo()
        {
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"[{job}] {name}");
            Console.WriteLine($"HP: {hp}/{maxHp}");
            Console.WriteLine($"마력: {magicPower}");
            Console.WriteLine($"마나: {mana}");
            Console.WriteLine($"이동속도: {speed}");
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
        }

    }
    class Ranger : Job
    {
        private int rangedAttack;
        private int arrows;

        public Ranger(string _name, string _job) : base(_name, _job, 200, 5)
        {
            rangedAttack = 100;
            arrows = 50;
        }

        public override void jobInfo()
        {
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"[{job}] {name}");
            Console.WriteLine($"HP: {hp}/{maxHp}");
            Console.WriteLine($"공격력: {rangedAttack}");
            Console.WriteLine($"화살: {arrows}");
            Console.WriteLine($"이동속도: {speed}");
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {

            // Character character = new Character(); -> 추상 클래스는 객체 생성 못함

            Mage mage = new Mage();
            mage.Job();

            Character archer = new Archer(); // 업캐스팅


            // 그룹화하여 출력하기 좋음
            Character[] ch = new Character[2];
            ch[0] = new Mage();
            ch[1] = new Archer();

            for(int i = 0; i < ch.Length; i++)
            {
                ch[i].Job();
            }

            foreach(Character c in ch)
            {
                c.Job();
            }

            Console.WriteLine("\n=== 유닛 생성 ===");
            Job[] units = new Job[3];
            units[0] = new Warrior("홍길동", "전사");
            units[1] = new Wizard("김마법", "마법사");
            units[2] = new Ranger("이궁수", "궁수");

            foreach(Job unit in units)
            {
                unit.jobInfo();
                Console.WriteLine();
            }


        }
    }
}
