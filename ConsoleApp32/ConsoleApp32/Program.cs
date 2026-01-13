using System;

class BadExample
{

    // 전역변수 남용 사례


    // 전역변수들
    static int playerHP = 100;
    static int playerMP = 50;
    static int enemyHP = 80;
    static int damage = 0;
    static bool gameOver = false;

    static void PlayerAttack()
    {
        // 어디서 값이 변경되는지 추적하기 어려움
        damage = 30;
        enemyHP -= damage;

        if (enemyHP <= 0)
        {
            gameOver = true;  // 전역변수 직접 수정
        }
    }

    static void EnemyAttack()
    {
        damage = 20;  // 이전 damage 값이 사라짐!
        playerHP -= damage;

        if (playerHP <= 0)
        {
            gameOver = true;
        }
    }

    static void UsePotion()
    {
        playerHP += 30;  // 최대 HP 체크 없음
        playerMP -= 10;  // 음수 체크 없음
    }

    static void Main(string[] args)
    {
        PlayerAttack();
        Console.WriteLine($"적 HP: {enemyHP}");

        EnemyAttack();
        Console.WriteLine($"플레이어 HP: {playerHP}");

        // 문제: damage 값이 어떻게 변했는지 알 수 없음
        Console.WriteLine($"마지막 데미지: {damage}");
    }
}
