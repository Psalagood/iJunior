sing System;
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
              Console.Write("Введите имя: ");
              userName = Console.ReadLine();
              Console.Write("Введите символ для оборачивания: ");
              symbol = Console.ReadKey().KeyChar;
              Console.WriteLine();
   
              Console.WriteLine(new string(symbol, userName.Length + 2));
              Console.WriteLine(symbol + userName + symbol);
              Console.WriteLine(new string(symbol, userName.Length + 2));
   
              Console.ReadKey();
          }
      }
}
