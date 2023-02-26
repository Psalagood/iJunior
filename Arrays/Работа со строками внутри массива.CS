using System;
using System.Dynamic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] array = { { 11, 22, 33, 44, 55, 66 }, { 66, 31, 33, 45, 12, 1111 }, { 44,51,678,98,7,55} };
            int firstSymbolOneColumn = array[0, 0];
            int firstSymbolTwoColumn = array[1, 0];
            int sumSymbolsFirstArray = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Первые числа: {firstSymbolOneColumn} и {firstSymbolTwoColumn} "); 
            Console.WriteLine("Произведение первых чисел первого столбца: " + (firstSymbolOneColumn * firstSymbolTwoColumn));

            for (int i = 0; i < array.GetLength(0); i++)
            {
                sumSymbolsFirstArray += array.GetLength(0);
                Console.WriteLine(i);
            }
            Console.WriteLine("Сумма первого массива: " + sumSymbolsFirstArray);
        }
        
    }
}
