using System;

namespace BaitapTH01
{
    public class SinhVien
{
    public string MaSV { get; set; }
    public string HoTen { get; set; }
    public string DiaChi { get; set; }
    public int NamThu { get; set; }

    // Phương thức nhập thông tin
    public void Nhap()
    {
        Console.Write("Nhập mã sinh viên: ");
        MaSV = Console.ReadLine();
        Console.Write("Nhập họ tên: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhập địa chỉ: ");
        DiaChi = Console.ReadLine();
        Console.Write("Nhập năm thứ: ");
        NamThu = int.Parse(Console.ReadLine());
    }

    // Phương thức xuất thông tin
    public void Xuat()
    {
        Console.WriteLine("--- Thông tin sinh viên ---");
        Console.WriteLine($"Mã SV: {MaSV}");
        Console.WriteLine($"Họ tên: {HoTen}");
        Console.WriteLine($"Địa chỉ: {DiaChi}");
        Console.WriteLine($"Năm thứ: {NamThu}");
    }

    public void Run()
    {
        SinhVien sv = new SinhVien();
        sv.Nhap();
        sv.Xuat();
    }
  } 
}