using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{

    class 클래스이름
    {
        // 필드 - 변수(데이터)
        // 메서드 (기능)
    }

    // 데이터와 기능의 결합 : 관련된 데이터와 함수를 하나로 묶음
    // 재사용성 : 같은 클래스로 여러 객체 생성
    // 유지보수 : 코드를 논리적으로 구조화
    // 현실 세계 모델링 : 게임 요소를 직관적으로 표현


    class Character // 클래스 선언
    {
        // public : 다른 지역에서도 사용가능하도록 설정.
        // private : 클래스 자신의 내부에서만 사용할 수 있도록 설정.
        // protected : 같은 클래스와 상속받은 클래스에서 접근 가능
        // internal : 같은 어셈블리 내에서만 접근 가능

        public string name;
        public int level;
        public int hp;
        public int maxHP;
        public int mp;
        public int maxMP;
    }

    class Constructor // 생성자 : 생성함과 동시에 초기화하여 사용하기 편리하게 한다.
    {
        public string name;
        public int level;
        public int hp;
        public int maxHP;
        public int mp;
        public int maxMP;

        public Constructor() // 기본 생성자 : 초기화 용도로 많이 사용
        {
            name = "mage"; // 변수를 내부에서 선언했기 때문에 자료형 생략 가능.
            level = 2;
            hp = 110;
            maxHP = 150;
            mp = 80;
            maxMP = 100;
        }

        public Constructor(string _name, int _level, int _hp, int _maxHP, int _mp, int _maxMP) // 인자가 있는 생성자.
        {
            name = _name;
            level = _level;
            hp = _hp;
            maxHP = _maxHP;
            mp = _maxMP;
            maxMP = _maxMP;
        }


        // 함수를 모아서 사용
        public void PlayerStatus()
        {
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"레벨 : {level}");
            Console.WriteLine($"체력 : {hp}/{maxHP}");
            Console.WriteLine($"마나 : {mp}/{maxMP}");
        }


    }






    internal class Program
    {
        static void Main(string[] args)
        {

            // 객체 생성
            Character player = new Character(); // 메모리까지 할당
            player.name = "player";
            player.level = 1;
            player.hp = 100;
            player.maxHP = 100;
            player.mp = 30;
            player.maxMP = 50;

            Console.WriteLine($"이름 : {player.name}");
            Console.WriteLine($"레벨 : {player.level}");
            Console.WriteLine($"체력 : {player.hp}/{player.maxHP}");
            Console.WriteLine($"마나 : {player.mp}/{player.maxMP}");

            Character player2 = new Character(); // 메모리까지 할당
            player.name = "mage";
            player.level = 2;
            player.hp = 110;
            player.maxHP = 150;
            player.mp = 80;
            player.maxMP = 100;

            Console.WriteLine($"이름 : {player2.name}");
            Console.WriteLine($"레벨 : {player2.level}");
            Console.WriteLine($"체력 : {player2.hp}/{player2.maxHP}");
            Console.WriteLine($"마나 : {player2.mp}/{player2.maxMP}");





            Constructor playerChar = new Constructor(); // 생성자 호출

            Console.WriteLine($"이름 : {playerChar.name}");
            Console.WriteLine($"레벨 : {playerChar.level}");
            Console.WriteLine($"체력 : {playerChar.hp}/{playerChar.maxHP}");
            Console.WriteLine($"마나 : {playerChar.mp}/{playerChar.maxMP}");

            Constructor playerChar2 = new Constructor(); // 생성자 호출

            playerChar2.name = "mage"; // 값 변경
            playerChar2.level = 2;
            playerChar2.hp = 110;
            playerChar2.maxHP = 150;
            playerChar2.mp = 80;
            playerChar2.maxMP = 100;

            Console.WriteLine($"이름 : {playerChar2.name}");
            Console.WriteLine($"레벨 : {playerChar2.level}");
            Console.WriteLine($"체력 : {playerChar2.hp}/{playerChar2.maxHP}");
            Console.WriteLine($"마나 : {playerChar2.mp}/{playerChar2.maxMP}");


            // 인자가 있는 생성자 사용
            Constructor player3 = new Constructor("마법사", 2, 11, 250, 100, 1000);

            Console.WriteLine($"이름 : {player3.name}");
            Console.WriteLine($"레벨 : {player3.level}");
            Console.WriteLine($"체력 : {player3.hp}/{player3.maxHP}");
            Console.WriteLine($"마나 : {player3.mp}/{player3.maxMP}");


            // 인자가 있는 생성자 사용 + 클래스 내부 함수 사용
            Constructor player4 = new Constructor("전사", 10, 800, 1000, 50, 80); // 내부 변수를 private로 설정해도 함수를 public으로 설정하여 외부에서 호출이 가능
            player4.PlayerStatus();

        }
    }
}
