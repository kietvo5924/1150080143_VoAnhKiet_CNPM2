using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150080143_VoAnhKiet_lab1
{
    internal class Thuchanh8
    {
        public static void Run()
        {
            Console.Write("Nhap a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phuong trinh vo so nghiem");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine("Phuong trinh co nghiem: x = " + x);
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Phuong trinh co nghiem kep x = " + x);
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phuong trinh co 2 nghiem x1 = " + x1 + ", x2 = " + x2);
                }
            }
        }
    }
}
