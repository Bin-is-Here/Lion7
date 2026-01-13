using System;

class GlobalVariableProblem
{

    // 전역변수의 문제점: 전역변수가 일으키는 버그




    // 전역변수
    static int gold = 1000;

    // 문제 1: 의도치 않은 수정
    static void BuyItem(int price)
    {
        gold -= price;  // 음수 체크 없음!
        Console.WriteLine($"아이템 구매! 남은 골드: {gold}");
    }

    static void SellItem(int price)
    {
        gold += price;  // 최대값 체크 없음!
        Console.WriteLine($"아이템 판매! 현재 골드: {gold}");
    }

    // 문제 2: 함수끼리 간섭
    static void Quest1()
    {
        Console.WriteLine("퀘스트 1 시작");
        gold += 500;  // 보상 지급
    }

    static void Quest2()
    {
        Console.WriteLine("퀘스트 2 시작");
        gold += 300;  // 보상 지급
    }

    // 문제 3: 디버깅이 어려움
    static void MysteryFunction()
    {
        // 어디선가 gold를 수정...
        gold = gold / 2;
    }

    static void Main(string[] args)
    {
        Console.WriteLine($"초기 골드: {gold}\n");

        // 문제 상황들
        BuyItem(500);
        BuyItem(700);  // gold가 음수가 됨!

        Console.WriteLine($"\n버그: 골드가 음수! {gold}");

        // 누가 gold를 바꿨는지 찾기 어려움
        Quest1();
        MysteryFunction();  // 어디선가 gold 수정
        Quest2();

        Console.WriteLine($"\n최종 골드: {gold}");
        Console.WriteLine("어느 함수가 문제인지 찾기 어렵다!");
    }
}