using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ChangingSizeInArray
{
    // Написать метод Resize изменяющий кол-во элементов массива
    // Метод должен иметь возможность увеличить кол-во элементов массива
    public class Program
    {
        static void Resize<T>(ref  T[] array, int newSize) // вместо Int пишем T это generic
        {
            T[] newArray = new T[newSize];

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }
        static void Main(string[] args)
        {
           // int[] arr = { 1, 4, 6 };
            string[] strArray = { "test", "hello", "world" };

            Resize(ref strArray, 10);

        }
    }
}