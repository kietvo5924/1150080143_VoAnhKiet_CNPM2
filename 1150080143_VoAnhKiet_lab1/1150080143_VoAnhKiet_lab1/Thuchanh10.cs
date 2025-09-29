using System;
using System.IO;

namespace _1150080143_VoAnhKiet_lab1
{
    internal class Thuchanh10
    {
        public static void Run()
        {
            string[] data = System.IO.File.ReadAllText("input_array.txt")
                .Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int[] arr = Array.ConvertAll(data, int.Parse);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j] < arr[min]) min = j;

                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }

            Console.WriteLine("Mang sau sap xep: " + string.Join(" ", arr));
        }
    }
}
