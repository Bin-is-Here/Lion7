using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{

    class Character
    {
        // 정적 맴버 : static 맴버는 클래스 자체에 속하며, 객체를 생성하지 않고도 사용할 수 있다.
        // 모든 객체가 공유해야 하는 값
        // 통계, 카운터, 설정값 등
        // 객체 없이 사용해야 하는 유틸리티 메서드

        public static int totalCount = 0; // 모든 캐릭터가 공유

        public string name; // 각 캐릭터마다 다름


        public void AddCount()
        {
            totalCount++;
        }

    }

    class Skill
    {
        // this 키워드

        private string name;
        private int attack;

        public Skill()
        {

        }
        public Skill(string name, int attack)
        {
            this.name = name; // 변수의 이름이 동일한 경우 헷갈리는 것을 방지하기 위해 this 키워드를 사용하여 명확히 구분한다.
            this.attack = attack;
        }

        public void UseSkill()
        {
            Console.WriteLine($"스킬이름: {name}");
            Console.WriteLine($"데 미 지: {attack:N0}");
        }

    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Character c1 = new Character();
            Character c2 = new Character();

            c1.name = "전사";
            c2.name = "마법사";

            Character.totalCount++;

            Console.WriteLine(c1.name);
            Console.WriteLine(c2.name);
            Console.WriteLine(Character.totalCount); // 클래스에 속해있기 때문에 각 Character 이름이 아니라 Class 이름으로 호출

            c1.AddCount();
            c2.AddCount();
            Console.WriteLine(Character.totalCount); // c1, c2에서 각각 count++ 했지만 공통으로 count가 올라간다.


            Skill s = new Skill("블리자드", 1000000);
            s.UseSkill();

        }
    }
}
