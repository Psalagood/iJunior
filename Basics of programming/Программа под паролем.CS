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
            string password = "SoloMid";
            string secretMessage = "я афк";
            int tryCount = 3;
            string userInput;
            int remainderOfAttempts = tryCount;

            for (int i = 0; i < tryCount; i++)
            {
                Console.Write("Введи парооль: ");
                userInput = Console.ReadLine();

                if (userInput != password)
                {
                    Console.WriteLine("Не верно! ");
                    remainderOfAttempts--;
                    Console.WriteLine($"У тебя {remainderOfAttempts} попыток");
                }
                else if (userInput == password)
                {
                    Console.WriteLine("Верно!");
                    Console.WriteLine($"Секретное сообщение было {secretMessage}");
                    break;
                }
            }
            if (remainderOfAttempts == 0)
            {
                Console.WriteLine("Попытки кончились");
            }
        }
    }
}
