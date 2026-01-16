using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    // 클래스끼리 통신
    class Player
    {
        public int hp;
        public int att;

        public void Render()
        {
            Console.WriteLine("player");
            Console.WriteLine($"체력: {hp}");
            Console.WriteLine($"공격력: {att}");
        }
    }

    class Monster
    {
        public int hp;
        public int att;

        public void Render()
        {
            Console.WriteLine("Monster");
            Console.WriteLine($"체력: {hp}");
            Console.WriteLine($"공격력: {att}");
        }
    }

    class PrivatePlayer
    {
        private int hp;
        private int att;

        public void SetHp(int _hp)
        {
            this.hp = _hp;
        }

        public int GetHp() {  return hp; }

        public void SetAtt(int _att)
        {
            this.att = _att;
        }

        public int GetAtt() { return att; }

        public void Render()
        {
            Console.WriteLine("플레이어");
            Console.WriteLine("체력 : " + hp);
            Console.WriteLine("공격력 : " + att);
        }


    }

    class PrivateMonster
    {
        private int hp;
        private int att;

        public void SetHp(int _hp)
        {
            this.hp = _hp;
        }

        public int GetHp() { return hp; }

        public void SetAtt(int _att)
        {
            this.att = _att;
        }

        public int GetAtt() { return att; }

        public void Render()
        {
            Console.WriteLine("몬스터");
            Console.WriteLine("체력 : " + hp);
            Console.WriteLine("공격력 : " + att);
        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {

            Player player = new Player();
            player.att = 10;
            player.hp = 100;
            player.Render();

            Monster monster = new Monster();
            monster.att = 5;
            monster.hp = 100;
            monster.Render();

            monster.hp = monster.hp - player.att;
            player.hp = player.hp - monster.att;

            player.Render();
            monster.Render();

            PrivatePlayer privatePlayer = new PrivatePlayer();
            privatePlayer.SetAtt(10);
            privatePlayer.SetHp(100);
            privatePlayer.Render();

            PrivateMonster privateMonster = new PrivateMonster();
            privateMonster.SetAtt(5);
            privateMonster.SetHp(100);
            privateMonster.Render();

            // 플레이어가 몬스터 때리기
            privateMonster.SetHp(privateMonster.GetHp() - privatePlayer.GetAtt());
            // 몬스터가 플레이어 때리기
            privatePlayer.SetHp(privatePlayer.GetHp() - privateMonster.GetAtt());


        }
    }
}
