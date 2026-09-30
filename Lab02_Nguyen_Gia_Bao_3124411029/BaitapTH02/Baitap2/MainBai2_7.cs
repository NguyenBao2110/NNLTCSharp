using System;

namespace Baitap1
{
    class Mainbai2_5
    {
        static void Main(string[] args)
        {
            // --- Test Constructor mặc định ---
            PhongBan pb0 = new PhongBan();
            Console.WriteLine("Phong ban mac dinh co " + pb0.N + " nhan vien.");

            // --- Test Input/Output ---
            PhongBan pb1 = new PhongBan();
            Console.WriteLine("--- Nhap thong tin phong ban pb1 ---");
            pb1.Input();
            pb1.Output();

            // --- Test Copy Constructor ---
            PhongBan pb2 = new PhongBan(pb1);
            Console.WriteLine("--- Phong ban pb2 (copy tu pb1) ---");
            pb2.Output();

            // --- Test Tính tổng lương ---
            double tongLuong = pb1.TinhTongLuong();
            Console.WriteLine("Tong luong cua phong ban pb1 la: " + tongLuong.ToString("N0") + " VND");
        }
    }
}