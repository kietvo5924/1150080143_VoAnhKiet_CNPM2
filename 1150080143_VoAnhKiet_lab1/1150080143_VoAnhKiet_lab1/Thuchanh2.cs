using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150080143_VoAnhKiet_lab1
{
    internal class Thuchanh2
    {
        public static void Run()
        {
            Console.Write("Nhập vào số nguyên a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập vào số nguyên b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            // Tìm số max
            int max = (a > b) ? a : b;

            // Hiển thị kết quả
            Console.WriteLine("Số lớn hơn trong 2 số là: " + max);
        }
    }
}
