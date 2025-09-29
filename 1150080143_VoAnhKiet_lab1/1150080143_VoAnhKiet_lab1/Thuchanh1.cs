using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150080143_VoAnhKiet_lab1
{
    internal class Thuchanh1
    {
        public static void Run()
        {
            Console.Write("Nhập vào chiều dài: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập vào chiều rộng: ");
            double b = Convert.ToDouble(Console.ReadLine());

            // Tính chu vi và diện tích
            double chuVi = (a + b) * 2;
            double dienTich = a * b;

            // Hiển thị kết quả
            Console.WriteLine("Chu vi là: " + chuVi);
            Console.WriteLine("Diện tích là: " + dienTich);
        }
    }
}
