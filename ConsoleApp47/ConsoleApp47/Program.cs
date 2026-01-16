using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    // 부모-자식-손자 상속

    public class Character
    {
        public virtual void Render()
        {
            Console.WriteLine("캐릭터");
        }
    }

    public class Warrior : Character
    {
        public override void Render()
        {
            Console.WriteLine("전사");
        }
    }

    public class Mage : Warrior
    {
        public override void Render()
        {
            Console.WriteLine("마법사");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            Character character = new Character();
            Console.Write("character : ");
            character.Render(); // 캐릭터

            Character character2 = new Warrior(); // 업캐스팅 : 부모 타입 <- 자식 메모리 참조
            Console.Write("character2 : ");
            character2.Render(); // 전사
            Warrior warrior = new Warrior();
            Console.Write("warrior : ");
            warrior.Render(); // 전사

            Character character3 = new Mage();
            Console.Write("character3 : ");
            character3.Render(); // 마법사
            Warrior warrior2 = new Mage();
            Console.Write("warrior2 : ");
            warrior2.Render(); // 마법사
            Mage mage = new Mage();
            Console.Write("mage : ");
            mage.Render(); // 마법사

            Console.WriteLine("======================================");
            Character character4 = new Warrior();
            Warrior warrior3 = (Warrior)character4; // 다운 캐스팅
            warrior3.Render();

            // is 연산자 : 객체가 특정 타입인지를 확인. 다운캐스팅 전에 안정성을 확인하는 용도로 사용
            if(character4 is Warrior)
            {
                warrior3 = (Warrior)character4;
                warrior3.Render();
            }

            // as 연산자 : 실패 시 예외를 던지지 않고 null 을 반환
            Warrior warrior5 = character4 as Warrior;
            if(warrior != null)
            {
                warrior5.Render();
            }

        }
    }
}
