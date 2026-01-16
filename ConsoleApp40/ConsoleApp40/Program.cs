using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp40
{
    // 프로퍼티 연습 문제(쉬운 난이도)
    // 📝 문제 1: 학생 성적 관리 시스템
    // 문제 설명
    // Student 클래스를 만들어 학생의 성적을 관리하세요.

    // 요구사항
    // name (이름) - 읽기 전용 프로퍼티
    // score (점수) - 0~100 사이의 값만 허용하는 프로퍼티
    // Grade (등급) - 점수에 따라 자동 계산되는 읽기 전용 프로퍼티
    // 90점 이상: "A"
    // 80점 이상: "B"
    // 70점 이상: "C"
    // 60점 이상: "D"
    // 60점 미만: "F"

    class Student
    {
        string name;
        int score;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public int Score
        {
            get { return score; }
            set
            {
                if (value < 0) score = 0;
                else if (value > 100) score = 100;
                else score = value;
            }
        }

        public string Grade
        {
            get
            {
                if (score >= 90) return "A";
                else if (score >= 80 && score <90) return "B";
                else if (score >= 70 && score <80) return "C";
                else if (score >= 60 && score <70) return "D";
                else return "F";
            }

        }

        public Student(string _name)
        {
            name = _name;
        }

        public void studentInfo()
        {
            Console.WriteLine($"━━━━━━━━━━━━━━━━");
            Console.WriteLine($"이름: {Name}");
            Console.WriteLine($"점수: {Score}점");
            Console.WriteLine($"등급: {Grade}");
            Console.WriteLine($"━━━━━━━━━━━━━━━━");
        }



        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("학생 이름 입력 ");
                string studentName = Console.ReadLine();
                Student student = new Student(studentName);
                Console.Write($"{studentName}의 점수 입력: ");
                student.Score = int.Parse(Console.ReadLine());

                student.studentInfo();
                Console.WriteLine();

                student.Score = 150;
                student.studentInfo();
                Console.WriteLine("위 값이 100으로 제한되어야함");
                student.Score = -10;
                student.studentInfo();
                Console.WriteLine("위 값이 0으로 제한되어야 함");



            }
        }
    }
}
