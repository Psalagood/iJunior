using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string brasketsList;
            int depth = 0;
            int maxDepth = 0;
            char openBrasketChar = '(';
            char closeBrasketChar = ')';

            Console.Write("Введи любое кол-во скобок: ");
            brasketsList = Console.ReadLine();

            for (int i = 0; i < brasketsList.Length; i++)
            {
                if (depth < 0)
                {
                    Console.WriteLine("Выражение не верное");
                    break;
                }
                else;
                {
                    if (brasketsList[i] == closeBrasketChar)
                    {
                        depth--;
                    }
                    if (brasketsList[i] == openBrasketChar)
                    {
                        depth++;
                    }

                    if (depth > maxDepth)
                    {
                        maxDepth++;
                    }
                }
            }

            if (depth == 0)
            {
                Console.WriteLine("Запись корректна");
            }
            if (depth != 0)
            {
                Console.WriteLine("запись не верна.");
            }
            Console.WriteLine("Максимальная глубина: " + maxDepth);
        }
    }
}
