using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
   internal class Program
   {
         static void Main(string[] args)
            {
        string userName;
        char symbol;

        Console.Write("Введи имя: ");
        userName = Console.ReadLine();
        Console.Write("Введи символ: ");
        symbol = Convert.ToChar(Console.Read());

        string secondRow = symbol + userName + symbol;
        string frame = "";

       for (int i = 0; i < secondRow.Length; i++)
        {
             frame += symbol;
        }

       Console.WriteLine(frame);
       Console.WriteLine(secondRow);
       Console.WriteLine(frame);          
      }
   }
}
