using System;

namespace _1150080143_VoAnhKiet_lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // hỗ trợ tiếng Việt

            while (true) // vòng lặp menu
            {
                Console.Clear();
                Console.WriteLine("===== MENU BÀI TẬP =====");
                Console.WriteLine("1. Thực hành 1");
                Console.WriteLine("2. Thực hành 2");
                Console.WriteLine("3. Thực hành 3");
                Console.WriteLine("4. Thực hành 4");
                Console.WriteLine("5. Thực hành 5");
                Console.WriteLine("6. Thực hành 6");
                Console.WriteLine("7. Thực hành 7");
                Console.WriteLine("8. Thực hành 8");
                Console.WriteLine("9. Thực hành 9");
                Console.WriteLine("10. Thực hành 10");
                Console.WriteLine("11. Thực hành 11");
                Console.WriteLine("0. Thoát");
                Console.Write("\nNhập số bài tập muốn chạy: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Vui lòng nhập số hợp lệ!");
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();

                switch (choice)
                {
                    case 1: Thuchanh1.Run(); break;
                    case 2: Thuchanh2.Run(); break;
                    case 3: Thuchanh3.Run(); break;
                    case 4: Thuchanh4.Run(); break;
                    case 5: Thuchanh5.Run(); break;
                    case 6: Thuchanh6.Run(); break;
                    case 7: Thuchanh7.Run(); break;
                    case 8: Thuchanh8.Run(); break;
                    case 9: Thuchanh9.Run(); break;
                    case 10: Thuchanh10.Run(); break;
                    case 11: Thuchanh11.Run(); break;
                    case 0:
                        Console.WriteLine("Thoát chương trình.");
                        return; // thoát Main
                    default:
                        Console.WriteLine("Không có lựa chọn này!");
                        break;
                }

                Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
                Console.ReadKey();
            }
        }
    }
}
