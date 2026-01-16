using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    public class Field
    {
        Player m_pPlayer;
        Monster m_pMonster;
        
        //이전 맵에 있던 플레이어의 정보를 함께 넘겨줌
        public void SetPlayer(Player pPlayer) {  m_pPlayer = pPlayer; }

        public void Progress()
        {
            // 사냥터
            int iInput = 0;

            while (true)
            {
                Console.Clear();

                m_pPlayer.Render();

                DrawMap();
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 4)
                    break;
                if (iInput <= 3)
                {
                    // 몬스터 만들고 싸우기
                    SpawnMonster(iInput);
                    Fight();
                }

            }
        }

        public void Fight()
        {
            int iInput = 0;
            while (true)
            {
                Console.Clear(); // 콘솔 화면 초기화
                m_pPlayer.Render();
                m_pMonster.Render();

                Console.WriteLine("1.공격 2.도망");
                Console.Write("➡️ ");
                    iInput = int.Parse(Console.ReadLine());

                if(iInput == 1)
                {
                    // 플레이어 데미지 주기 몬스터 공격력 넣어서 데미지
                    m_pPlayer.SetDamage(m_pMonster.GetMonster().iAttack);
                    // 몬스터 데미지 주기 플레이어 공격력 넣기
                    m_pMonster.SetDamage(m_pPlayer.GetInfo().iAttack);

                    if(m_pPlayer.GetInfo().iHp <= 0)
                    {
                        m_pPlayer.SetHp(100);

                        Console.WriteLine("사망");
                        break;
                    }
                }
                // 도망 or 몬스터 사망
                if(iInput == 2 || m_pMonster.GetMonster().iHp <= 0)
                {
                    m_pMonster = null; // 참조일때 null 초기화하면 가비지컬렉터에서 나중에 알아서 메모리 삭제
                    break;
                }

            }
        }


        // 생성을 도와주는 함수 -> 공장처럼 찍어내기
        public void Spawn(string _strName, int _iHp, int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster(); // 몬스터 생성
            Information tMonster = new Information(); // 몬스터데이터 메모리 주기 객체 생성

            tMonster.strName = _strName;
            tMonster.iHp = _iHp;
            tMonster.iAttack = _iAttack;

            pMonster.SetMonster(tMonster); // 생성된 데이터 Information 클래스 타입 데이터 세팅
        }

        public void SpawnMonster(int input)
        {
            switch (input)
            {
                case 1:
                    // 디자인 패턴 팩토리 메서드 패턴
                    Spawn("초보몹", 30, 3, out m_pMonster);
                    break;
                case 2:
                    Spawn("중수몹", 60, 6, out m_pMonster);
                    break;
                case 3:
                    Spawn("고수몹", 100, 10, out m_pMonster);
                    break;
                case 4:                  
                    break;
                default:
                    Console.WriteLine("잘못입력하셨습니다.");
                    break;
            }
        }



        public void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 전단계");
            Console.Write("➡️ ");
        }

    }
}
