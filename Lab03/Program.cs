using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("        LAB 03 - LINQ EXERCISES         ");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Bai tap 2.1 - Number array");
                Console.WriteLine("2. Bai tap 2.2 - String array");
                Console.WriteLine("3. Bai tap 3.1 - Number statistics");
                Console.WriteLine("4. Bai tap 3.2 - Food list");
                Console.WriteLine("0. Exit");
                Console.WriteLine("========================================");
                Console.Write("Choose (0-4): ");

                string? chon = Console.ReadLine();
                Console.WriteLine();

                switch (chon)
                {
                    case "1":
                        Console.WriteLine(">>> BAI 2.1 <<<\n");
                        Baitap2_1.Run();          // <-- sửa: Baitap2_1
                        break;
                    case "2":
                        Console.WriteLine(">>> BAI 2.2 <<<\n");
                        Baitap2_2.Run();          // <-- sửa: Baitap2_2
                        break;
                    case "3":
                        Console.WriteLine(">>> BAI 3.1 <<<\n");
                        Baitap3_1.Run();          // <-- sửa: Baitap3_1
                        break;
                    case "4":
                        Console.WriteLine(">>> BAI 3.2 <<<\n");
                        Baitap3_2.Run();          // <-- sửa: Baitap3_2
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