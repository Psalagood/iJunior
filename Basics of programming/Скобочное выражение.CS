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
                char brasketSymbol = brasketsList[i];

                if (depth < 0)
                {
                    Console.WriteLine("Выражение не верное");
                    break;
                }
                else;
                {
                    if (brasketSymbol == closeBrasketChar)
                    {
                        depth--;
                    }
                    if (brasketSymbol == openBrasketChar)
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
            else;
            {
                Console.WriteLine("запись не верна.");
            }
            Console.WriteLine("Глубина: " + depth);
            Console.WriteLine("Максимальная глубина: " + maxDepth);
        }
    }
}
