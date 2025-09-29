using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150080143_VoAnhKiet_lab1
{
    internal class Thuchanh11
    {
        public static void Run()
        {
            string filePath = "input_array.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Không tìm thấy file input_array.txt");
                return;
            }

            int[] arr = File.ReadAllText(filePath)
                            .Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

            // Đảm bảo mảng đã được sắp xếp tăng dần (nếu chưa thì sort luôn)
            Array.Sort(arr);

            Console.Write("Nhập số nguyên cần chèn: ");
            int x = int.Parse(Console.ReadLine());

            // Tạo mảng mới có thêm 1 phần tử
            int[] newArr = new int[arr.Length + 1];
            int i = 0, j = 0;

            // Chèn vào đúng vị trí
            while (i < arr.Length && arr[i] < x)
            {
                newArr[j++] = arr[i++];
            }

            newArr[j++] = x;

            while (i < arr.Length)
            {
                newArr[j++] = arr[i++];
            }

            Console.WriteLine("Mảng sau khi chèn:");
            Console.WriteLine(string.Join(" ", newArr));
        }
    }
}
