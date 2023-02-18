using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int bossDamage = 15;
                int bossHealth = 150;
                int bossMana = 1500;
                int bossArmor = 0;

                int heroDamage = 60;
                int heroHealth = 150;
                int heroMana = 100;
                int heroArmor = 10;
                int manaRegeneration = 11;
                int maximumHeroMana = 100;
                int criticalMultipler = 3;
                int getCritical = 7;
                int getOneShot = 15;
                int invulnerabilityPerSecond = 30;
                int heroCriticalDamage = heroDamage * criticalMultipler;

                int manaPriceFireBolt = 17;
                int manaPriceGhostBlade = 10;
                int manaPriceInvisibility = 40;
                int manaPriceStaffStrike = 0;


                bool heroAlive = true;
                bool bossAlive = true;
                string operationCodeSelectPath;
                const string Fight = "1";
                const string RunAway = "2";
                string useSkills;
                const string FireBolt = "1";
                const string GhostBlade = "2";
                const string Invisibility = "3";
                const string StaffStrike = "4";
                string bossFight;


                Console.WriteLine("#");
                Console.WriteLine($"Эй, проснись! Ну ты и соня.\n" +
                                  $"Тебя даже вчерашний шторм не разбудил.\n" +
                                  $"Говорят, мы уже приплыли в Морровинд\n");
                Console.WriteLine($"Ты выходишь из корабля и видишь огромную чёрную дверь.\n" +
                                  $"что за ней, ты не знаешь...\n" +
                                  $"Открыв дверь, ты видишь толстого гнома. Выглядит агрессивно.");
                Console.WriteLine($"Гном как только тебя увидел, побежал в твою сторону.\n" +
                                  $"Пристально вглядевшись ты заметил что:\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Здоровье гнома: {bossHealth}\n" +
                                  $"Урон: {bossDamage}\n" +
                                  $"Броня: {bossArmor}\n");
                Console.ResetColor();
                Console.WriteLine($"И что ты выберешь?\n" +
                                     $"{Fight} - Нападаем. \n" +
                                     $"{RunAway} - Я толерантен к гномам (уйти).");
                Console.Write("\nВведи число: ");

                operationCodeSelectPath = Console.ReadLine();
                Console.Clear();

                while (heroAlive && bossAlive)
                {
                    switch (operationCodeSelectPath)
                    {
                        case Fight:

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

                                    Random oneShotMechanic = new Random();
                                    int fireBlow = oneShotMechanic.Next(5, 50);

                                    Console.WriteLine($"Выбери скилл:" +
                                                        $"\n{FireBolt} - Кинуть шар\n" +
                                                        $"{GhostBlade} - Кинуть клинок\n" +
                                                        $"{Invisibility} - Уйти в инвиз\n" +
                                                        $"{StaffStrike} - Попробовать ударить посохом.");
                                    Console.WriteLine("Введи число: ");
                                    bossFight = Console.ReadLine();
                                    Console.Clear();

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"#######\n" +
                                            $"ХП:   {heroHealth}\n" +
                                            $"Мана: {heroMana}\n" +
                                            $"#######");
                                    Console.ResetColor();

                                    switch (bossFight)
                                    {
                                        case FireBolt:
                                            Console.WriteLine("ok");
                                            if (chanceCriticalAttack == getCritical)
                                            {
                                                Console.WriteLine($"Критический урон! ты нанёс: {fireBoltCriticalDamage} урона огненным шаром!.");
                                                break;
                                            }
                                            Console.WriteLine($"Ты наносишь {fireBolt} урона огненным шаром!.");
                                            Console.WriteLine($"#");
                                            Console.WriteLine($"#");
                                            Console.WriteLine($"#");
                                            Console.WriteLine($"#");
                                            break;

                                        case GhostBlade:
                                            Console.WriteLine("ok");
                                            if (chanceCriticalAttack == getCritical)
                                            {
                                                Console.WriteLine($"Критический урон! ты нанёс: {ghostBladeCriticalDamage} урона призрачным клинком!.");
                                                break;
                                            }
                                            Console.WriteLine($"Ты наносишь {ghostBlade} урона призрачным клинком!.");
                                            Console.WriteLine($"#");
                                            Console.WriteLine($"#");
                                            Console.WriteLine($"#");
                                            Console.WriteLine($"#");
                                            break;
                                        case Invisibility:
                                            Console.WriteLine($"Моментально уходишь в инвиз, и восстанавливаешь себе {invisibility} здоровья.");

                                            for (int manaMechanics = heroMana; manaMechanics < maximumHeroMana;)
                                            {
                                                heroMana += manaRegeneration;
                                                Console.WriteLine("Дополнительное восстановление маны: +" + manaRegeneration);
                                                break;
                                            }
                                            break;

                                        case StaffStrike:
                                            if (chanceCriticalAttack == getCritical)
                                            {
                                                Console.WriteLine($"Критический урон! Ты нанёс: {heroCriticalDamage} урона");
                                                bossHealth -= heroCriticalDamage;
                                                if (heroMana == maximumHeroMana)
                                                {
                                                    Console.WriteLine("Уже максимальное колличество маны! Больше восстановить не получится.");
                                                    break;
                                                }
                                                else if (heroMana != maximumHeroMana)
                                                {
                                                    heroMana += manaRegeneration;
                                                    Console.WriteLine($"Удар посохом восстанавливает вам ману." +
                                                                    $" + {manaRegeneration} маны за удар.");
                                                }
                                                break;
                                            }
                                            Console.WriteLine($"Ты бьёшь посохом нанося {heroDamage} урона.");
                                            bossHealth -= heroDamage;

                                            if (heroMana == maximumHeroMana)
                                            {
                                                Console.WriteLine("Уже максимальное колличество маны! Больше восстановить не получится.");
                                                break;
                                            }
                                            else if (heroMana != maximumHeroMana)
                                            {
                                                heroMana += manaRegeneration;
                                                Console.WriteLine($"Удар посохом восстанавливает вам ману." +
                                                                $" + {manaRegeneration} маны за удар.");
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

                                if (heroHealth <= 0)
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
                        case RunAway:
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
