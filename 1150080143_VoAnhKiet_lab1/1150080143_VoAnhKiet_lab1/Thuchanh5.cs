using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150080143_VoAnhKiet_lab1
{
    internal class Thuchanh5
    {
        public static void Run()
        {
            Console.Write("Nhap vao so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine(n + " la so chan");
            }
            else
            {
                Console.WriteLine(n + " la so le");
            }

            if (n < 0)
            {
                Console.WriteLine(n + " la so am");
            }
            else
            {
                Console.WriteLine(n + " la so khong am");
            }
        }
    }
}
