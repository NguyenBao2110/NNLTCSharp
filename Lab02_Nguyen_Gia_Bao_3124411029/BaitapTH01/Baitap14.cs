using System;

namespace BaitapTH01
{
    using System;

public class NhanVien
{
    public string HoTen { get; set; }
    public double MucLuong { get; set; }
    public int SoNgayVang { get; set; }

    public void Nhap()
    {
        Console.Write("Nhập họ tên nhân viên: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhập mức lương cơ bản: ");
        MucLuong = double.Parse(Console.ReadLine());
        Console.Write("Nhập số ngày vắng: ");
        SoNgayVang = int.Parse(Console.ReadLine());
    }

    public double TinhLuong()
    {
        // Một ngày vắng trừ 100.000 VNĐ
        double tienPhat = SoNgayVang * 100000;
        double luongThucNhan = MucLuong - tienPhat;
        
        // Đảm bảo lương không bị âm
        return luongThucNhan > 0 ? luongThucNhan : 0;
    }

    public void Xuat()
    {
        Console.WriteLine("--- Thông tin lương nhân viên ---");
        Console.WriteLine($"Họ tên: {HoTen}");
        Console.WriteLine($"Mức lương: {MucLuong:N0} VNĐ");
        Console.WriteLine($"Số ngày vắng: {SoNgayVang}");
        Console.WriteLine($"Lương thực nhận: {TinhLuong():N0} VNĐ");
    }


    public void Run()
    {
        NhanVien nv = new NhanVien();
        nv.Nhap();
        nv.Xuat();
    }
  }
}