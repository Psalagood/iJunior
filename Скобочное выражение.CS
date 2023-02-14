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
            int openBrasket = 1;
            int closeBrasket = -1;
            int brasketsValue = 0;
            float nestingValue = 0;
            float openBrasketValue = 0.5f;
            float closeBrasketValue = 0.5f;

            Console.Write("Введи любое кол-во скобок: ");
            brasketsList = Console.ReadLine();

            for (int i = 0; i < brasketsList.Length; i++)
            {
                char brasketSymbol = brasketsList[i];

                if (brasketSymbol == ')')
                {
                    brasketsValue += closeBrasket;
                    nestingValue += closeBrasketValue;
                }
                else if (brasketSymbol == '(')
                {
                    brasketsValue += openBrasket;
                    nestingValue += openBrasketValue;
                }          
            }

            if (brasketsValue != 0)
            {
                Console.WriteLine("Введено неверное выражение.");
            }
            else if (brasketsList[0] == ')' && brasketsList[brasketsList.Length - 1] == '(')
            {
                Console.WriteLine("Выражение не может начинаться с \")\" и заканчиваться \"(\"");
            }
            Console.WriteLine("Вложенность: " + nestingValue);
        }

    }
}
