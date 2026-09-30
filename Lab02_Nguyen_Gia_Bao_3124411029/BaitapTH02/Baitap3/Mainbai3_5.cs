using System;

namespace Baitap1
{
    class Mainbai3_5
    {
        static void Main(string[] args)
        {
            // --- Sử dụng tính đa hình: Mảng NhanVien chứa các lớp con ---
            NhanVien[] danhSach = new NhanVien[3];

            Console.WriteLine("--- Nhap nhan vien kinh doanh ---");
            danhSach[0] = new NhanVienKinhDoanh();
            danhSach[0].Input();

            Console.WriteLine("\n--- Nhap nhan vien san xuat 1 ---");
            danhSach[1] = new NhanVienSanXuat();
            danhSach[1].Input();

            Console.WriteLine("\n--- Nhap nhan vien san xuat 2 ---");
            danhSach[2] = new NhanVienSanXuat();
            danhSach[2].Input();

            Console.WriteLine("\n====== KET QUA TINH LUONG ======");
            double tongLuongCongTy = 0;
            foreach (NhanVien nv in danhSach)
            {
                // Đa hình: Tự động gọi đúng phương thức TinhLuong() của lớp con
                nv.Output(); 
                tongLuongCongTy += nv.TinhLuong();
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("Tong luong cua cong ty: " + tongLuongCongTy.ToString("N0") + " VND");
        }
    }
}