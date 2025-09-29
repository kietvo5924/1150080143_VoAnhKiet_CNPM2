using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150080143_VoAnhKiet_lab1
{
    internal class Thuchanh7
    {
        public static void Run()
        {
            Console.Write("Nhap canh a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap canh b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap canh c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                double chuVi = a + b + c;
                double p = chuVi / 2;
                double dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                Console.WriteLine("Chu vi tam giac la: " + chuVi);
                Console.WriteLine("Dien tich tam giac la: " + dienTich);
            }
            else
            {
                Console.WriteLine("Khong tao thanh tam giac");
            }
        }
    }
}
