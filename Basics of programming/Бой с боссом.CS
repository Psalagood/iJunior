using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string warriorName = "Titan";
            string rogueName = "Suziki";
            string mageName = "Geo";

            int warriorHealth = 250;
            int rogueHealth = 100;
            int mageHealth = 90;

            int warriorArmor = 150;
            int rogueArmor = 0;
            int mageArmor = 10;

            int criticalMultipler = 3;
            int warriorCritChance = 15;
            int rogueCritChance = 50;
            int mageCritChance = 25;


            Random warriorDamageWeapon = new Random();
            int axeDamage = warriorDamageWeapon.Next(17, 30);
            int axeCriticalDamage = axeDamage * criticalMultipler;
            int swordDamage = warriorDamageWeapon.Next(11, 25);
            int swordCriticalDamage = swordDamage * criticalMultipler;
            int spearDamage = warriorDamageWeapon.Next(20, 25);
            int spearCriticalDamage = spearDamage * criticalMultipler;

            Random rogueDamageWeapon = new Random();
            int daggerDamage = rogueDamageWeapon.Next(17, 50);
            int daggerCriticalDamage = daggerDamage * criticalMultipler;
            int bowDamage = rogueDamageWeapon.Next(50, 55);
            int bowCriticalDamage = bowDamage * criticalMultipler;
            int trapDamage = rogueDamageWeapon.Next(30, 45);
            int trapCriticalDamage = trapDamage * criticalMultipler;

            Random mageDamageWeapon = new Random();
            int fireSpellDamage = mageDamageWeapon.Next(45, 50);
            int fireSpellCriticalDamage = fireSpellDamage * criticalMultipler;
            int earthSpellDamage = mageDamageWeapon.Next(30, 50);
            int earthSpellCriticalDamage = earthSpellDamage * criticalMultipler;
            int deathSpellDamage = mageDamageWeapon.Next(45, 55);
            int deathSpellCriticalDamage = deathSpellDamage * criticalMultipler;



            string bossName = "Raupov";
            float bossDamage = 15;
            int bossHealth = 8000;
            int bossArmor = 0;
            int bossChanceSpawnMinion = 5;
            int bossMinionDamage = 5;
            int bossMinionHealth = 10;
            bool bossAlive = true;
            bool heroAlive = true;
            bool bossMinionAlive = true;
            bool bossFight = true;

            string pickHero;
            const string SelectWarrior = "1";
            const string SelectRogue = "2";
            const string SelectMage = "3";
            string selectPath;
            const string Challenge = "1";
            const string RunAway = "2";
            string operationCodeSelectHero;
            string operationCodeSelectPath;
            string operationCodeBossFight;
            const string Fight = "1";
            int heroHP =0;
            float heroDamage = 100;
            int heroArmor = 0;





            Console.WriteLine($"Ты пришел...");
            Console.WriteLine($"Выбери того, кто сегодня умрёт: ");
            Console.WriteLine($"{SelectWarrior} - Воин {warriorName} \n" +
                                $"{SelectRogue} - Вор {rogueName} \n" +
                                $"{SelectMage} - Маг {mageName}.");
            Console.Write("\nВведи число: ");
            operationCodeSelectHero = Console.ReadLine();
            Console.Clear();

            while (bossAlive && heroAlive)
            {
                switch(operationCodeSelectHero) 
                {
                    
                    case SelectWarrior:
                        {
                            heroHP = warriorHealth;
                            heroArmor = warriorArmor;
                            Console.WriteLine($"Принято!\n" +
                                                $"Теперь ты Воин {warriorName}\n" +
                                                $"Твоё здоровье: {warriorHealth}\n" +
                                                $"Твоя броня: {warriorArmor}\n" +
                                                $"Шанс на критическую атаку: {warriorCritChance} \n");
                            break;
                        }
                    case SelectRogue:
                        {
                           heroHP = rogueHealth;
                           heroArmor = rogueArmor;
                           Console.WriteLine($"Принято!\n" +
                                                $"Теперь ты Вор {rogueName}\n" +
                                                $"Твоё здоровье: {rogueHealth}\n" +
                                                $"Твоя броня: {rogueArmor}\n" +
                                                $"Шанс на критическую атаку: {rogueCritChance} \n");
                            break;
                        }
                    case SelectMage: 
                        {
                            heroHP = mageHealth;
                            heroArmor = mageArmor;
                            Console.WriteLine($"Принято!\n" +
                                                $"Теперь ты Маг {mageName}\n" +
                                                $"Твоё здоровье: {mageHealth}\n" +
                                                $"Твоя броня: {mageArmor}\n" +
                                                $"Шанс на критическую атаку: {mageCritChance} \n");
                            break;
                        }
                     default:
                        Console.WriteLine("Команда не найдена.");
                        Console.Clear();
                        break;

                }
                Console.WriteLine($"Перед собой ты видишь огромные ворота, далее тебе нужно выбрать свою судьбу.");
                Console.WriteLine($"{Challenge} Войти. \n" +
                                  $"{RunAway} Сбежать как крыса.\n");
                Console.Write("\nВведи число: ");
                operationCodeSelectPath = Console.ReadLine();
                Console.Clear();

                switch (operationCodeSelectPath)
                {
                    case Challenge:
                        {
                            Console.WriteLine($"На огромной площади сидит один маленький гном.\n" +
                                            $"Но не думай что тебе повезло. Ведь гном, и есть тот за кем все охотятся.\n" +
                                            $"Пристально вглядевшись ты заметил что:\n" +
                                            $"Здоровье гнома: {bossHealth}\n" +
                                            $"Урон: {bossDamage}\n" +
                                            $"Броня: {bossArmor}\n"); 
                            Console.WriteLine($"И что ты выберешь?\n" +
                                            $"{Fight} Нападаем. \n" +
                                            $"{RunAway} Я толерантен к гномам (уйти).");
                            Console.Write("\n Введи число: ");
                            operationCodeBossFight = Console.ReadLine();
                            Console.Clear();

                            switch(operationCodeBossFight)
                            {
                                case Fight:
                                    {
                                        Console.WriteLine("Бой начался!");
                                        while (bossFight)
                                        {

                                            heroHP -= Convert.ToInt32(bossDamage);
                                            Console.WriteLine($"{heroHP} здоровье ГЕРОЯ! \n" +
                                                            $"-      Герой наносит {heroDamage}");
                                            bossHealth -= Convert.ToInt32(heroDamage);
                                            Console.WriteLine($"{bossHealth} здоровье БОССА! \n" +
                                                            $"-      Босс наносит {bossDamage}");

                                            if (heroHP <= 0)
                                            {
                                                Console.WriteLine("Герой мёртв...");
                                                heroAlive = false;
                                                break;
                                            }
                                            
                                            else if (bossHealth <= 0)
                                            {
                                                Console.WriteLine("Босс мёртв.");
                                                bossAlive= false;
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                case RunAway:
                                    {
                                        Console.WriteLine("Ты не герой!");
                                        heroAlive = false;
                                        Console.WriteLine("Про тебя не пишут стихи и песни, про тебя все забыли.");
                                        break;
                                    }
                            }
                            break;
                        }
                    case RunAway:
                        {
                            Console.WriteLine("Ты не герой!");
                            heroAlive = false;
                            Console.WriteLine("Про тебя не пишут стихи и песни, про тебя все забыли.");
                            break;
                        }
                }
                Console.WriteLine("Нажми \"Enter\" для продолжения.");
                Console.ReadKey();
                Console.Clear();


            }

        }
    }

}
