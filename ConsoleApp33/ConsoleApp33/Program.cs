using System;

class GoodExample
{

    // 좋은 예 : 지역변수와 반환값 사용



    static int CalculateDamage(int attack, int defense)
    {
        int damage = attack - defense / 2;
        if (damage < 0) damage = 0;
        return damage;  // 결과를 명확하게 반환
    }

    static int ApplyDamage(int currentHP, int damage)
    {
        int newHP = currentHP - damage;
        if (newHP < 0) newHP = 0;
        return newHP;  // 새로운 값 반환
    }

    static int UsePotion(int currentHP, int maxHP, int healAmount)
    {
        int newHP = currentHP + healAmount;
        if (newHP > maxHP) newHP = maxHP;  // 최대값 체크
        return newHP;
    }

    static bool IsAlive(int hp)
    {
        return hp > 0;
    }

    static void Main(string[] args)
    {
        // 지역변수로 상태 관리
        int playerHP = 100;
        int playerMaxHP = 100;
        int enemyHP = 80;

        // 명확한 데이터 흐름
        int playerDamage = CalculateDamage(50, 20);
        enemyHP = ApplyDamage(enemyHP, playerDamage);
        Console.WriteLine($"적에게 {playerDamage} 데미지!");
        Console.WriteLine($"적 HP: {enemyHP}");

        int enemyDamage = CalculateDamage(30, 10);
        playerHP = ApplyDamage(playerHP, enemyDamage);
        Console.WriteLine($"\n플레이어가 {enemyDamage} 데미지 받음!");
        Console.WriteLine($"플레이어 HP: {playerHP}");

        // 포션 사용
        playerHP = UsePotion(playerHP, playerMaxHP, 30);
        Console.WriteLine($"\n포션 사용! HP: {playerHP}");

        // 상태 확인
        if (IsAlive(playerHP) && !IsAlive(enemyHP))
        {
            Console.WriteLine("\n승리!");
        }
    }
}
