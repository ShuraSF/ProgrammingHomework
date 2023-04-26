using System;
using static System.Console;

/*  
 *  Написать метод который выводит на экран строку.
 *  Символы из которых состоит строка и их количество вводится пользователем.
 */

namespace CharStringInMethods
{
    class Program
    {
        static void PrintLine(char symbol, uint symbolsCount)
        {
            for (int i = 0; i < symbolsCount; i++)
            {
                Write(symbol);
            }
        }
        static void Main(string[] args)
        {
            WriteLine("Введите символ : ");
            char symbol = ReadKey().KeyChar;

            WriteLine("\nВведите количество символов:");
            uint symbolsCount = uint.Parse(ReadLine());

            PrintLine(symbol, symbolsCount);
            ReadLine();
        }
    }
}