using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{

    // 캐릭터 클래스 정의
    class Character
    {
        // 필드(Field): 클래스의 데이터(클래스의 변수)
        public string name;
        public int level;
        public int hp;
        public int maxHp;
        public int mp;
        public int maxMp;
        public int exp;
        public int maxExp;



        // 메서드(Method): 클래스의 기능(클래스의 함수)
        // 캐릭터 스탯 출력
        public void CharacterInfo()
        {
            double expPer = (double)exp / (double)maxExp;

            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"체력: {hp}/{maxHp}");
            Console.WriteLine($"마나: {mp}/{maxMp}");
            Console.WriteLine($"경험치: {exp}/{maxExp} {expPer}%");
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
        }

        // 공격 & 스킬 구현
        public void Takedamage(int damage)
        {
            hp -= damage;
            if (hp < 0) hp = 0;
            Console.WriteLine($"⚔️ {name}이(가) {damage} 피해를 받았습니다!");
            Console.WriteLine($"    현재 체력 : {hp}/{maxHp}");
            if (hp == 0)
            {
                Console.WriteLine("캐릭터가 사망하였습니다.");
            }
        }

        public void Heal(int amount)
        {
            hp += amount;
            if(hp > maxHp) hp = maxHp;
            Console.WriteLine($"💚 {name}의 체력이 {amount} 회복되었습니다!");
            Console.WriteLine($"    현재 체력 : {hp}/{maxHp}");
        }
        

        // 
        public Character(string _name)
        {
            name = _name;
            level = 1;
            hp = 100;
            maxHp = 100;
            mp = 50;
            maxMp = 50;
        }

    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // 객체 생성
            Character player = new Character("궁수");

            // 필드에 값 할당
                // 클래스에 생성자로 구현했음.
                // player1.name = "홍길동";
                // player1.level = 10;
                // player1.hp = 150;
                // player1.maxHP = 150;
                // player1.mp = 80;
                // player1.maxMP = 80;

            player.CharacterInfo();

            player.Takedamage(50);
            player.Heal(30);
            player.Takedamage(player.maxHp);

            // 새로운 객체 생성 및 임의 값 입력 후 출력
            Character player2 = new Character("마법사");

            player2.maxMp = 200;
            player2.mp = 200;

            player2.CharacterInfo();


        }
    }
}
