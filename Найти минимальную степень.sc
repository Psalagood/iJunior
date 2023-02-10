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
            int minimalDegree = 0;
            int result = 0;
            int degreeNumber = 2;
            int randomNumber;
            Random rand = new Random(); ;
            randomNumber = rand.Next(1, 50);
            
            for (int i = degreeNumber; i <= randomNumber; i *= degreeNumber)
                {
                result = i;
                minimalDegree++;
                }
            Console.WriteLine($"Случайное число: {randomNumber}");
            Console.WriteLine($"Превосходящее случайного числа {result * degreeNumber}");
            Console.WriteLine($"Это {degreeNumber} в степени {minimalDegree}");
        }
    }

}
