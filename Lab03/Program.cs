using System;
using Lab03.Bai5;   
using Lab03.Bai6;   

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("          LAB 03 - LINQ EXERCISES             ");
                Console.WriteLine("==============================================");
                Console.WriteLine("1. Bai tap 2.1 - Number array");
                Console.WriteLine("2. Bai tap 2.2 - String array");
                Console.WriteLine("3. Bai tap 3.1 - Number statistics");
                Console.WriteLine("4. Bai tap 3.2 - Food list");
                Console.WriteLine("5. Bai tap 4.1 - Danh sach MonHoc");
                Console.WriteLine("6. Bai tap 5.1 & 5.2 - Truy van & Thong ke MonHoc");
                Console.WriteLine("7. Bai tap 6.1 & 6.2 - Join & Set Operators");
                Console.WriteLine("0. Exit");
                Console.WriteLine("==============================================");
                Console.Write("Choose (0-7): ");

                string? chon = Console.ReadLine();
                Console.WriteLine();

                switch (chon)
                {
                    case "1":
                        Console.WriteLine(">>> BAI 2.1 <<<\n");
                        Baitap2_1.Run();
                        break;

                    case "2":
                        Console.WriteLine(">>> BAI 2.2 <<<\n");
                        Baitap2_2.Run();
                        break;

                    case "3":
                        Console.WriteLine(">>> BAI 3.1 <<<\n");
                        Baitap3_1.Run();
                        break;

                    case "4":
                        Console.WriteLine(">>> BAI 3.2 <<<\n");
                        Baitap3_2.Run();
                        break;

                    case "5":
                        Console.WriteLine(">>> BAI 4.1 <<<\n");
                        Baitap4_1.Run();
                        break;

                    case "6":
                        Console.WriteLine(">>> BAI 5.1 & 5.2 <<<\n");
                        Baitap5_1_2.Run();     // <-- SỬA: bỏ ".Program"
                        break;

                    case "7":
                        Console.WriteLine(">>> BAI 6.1 & 6.2 <<<\n");
                        Baitap6_1_2.Run();     // <-- SỬA: bỏ ".Program"
                        break;

                    case "0":
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}