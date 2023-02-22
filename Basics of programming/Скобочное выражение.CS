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

                if (brasketSymbol == closeBrasketChar)
                {
                    depth--;
                    
                    if (depth > maxDepth)
                    {
                        maxDepth++;
                    }
                }
                else if (brasketSymbol == openBrasketChar)
                {
                    depth++;

                    if (depth > maxDepth)
                    {
                        maxDepth++;
                    }
                }
            }

            if (depth != 0)
            {
                Console.WriteLine("Введено неверное выражение.");
            }
            else if (brasketsList[0] == ')' && brasketsList[brasketsList.Length - 1] == '(')
            {
                Console.WriteLine($"Выражение не может начинаться с \"{closeBrasketChar}\" и заканчиваться \"{openBrasketChar}\"");
            }
            else if (depth == 0)
            {
                Console.WriteLine("Запись корректна");
            }
            Console.WriteLine("Глубина: " + depth);
            Console.WriteLine("Максимальная глубина: " + maxDepth);
        }

    }
}
