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
            int numberN;
            int startValue = 1;
            int endValue = 27;
            int maximumValue = 999;
            int minimumValue = 100;
            Random random = new Random();
            int count = 0;

            numberN = random.Next(startValue, endValue+1);
            Console.WriteLine($"Число N = {numberN}");

            for (int i = numberN; i <= maximumValue; i += numberN)
                {
                if (i >= minimumValue)
                {
                    Console.WriteLine(i);
                    count++;
                }
            }

        Console.WriteLine($"Кол-во трехзначных чисел {count}");
        }
    }

}
