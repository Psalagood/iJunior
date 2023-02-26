using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void ShowHealthBar(int heroBarHealth, int heroBarMana)
        {
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"#########\n" +
                        $"ХП:   {heroBarHealth}\n" +
                        $"Мана: {heroBarMana}\n" +
                        $"#########");
                Console.ResetColor();
            }
        }
        static void ChangeWeaponBoss(int changeBosstypeDamage,
                                        int changeGetBlow,
                                        int changeGetAxeStrike,
                                        int changeGetCleave,
                                        int changeGetJumpKick,
                                        int changeGetKick,
                                        int changeGetStrangle,
                                        int heroBarHealth,
                                        int getOneShotMechanic,
                                        int getBossDamage)
        {
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (changeBosstypeDamage == changeGetBlow)

                {
                    Console.WriteLine("Удар обухом! ");
                    Console.WriteLine($"Нанесено {getBossDamage} урона.");
                }

                else if (changeBosstypeDamage == changeGetAxeStrike)

                {
                    Console.WriteLine("Удар топором!");
                    Console.WriteLine($"Нанесено {getBossDamage} урона.");
                }

                else if (changeBosstypeDamage == changeGetCleave)

                {
                    Console.WriteLine("Разрезающий удар!");
                    Console.WriteLine($"Нанесено {getBossDamage} урона.");
                }

                else if (changeBosstypeDamage == changeGetJumpKick)

                {
                    Console.WriteLine("Удар в прыжке!");
                    Console.WriteLine($"Нанесено {getBossDamage} урона.");
                }

                else if (changeBosstypeDamage == changeGetKick)

                {
                    Console.WriteLine("Тебя пнули!");
                    Console.WriteLine($"Нанесено {getBossDamage} урона.");
                }

                else if (changeBosstypeDamage == changeGetStrangle)

                {
                    Console.WriteLine("Тебя задушили!");
                    Console.WriteLine($"Нанесено {getBossDamage} урона.");
                }

                Console.ResetColor();
            }
        }
        static void Main(string[] args)
        {
            {
                const string MenuFight = "1";
                const string MenuRunAway = "2";
                const string CommandFireBolt = "1";
                const string CommandGhostBlade = "2";
                const string CommandInvisibility = "3";
                const string CommandStaffStrike = "4";

                int bossDamage = 15;
                int bossHealth = 8000;
                int bossArmor = 0;
                int heroDamage = 60;
                int heroHealth = 150;
                int heroMana = 100;
                int manaRegeneration = 11;
                int maximumHeroMana = 100;
                int minimumHeroMana = 0;
                int maximumHeroHealth = 150;
                int criticalMultipler = 3;
                int getCritical = 7;
                int heroCriticalDamage = heroDamage * criticalMultipler;
                int manaPriceFireBolt = 17;
                int manaPriceGhostBlade = 10;
                int manaPriceInvisibility = 5;
                int manaPriceStaffStrike = 0;
                bool heroAlive = true;
                bool bossAlive = true;
                string operationCodeSelectPath;
                string bossFight;
                int getBlow = 1;
                int getAxeStrike = 2;
                int getCleave = 3;
                int getJumpKick = 4;
                int getKick = 5;
                int getStrangle = 6;
                int oneShotMechanic = 10000;

                Console.WriteLine("#");
                Console.WriteLine($"Эй, проснись! Ну ты и соня.\n" +
                                  $"Тебя даже вчерашний шторм не разбудил.\n" +
                                  $"Говорят, мы уже приплыли в Морровинд\n");
                Console.WriteLine($"Ты выходишь из корабля и видишь огромную чёрную дверь.\n" +
                                  $"что за ней, ты не знаешь.\n" +
                                  $"Открыв дверь, ты видишь толстого гнома. Выглядит агрессивно.");
                Console.WriteLine($"Гном как только тебя увидел, побежал в твою сторону.\n" +
                                  $"Пристально вглядевшись ты заметил что:\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Здоровье гнома: {bossHealth}\n" +
                                  $"Урон: {bossDamage}\n" +
                                  $"Броня: {bossArmor}\n");
                Console.ResetColor();
                Console.WriteLine($"И что ты выберешь?\n" +
                                     $"{MenuFight} - Нападаем. \n" +
                                     $"{MenuRunAway} - Я толерантен к гномам (уйти).");
                Console.Write("\nВведи число: ");
                operationCodeSelectPath = Console.ReadLine();
                Console.Clear();

                while (heroAlive && bossAlive)
                {

                    switch (operationCodeSelectPath)
                    {

                        case MenuFight:
                            {

                                while (heroHealth > 0 && bossHealth > 0)
                                {
                                    Random criticalChance = new Random();
                                    int chanceCriticalAttack = criticalChance.Next(1, 8);
                                    Random skillDamageFireBolt = new Random();
                                    int fireBolt = skillDamageFireBolt.Next(40, 100);
                                    int fireBoldDamage = fireBolt + heroDamage;
                                    int fireBoltCriticalDamage = fireBoldDamage * criticalMultipler;
                                    Random skillDamageGhostBlade = new Random();
                                    int ghostBlade = skillDamageGhostBlade.Next(15, 80);
                                    int ghostBladeDamage = ghostBlade + heroDamage;
                                    int ghostBladeCriticalDamage = ghostBladeDamage * criticalMultipler;
                                    Random skillHealthInvisibility = new Random();
                                    int invisibility = skillHealthInvisibility.Next(5, 50);
                                    Random changeBossTypeDamge = new Random();
                                    int bossTypeDamage = changeBossTypeDamge.Next(1, 7);

                                    ShowHealthBar(heroHealth, heroMana);
                                    Console.WriteLine($"Выбери скилл:" +
                                                        $"\n{CommandFireBolt} - Кинуть шар. Стоимость {manaPriceFireBolt} маны.\n" +
                                                        $"{CommandGhostBlade} - Кинуть клинок. Стоимость {manaPriceGhostBlade} маны.\n" +
                                                        $"{CommandInvisibility} - Уйти в инвиз. Стоимость {manaPriceInvisibility} маны.\n" +
                                                        $"{CommandStaffStrike} - Попробовать ударить посохом. Эта способность стоит {manaPriceStaffStrike} маны. ");
                                    Console.Write("Введи число: ");
                                    bossFight = Console.ReadLine();
                                    Console.Clear();

                                    switch (bossFight)
                                    {

                                        case CommandFireBolt:

                                            if (heroMana >= minimumHeroMana && heroMana >= manaPriceFireBolt)
                                            {
                                                if (chanceCriticalAttack == getCritical)
                                                {
                                                    Console.WriteLine($"Критический урон! ты нанёс: {fireBoltCriticalDamage} урона огненным шаром!.");
                                                    ChangeWeaponBoss(bossTypeDamage,
                                                        getBlow,
                                                        getAxeStrike,
                                                        getCleave,
                                                        getJumpKick,
                                                        getKick,
                                                        getStrangle,
                                                        heroHealth,
                                                        oneShotMechanic,
                                                        bossDamage);
                                                    heroMana -= manaPriceFireBolt;
                                                    heroHealth -= bossDamage;
                                                    bossHealth -= fireBoltCriticalDamage;
                                                    break;
                                                }

                                                Console.WriteLine($"Ты наносишь {fireBolt} урона огненным шаром!.");
                                                ChangeWeaponBoss(bossTypeDamage,
                                                    getBlow,
                                                    getAxeStrike,
                                                    getCleave,
                                                    getJumpKick,
                                                    getKick,
                                                    getStrangle,
                                                    heroHealth,
                                                    oneShotMechanic,
                                                    bossDamage);
                                                heroHealth -= bossDamage;
                                                heroMana -= manaPriceFireBolt;
                                                bossHealth -= fireBolt;
                                                break;
                                            }

                                            else;
                                            Console.WriteLine("Недостаточно маны.");
                                            heroMana = minimumHeroMana;
                                            heroHealth -= bossDamage;
                                            Console.WriteLine("Недостаточно маны? это твоя ошибка, ты получаешь урон от босса.");
                                            break;

                                        case CommandGhostBlade:
                                            if (heroMana >= minimumHeroMana && heroMana >= manaPriceGhostBlade)
                                            {
                                                if (chanceCriticalAttack == getCritical)
                                                {
                                                    Console.WriteLine($"Критический урон! ты нанёс: {ghostBladeCriticalDamage} урона призрачным клинком!.");
                                                    ChangeWeaponBoss(bossTypeDamage,
                                                            getBlow,
                                                            getAxeStrike,
                                                            getCleave,
                                                            getJumpKick,
                                                            getKick,
                                                            getStrangle,
                                                            heroHealth,
                                                            oneShotMechanic,
                                                            bossDamage);
                                                    heroMana -= manaPriceGhostBlade;
                                                    heroHealth -= bossDamage;
                                                    bossHealth -= ghostBladeCriticalDamage;
                                                    break;
                                                }
                                                Console.WriteLine($"Ты наносишь {ghostBlade} урона призрачным клинком!.");
                                                ChangeWeaponBoss(bossTypeDamage,
                                                            getBlow,
                                                            getAxeStrike,
                                                            getCleave,
                                                            getJumpKick,
                                                            getKick,
                                                            getStrangle,
                                                            heroHealth,
                                                            oneShotMechanic,
                                                            bossDamage);
                                                heroMana -= manaPriceGhostBlade;
                                                heroHealth -= bossDamage;
                                                bossHealth -= ghostBlade;
                                                break;
                                            }
                                            else;
                                            Console.WriteLine("Недостаточно маны.");
                                            heroMana = minimumHeroMana;
                                            heroHealth -= bossDamage;
                                            Console.WriteLine("Недостаточно маны? это твоя ошибка, ты получаешь урон от босса.");
                                            break;

                                        case CommandInvisibility:
                                            if (heroMana >= minimumHeroMana && heroMana >= manaPriceInvisibility)
                                            {
                                                Console.WriteLine($"Ты уходишь в инвиз");
                                                if (heroHealth >= maximumHeroHealth)
                                                {
                                                    heroHealth = maximumHeroHealth;
                                                    Console.WriteLine("Ты не получаешь урона, и не восстанавливаешь, ведь у тебя уже максимум.");
                                                    break;
                                                }
                                                Console.WriteLine($"Восстанавливаешь себе {invisibility} здоровья.");
                                                heroHealth += invisibility;
                                                heroMana -= manaPriceInvisibility;
                                                break;
                                            }
                                            else;
                                            Console.WriteLine("Недостаточно маны.");
                                            heroMana = minimumHeroMana;
                                            heroHealth -= bossDamage;
                                            Console.WriteLine("Недостаточно маны? это твоя ошибка, ты получаешь урон от босса.");
                                            break;

                                        case CommandStaffStrike:
                                            if (chanceCriticalAttack == getCritical)
                                            {
                                                Console.WriteLine($"Критический урон! Ты нанёс: {heroCriticalDamage} урона");
                                                Console.WriteLine($"#");
                                                ChangeWeaponBoss(bossTypeDamage,
                                                        getBlow,
                                                        getAxeStrike,
                                                        getCleave,
                                                        getJumpKick,
                                                        getKick,
                                                        getStrangle,
                                                        heroHealth,
                                                        oneShotMechanic,
                                                        bossDamage);
                                                bossHealth -= heroCriticalDamage;
                                                heroHealth -= bossDamage;
                                                bossHealth -= heroCriticalDamage;

                                                if (heroMana != maximumHeroMana)
                                                {
                                                    heroMana += manaRegeneration;
                                                    heroHealth -= bossDamage;
                                                    Console.ForegroundColor = ConsoleColor.Blue;
                                                    Console.WriteLine($"Удар посохом восстанавливает вам ману." +
                                                                    $" + {manaRegeneration} маны за удар.");
                                                    Console.WriteLine($"#");
                                                    Console.ResetColor();
                                                    break;
                                                }

                                                else if (heroMana >= maximumHeroMana)
                                                {
                                                    heroMana = maximumHeroMana;
                                                    break;
                                                }
                                            }
                                            Console.WriteLine($"Ты бьёшь посохом нанося {heroDamage} урона.");
                                            bossHealth -= heroDamage;
                                            ChangeWeaponBoss(bossTypeDamage,
                                                        getBlow,
                                                        getAxeStrike,
                                                        getCleave,
                                                        getJumpKick,
                                                        getKick,
                                                        getStrangle,
                                                        heroHealth,
                                                        oneShotMechanic,
                                                        bossDamage);

                                            if (heroMana >= maximumHeroMana)
                                            {
                                                heroMana = maximumHeroMana;
                                                break;
                                            }
                                            else if (heroMana == maximumHeroMana)
                                            {
                                                Console.WriteLine($"Удар посохом должен восстановить ману." +
                                                                $" + {manaRegeneration} маны за удар.");
                                                Console.WriteLine("Мана полная! Больше восстановить не получится.");
                                                break;
                                            }
                                            else if (heroMana != maximumHeroMana)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                heroMana += manaRegeneration;
                                                heroHealth -= bossDamage;
                                                bossHealth -= heroDamage;
                                                Console.WriteLine($"Удар посохом восстанавливает вам ману." +
                                                                $" + {manaRegeneration} маны за удар.");
                                                Console.ResetColor();
                                            }
                                            break;
                                        default:
                                            Console.WriteLine("Команда не найдена.\n");
                                            break;
                                    }
                                    Console.WriteLine($"#");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"Здоровье босса: {bossHealth}");
                                    Console.ResetColor();
                                    Console.WriteLine($"#");
                                }
                                Console.Clear();

                                if (heroHealth <= 0 && bossHealth <= 0)
                                {
                                    Console.WriteLine("Ничья.");
                                    heroAlive = false;
                                    bossAlive = false;
                                }

                                else if (heroHealth <= 0)
                                {
                                    Console.WriteLine("Тебя отпинали как собаку.");
                                    heroAlive = false;
                                }
                                else if (bossHealth <= 0)
                                {
                                    Console.WriteLine("Победа за гером (на удивление)");
                                    bossAlive = false;
                                }
                                break;
                            }
                        case MenuRunAway:
                            {
                                Console.Clear();
                                Console.WriteLine("Ты не герой!");
                                heroAlive = false;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Про тебя не пишут стихи и песни, про тебя все забыли.\n" +
                                                    "Твоё существование бесполезно. Ты умер в ближайшей таверне от дешевого алкоголя.");
                                Console.ResetColor();
                                break;
                            }
                        default:
                            Console.WriteLine("Команда не найдена.");
                            Console.Clear();
                            break;
                    }
                }
            }
        }
    }
}
