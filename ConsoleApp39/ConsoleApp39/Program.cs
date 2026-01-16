using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Character
    {
        private string name;
        private int gold;
        private int attack;
        private int maxHP = 100;

        // Get Set 함수
        public void SetAtt(int _att) // 외부에서 값을 변경하는 함수
        {
            attack = _att;
        }

        public int GetAtt() // 외부에 값을 반환하는 함수
        {
            return attack;
        }


        // 전체 프로퍼티
        private int att;
        public int Att
        {
            get { return att; }
            set
            {
                if (value < 0) att = 0;
                else att = value;
            }
        }

        // 자동 프로퍼티
        public int Level { get; set; }

        // 읽기 전용
        public int MaxHP
        {
            get { return maxHP; }
            private set { maxHP = value; }
        }


        public string Name { get { return name; } set { name = value; } }

        public int Gold {
            get { return gold; }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("골드가 부족합니다.");
                }
                else
                {
                    gold = value;
                }
            } 
        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // get set 함수 사용
            Character player = new Character();
            player.SetAtt(10);
            Console.WriteLine("공격력: "+ player.GetAtt());

            // 기본 프로퍼티 사용
            Character player2 = new Character();
            player2.Att = 15;
            Console.WriteLine("공격력: " + player2.Att);

            // 자동 프로퍼티 사용
            Character player3 = new Character();
            player3.Level = 3;
            Console.WriteLine("레벨: " + player3.Level);
            Console.WriteLine($"최대체력 : {player3.MaxHP}");

            Character player4 = new Character();
            player4.Name = "홍길동";
            player4.Gold = -100;

            Console.WriteLine($"이름 : {player4.Name}");
            Console.WriteLine($"골드 : {player4.Gold}");

        }
    }
}
