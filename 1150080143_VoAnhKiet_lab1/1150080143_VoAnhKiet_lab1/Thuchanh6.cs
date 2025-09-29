using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150080143_VoAnhKiet_lab1
{
    internal class Thuchanh6
    {
        public static void Run()
        {
            Console.Write("Nhap chieu dai: ");
            double dai = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap chieu rong: ");
            double rong = Convert.ToDouble(Console.ReadLine());

            double chuVi = (dai + rong) * 2;
            double dienTich = dai * rong;

            Console.WriteLine("Chu vi la: " + chuVi);
            Console.WriteLine("Dien tich la: " + dienTich);
        }
    }
}
