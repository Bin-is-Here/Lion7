using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    public class Monster
    {
        public Information m_tMonster; // 몬스터 데이터

        public void SetDamage(int iAttack) { m_tMonster.iHp -= iAttack; }

        // Information클래스 타입 인자로 몬스터 데이터를 넣어준다.
        public void SetMonster(Information tMonster) { m_tMonster = tMonster; }
        public Information GetMonster() { return m_tMonster; }

        public void Render()
        {
            Console.WriteLine("=========================");
            Console.WriteLine($"직업 이름: {m_tMonster.strName}");
            Console.WriteLine($"체력: {m_tMonster.iHp}\t공격력: {m_tMonster.iAttack}");
        }

        public Monster() { }
        ~Monster() { }






    }
}
