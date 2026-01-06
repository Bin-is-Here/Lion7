using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 문제1. RPG 체력 계산기
            // 플레이어의 현재 체력이 80이고, 최대체력이 100입니다.
            //  몬스터에게 25의 데미지를 받았습니다.
            //  회복 포션으로 30을 회복했습니다.
            //  독 데미지로 5를 받았습니다.
            // 최종 체력을 계산하여 출력하세요

            int maxHP = 100;
            int playerHP = 80;
            int potion = 30;
            int poisonDamage = 5;
            int monsterDamage = 25;

            Console.WriteLine($"현재 플레이어 HP: {playerHP}");
            playerHP -= monsterDamage;
            Console.WriteLine($"몬스터에게 {monsterDamage}의 데미지를 받았습니다.");
            Console.WriteLine($"현재 플레이어 HP: {playerHP}");
            if (playerHP + potion > maxHP)
            {
                playerHP = maxHP;
            }
            else
            {
                playerHP += potion;
            }
            Console.WriteLine($"회복 포션으로 체력을 {potion} 회복합니다.");
            Console.WriteLine($"현재 플레이어 HP: {playerHP}");
            playerHP -= poisonDamage;
            Console.WriteLine($"독 데미지를 받았습니다.");
            Console.WriteLine($"현재 플레이어 HP: {playerHP}");

            Console.WriteLine("\n");

            // 문제2. 경험치와 레벨 계산
            // 플레이어가 몬스터 3마리를 처치했습니다.
            //  몬스터 1마리당 경험치: 150
            //  레벨업에 필요한 경험치: 500
            // 총 획득 경험치와 레벨업까지 남은 경험치를 계산하세요

            int levelUpExp = 500;
            int monsterExp = 150;

            int currentExp = 0;
            int killMonsterCount = 0;

            currentExp += monsterExp;
            killMonsterCount++;
            Console.WriteLine($"몬스터를 처치하여 경험치 {monsterExp}를 획득했습니다.");
            Console.WriteLine($"몬스터를 처치 수 : {killMonsterCount}");
            Console.WriteLine($"현재 경험치 {currentExp}/{levelUpExp}");
            Console.WriteLine($"레벨업까지 남은 경험치 : {levelUpExp - currentExp}");
            currentExp += monsterExp;
            killMonsterCount++;
            Console.WriteLine($"몬스터를 처치하여 경험치 {monsterExp}를 획득했습니다.");
            Console.WriteLine($"몬스터를 처치 수 : {killMonsterCount}");
            Console.WriteLine($"현재 경험치 {currentExp}/{levelUpExp}");
            Console.WriteLine($"레벨업까지 남은 경험치 : {levelUpExp - currentExp}");
            currentExp += monsterExp;
            killMonsterCount++;
            Console.WriteLine($"몬스터를 처치하여 경험치 {monsterExp}를 획득했습니다.");
            Console.WriteLine($"몬스터를 처치 수 : {killMonsterCount}");
            Console.WriteLine($"현재 경험치 {currentExp}/{levelUpExp}");
            Console.WriteLine($"레벨업까지 남은 경험치 : {levelUpExp - currentExp}");

            Console.WriteLine("\n");

            // 문제3. 아이템 분배 시스템
            // 파티에서 골드 1234를 획득했습니다. 파티원은 5명입니다.
            //  1인당 받을 골드는 얼마인가요?
            //  분배 후 남는 골드는 얼마인가요?

            int totalGold = 1234;
            int partyMember = 5;

            Console.WriteLine($"1인당 받을 골드는 {totalGold / partyMember}골드 입니다.");
            Console.WriteLine($"분배 후 남는 골드는 {totalGold % partyMember}골드 입니다.");


            Console.WriteLine("\n");

            // 문제4. 던전 입장 가능 여부
            // 다음 조건을 모두 만족해야 던전에 입장할 수 있습니다.
            //  플레이어 레벨이 30 이상
            //  던전 열쇠를 보유하고 있음
            //  체력이 50% 이상

            int playerLevel = 30;
            int currentHP = 55;
            maxHP = 100;
            bool hasKey = false;

            int requiredLevel = 30;
            int requiredHP = 50;

            int hpPer = (currentHP *100 / maxHP);

            Console.WriteLine("=== 던전 입장 조건 ===");
            Console.WriteLine($"던전 입장 레벨 조건: {requiredLevel} 이상");
            Console.WriteLine($"던전에 입장하기 위한 체력 조건: {requiredHP}% 이상");
            Console.WriteLine($"던전에 입장하기 위한 열쇠가 필요합니다.");
            Console.WriteLine("================================");
            Console.WriteLine($"플레이어 레벨: {playerLevel}, 입장 조건 {playerLevel >= requiredLevel}");
            Console.WriteLine($"플레이어 열쇠 보유 여부:     {hasKey}");
            Console.WriteLine($"현재 플레이어 체력: {hpPer}, 입장 조건 {hpPer >= requiredHP}");
            Console.WriteLine("\n");
            
            if ((playerLevel >= requiredLevel) && (hasKey) && (hpPer >= requiredHP))
            {
                Console.WriteLine("던전 입장 가능");
            }
            else if (playerLevel < requiredLevel)
            {
                Console.WriteLine("던전 입장 레벨이 부족합니다.");
                Console.WriteLine("던전 입장 불가능");
            }
            else if (!hasKey)
            {
                Console.WriteLine("열쇠가 부족합니다.");
                Console.WriteLine("던전 입장 불가능");
            }
            else
            {
                Console.WriteLine("입장 체력이 부족합니다.");
                Console.WriteLine("던전 입장 불가능");
            }


            Console.WriteLine("\n");


            // 문제5. 상점 할인 계산기
            // 아이템의 원가가 5000골드입니다.
            //  VIP회원이면 20% 할인
            //  쿠폰을 사용하면 추가로 500골드 할인
            // VIP회원이고 쿠폰이 있을 때의 최종 가격을 계산하세요

            int itemPrice = 5000;
            int currentPrice = itemPrice;
            int useCoupon = 500;
            bool isVIP = true;

            if (isVIP == true)
            {
                currentPrice = itemPrice - (itemPrice * 20 / 100);
            }
            currentPrice -= useCoupon;

            Console.WriteLine($"기본 가격은 {itemPrice:N0}골드 입니다.");
            Console.WriteLine($"쿠폰 할인 금액은 {useCoupon:N0}골드 입니다.");
            Console.WriteLine($"최종 가격은 {currentPrice:N0}골드 입니다.");



            // === 힌트 ========================================
            // 문제1
            // int currentHP = 80;
            // int maxHP = 100;
            // 각 상황을 -= 또는 += 연산자로 처리

            // 문제2
            // int expPerMonster = 150;
            // int monstersKilled = 3;
            // int expForLevelUp = 500;
            // * 연산자와 - 연산자 사용

            // 문제3
            // int totalGold = 1234;
            // int partyMembers = 5;
            // / 연산자와 % 연산자 사용

            // 문제4
            // int playerLevel = 35;
            // int requiredLevel = 30;
            // bool hasKey = true;
            // int currentHP = 60;
            // int maxHP = 100;
            // >=, &&, || 연산자 활용

            // 문제5
            // int originalPrice = 5000;
            // bool isVIP = true;
            // bool hasCoupon = true;
            // 할인율 계산: 가격 * 0.8
            // 쿠폰 할인: 가격 - 500

        }
    }
}
