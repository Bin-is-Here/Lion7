using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    public class MainGame
    {

        public Player m_pPlayer = null;
        public Field m_pField = null;



        // 초기화 함수
        public void Initialize()
        {
            // 플레이어 생성 및 직업 선택
            m_pPlayer = new Player(); // 객체
            m_pPlayer.SelectJob();
        }

        // 게임의 전체적인 과정 관리
        public void Progress()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                m_pPlayer.Render(); // 플레이어 출력
                Console.WriteLine("1.사냥터 2.게임종료");
                Console.Write("➡️ ");
                iInput = int.Parse(Console.ReadLine());

                switch (iInput)
                {
                    case 1:
                        // 사냥터 구현
                        if(m_pField == null)
                        {
                            m_pField = new Field();
                            m_pField.SetPlayer(m_pPlayer);
                        }
                        m_pField.Progress(); // 사냥터 동작
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
