using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150080143_VoAnhKiet_lab1
{
    internal class Thuchanh9
    {
        public static void Run()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[" + i + "] = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += arr[i];
            }

            Console.WriteLine("Tong cac phan tu trong mang la: " + tong);
        }
    }
}
