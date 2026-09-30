using System;

namespace Baitap1
{
    class Mainbai2_4
    {
        static void Main(string[] args)
        {
            // --- Test Constructor mặc định ---
            DayPhanSo d0 = new DayPhanSo();
            Console.WriteLine("Day phan so mac dinh: " + d0);

            // --- Test Input/Output ---
            DayPhanSo d1 = new DayPhanSo();
            Console.WriteLine("--- Nhap day phan so d1 ---");
            d1.Input();
            d1.Output();

            // --- Test Copy Constructor ---
            DayPhanSo d2 = new DayPhanSo(d1);
            Console.WriteLine("--- Day phan so d2 (copy tu d1) ---");
            d2.Output();

            // --- Test Tính tổng ---
            PhanSo tong = d1.TinhTong();
            Console.WriteLine("Tong cua day phan so d1 la: " + tong.ToString());
        }
    }
}
