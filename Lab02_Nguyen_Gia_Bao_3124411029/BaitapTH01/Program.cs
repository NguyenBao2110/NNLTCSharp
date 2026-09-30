using System;

namespace BaitapTH01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool thoat = false;
            while (!thoat)
            {
                Console.WriteLine("===== MENU BAI TAP TH01 =====");
                for (int i = 1; i <= 17; i++)
                {
                    Console.WriteLine($"{i}. Bai tap {i}");
                }
                Console.WriteLine("0. Thoat");
                Console.Write("Chon bai can chay: ");
                string chon = Console.ReadLine();
                Console.WriteLine();

                switch (chon)
                {
                    case "2": new Baitap2().Run(); break;
                    case "3": new Baitap3().Run(); break;
                    case "4": new Baitap4().Run(); break;
                    case "5": new Baitap05().Run(); break;
                    case "6": new Baitap6().Run(); break;
                    case "7": new Baitap7().Run(); break;
                    case "8": new Baitap8().Run(); break;
                    case "9": new Baitap9().Run(); break;
                    case "10": new Baitap10().Run(); break;
                    case "11": new Baitap11().Run(); break;
                    case "12": new Baitap12().Run(); break;
                    case "13": new SinhVien().Run(); break;
                    case "14": new NhanVien().Run(); break;
                    case "15": new Baitap15().Run(); break;
                    case "16": new Baitap16().Run(); break;
                    case "17": new Baitap17().Run(); break;
                    case "0": thoat = true; break;
                    default: Console.WriteLine("Lua chon khong hop le!"); break;
                }

                if (!thoat)
                {
                    Console.WriteLine();
                    Console.WriteLine("Nhan Enter de quay lai menu...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}