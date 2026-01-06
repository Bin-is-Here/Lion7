using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 캐릭터 스탯 계산
            int baseAttack = 50;
            int weaponDamage = 30;
            int totalAttack = baseAttack + weaponDamage;

            Console.WriteLine("=== 공격력 계산 ===");
            Console.WriteLine($"기본 공격력 : {baseAttack}");
            Console.WriteLine($"무기 공격력 : {weaponDamage}");
            Console.WriteLine($"최종 공격력 : {totalAttack}");

            // 데미지 계산
            int playerHealth = 100;
            int damage = totalAttack;
            playerHealth -= damage;

            Console.WriteLine("\n === 데미지 계산 ===");
            Console.WriteLine($"받은 데미지: {damage}");
            Console.WriteLine($"남은 체력: {playerHealth}");

            // 경험치 계산
            int monsterSkilled = 5;
            int expPerMonster = 100;
            int totalExp = monsterSkilled * expPerMonster;

            Console.WriteLine("\n=== 경험치 획득 ===");
            Console.WriteLine($"처치한 몬스터: {monsterSkilled}마리");
            Console.WriteLine($"몬스터당 경험치: {expPerMonster}");
            Console.WriteLine($"총 경험치: {totalExp}");

            // 아이템 분배
            int totalGold = 1000;
            int playerCount = 4;
            int goldPerPlayer = totalGold / playerCount;
            int remainingGold = totalGold & playerCount;

            Console.WriteLine("\n=== 골드 분배 ===");
            Console.WriteLine($"총 골드: {totalGold:N0}G");
            Console.WriteLine($"플레이어 수: {playerCount}명");
            Console.WriteLine($"인당 획득 골드: {goldPerPlayer}G");
            Console.WriteLine($"남은 골드: {remainingGold}G");



            // === 몬스터 처치 ===
            // 고블린 처치!(킬 카운트: 1)
            // 오크 처치!(킬 카운트: 2)
            // 드래곤 처치!(킬 카운트: 3)
            // 총 처치 수 : 3마리

            // === 사격 ===
            // 남은 탄약: 30
            // 발사! 남은 탄약: 29
            // 발사! 남은 탄약: 28
            // 발사! 남은 탄약: 27

            // === 카운트다운 ===
            // 3
            // 2
            // 1
            // 발사!

            int killCount = 0;
            int bulletCount = 30;
            string killMonster = " 처치!(킬 카운트: ";
            string shotGun = "발사! 남은 탄약: ";
            int countNumber = 3;

            Console.WriteLine("\n=== 몬스터 처치 ===");
            Console.WriteLine($"고블린 {killMonster} {++killCount})");
            Console.WriteLine($"오크 {killMonster} {++killCount})");
            Console.WriteLine($"드래곤 {killMonster} {++killCount})");
            Console.WriteLine($"총 처치 수: {killCount}마리");

            Console.WriteLine("\n=== 사격 ===");
            Console.WriteLine($"남은 탄약: {bulletCount}");
            Console.WriteLine($"{shotGun}{--bulletCount}");
            Console.WriteLine($"{shotGun}{--bulletCount}");
            Console.WriteLine($"{shotGun}{--bulletCount}");

            Console.WriteLine("\n=== 카운트다운 ===");
            Console.WriteLine(countNumber--);
            Console.WriteLine(countNumber--);
            Console.WriteLine(countNumber--);
            Console.WriteLine("발사!");





        }
    }
}
