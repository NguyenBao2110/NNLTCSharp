using System;

namespace Baitap1
{
    class Mainbai3_6
    {
        static void Main(string[] args)
        {
            // --- Sử dụng tính đa hình: Mảng ThiSinh chứa các lớp con ---
            ThiSinh[] danhSach = new ThiSinh[2];

            Console.WriteLine("--- Nhap thong tin Thi Sinh Chuyen ---");
            danhSach[0] = new ThiSinhChuyen();
            danhSach[0].Input();

            Console.WriteLine("\n--- Nhap thong tin Thi Sinh Sieu Cup ---");
            danhSach[1] = new ThiSinhSieuCup();
            danhSach[1].Input();

            Console.WriteLine("\n====== KET QUA THI ======");
            foreach (ThiSinh ts in danhSach)
            {
                // Đa hình: Tự động gọi đúng TinhTongDiem() của từng lớp
                ts.Output(); 
                Console.WriteLine("--------------------");
            }
        }
    }
}