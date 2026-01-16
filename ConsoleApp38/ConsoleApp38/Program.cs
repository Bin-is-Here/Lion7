using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Monster
    {
        private string name;
        private int level;
        private int hp;
        private int attack;
        private int defence;
        private int expReward;


        public Monster()
        {
            name = "슬라임";
            level = 1;
            hp = 50;
            attack = 10;
            defence = 5;
            expReward = 10;
        }
        public Monster(string _name, int _level)
        {
            name= _name;
            level = _level;
            hp = 50 * level;
            attack = 10 * level;
            defence = 5* level;
            expReward = 10* level;
        }

        public void MonsterInfo()
        {
            Console.WriteLine($"👾 {name} (Lv.{level})");
            Console.WriteLine($"   HP: {hp}");
            Console.WriteLine($"   공격력: {attack}");
            Console.WriteLine($"   방어력: {defence}");
            Console.WriteLine($"   경험치: {expReward}");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Monster slime = new Monster();
            Monster monster2 = new Monster("고블린", 5);

            slime.MonsterInfo();
            monster2.MonsterInfo();

            Console.WriteLine("=== 필드 몬스터 ===\n");
            Monster[] monsters = new Monster[3]; // 클래스로 배열도 가능하다....... << 여기까지는 배열(사물함 3개 생성), 값이 아직 들어있지 않음
            monsters[0] = new Monster("늑대", 3); // 값을 넣어 주어야 사용이 가능하다.
            monsters[1] = new Monster("오크", 7);
            monsters[2] = new Monster("트롤", 10);

            for(int i = 0; i < monsters.Length; i++)
            {
                monsters[i].MonsterInfo();
                Console.WriteLine();
            }

        }
    }
}