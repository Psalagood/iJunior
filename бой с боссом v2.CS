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
            {
                int bossDamage = 15;
                int bossHealth = 8000;
                int bossMana = 1500;
                int bossArmor = 0;

                int heroDamage = 100;
                int heroHealth = 150;
                int heroMana = 100;
                int heroArmor = 10;
                int manaRegeneration = 5;
                int maximumHeroMana = 100;
                

                Random skillDamage = new Random();
                int fireBolt = skillDamage.Next(40, 100);
                int ghostBlade = skillDamage.Next(40, 100);
                Random skillHealth = new Random();
                int invisibility = skillHealth.Next(5, 50);

                int priceFireBolt = 15;
                int priceGhostBlade = 15;
                int priceInvisibility = 40;


                bool heroAlive = true;
                bool bossAlive = true;
                string operationCodeSelectPath;
                const string Fight = "1";
                const string RunAway = "2";
                string useSkills;
                const string FireBolt = "1";
                const string GhostBlade = "2";
                const string Invisibility = "3";
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
                                     $"{Fight} Нападаем. \n" +
                                     $"{RunAway} Я толерантен к гномам (уйти).");
                Console.Write("\nВведи число: ");

                operationCodeSelectPath = Console.ReadLine();

                while (heroAlive && bossAlive ) 
                {
                    switch (operationCodeSelectPath)
                    {
                        case Fight:
                            {
                                while (heroHealth > 0 && bossHealth >0)
                                {
                                    Console.WriteLine($"{FireBolt} - кинуть шар\n" +
                                                        $"{GhostBlade} - кинуть клинок\n" +
                                                        $"{Invisibility} - уйти в инвиз");
                                    Console.WriteLine("Введи число: ");
                                    bossFight = Console.ReadLine();

                                    switch (bossFight)
                                    {
                                        case FireBolt:
                                            if (heroMana >= 0)
                                            {
                                               heroMana -= priceFireBolt;
                                               Console.WriteLine($"Firebolt нанёс {fireBolt} урона.\n" +
                                               $"Однако у вас осталось {heroMana} маны.");
                                               bossHealth -= fireBolt;
                                               Console.WriteLine($"У босса осталось {bossHealth} хп");

                                               if (heroMana != maximumHeroMana)
                                               {
                                                    heroMana += manaRegeneration;
                                               }
                                            }
                                            else if (heroMana < 0)
                                            {
                                                Console.WriteLine("Недостаточно маны!!!");
                                                break;
                                            }
                                            break;
                                        case GhostBlade:
                                            Console.WriteLine("ok");
                                            break;
                                        case Invisibility:
                                            Console.WriteLine("ok");
                                            break;
                                        default:
                                            Console.WriteLine("Команда не найдена.");
                                            Console.Clear();
                                            break;
                                    }
                                }
                                if (heroHealth <= 0)
                                {
                                    Console.WriteLine("Тебя отпинали как собаку.");
                                    heroAlive = false;
                                }
                                else if(bossHealth <= 0)
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
