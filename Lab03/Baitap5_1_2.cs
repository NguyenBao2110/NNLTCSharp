using System;
using System.Collections.Generic;
using System.Linq;


namespace Lab03.Bai5{

   
// 1. Tạo lớp MonHoc với các thuộc tính theo yêu cầu
public class MonHoc
{
    public string MaMon{get; set;}="";
	public string TenMon{get; set;}="";
	public string He{get; set;}="";
	public byte SoTiet{get; set;}
	
	public MonHoc(string MM, string TM, string H, byte ST)
	{
	    MaMon=MM;
		TenMon=TM;
		He=H;
		SoTiet=ST;
	}
	
}

// 2. Tạo lớp DuLieu chứa phương thức tĩnh DS_Mon()
public class DuLieu
{
    public static List<MonHoc> DS_Mon()
    {
        List<MonHoc> danhSachMonHoc = new List<MonHoc>();

       
        danhSachMonHoc.Add(new MonHoc("HP2_1", "Nền tảng C#", "KTV", 64));
        danhSachMonHoc.Add(new MonHoc("HP2_2", "Công nghệ ADO.NET", "KTV", 64));
        danhSachMonHoc.Add(new MonHoc("HP3_1", "Lập trình Windows Forms", "KTV", 64));
        danhSachMonHoc.Add(new MonHoc("HP3_2", "Xây dựng ứng dụng Windows Forms", "KTV", 64));
        danhSachMonHoc.Add(new MonHoc("HP4_1", "Lập trình Web với HTML, CSS và JavaScript", "KTV", 64));
        danhSachMonHoc.Add(new MonHoc("HP4_2", "Xây dựng ứng dụng Web với ASP.NET", "KTV", 64));
        danhSachMonHoc.Add(new MonHoc("HP5_1", "Lập trình CSDL SQL Server căn bản", "KTV", 64));
        danhSachMonHoc.Add(new MonHoc("HP5_2", "Lập trình CSDL SQL Server nâng cao", "KTV", 64));
        danhSachMonHoc.Add(new MonHoc("JLCB", "Joomla cơ bản", "CD", 72));
        danhSachMonHoc.Add(new MonHoc("LINQ", "Language-Integrated Query", "CD", 64));
        danhSachMonHoc.Add(new MonHoc("DAWEB", "Đồ án thực tế Web với ASP.NET", "CD", 40));
        danhSachMonHoc.Add(new MonHoc("DAWIN", "Đồ án thực tế Windows Forms", "CD", 40));
        danhSachMonHoc.Add(new MonHoc("CC++", "Lập trình hướng đối tượng với C/C++", "CD", 128));
        danhSachMonHoc.Add(new MonHoc("JQUE", "JQuery", "CD", 22));
        danhSachMonHoc.Add(new MonHoc("XML", "Công nghệ XML", "CD", 32));
        danhSachMonHoc.Add(new MonHoc("CRYS", "Crystal Report trong Visual Studio", "CD", 32));
        danhSachMonHoc.Add(new MonHoc("BWEB", "HTML, CSS và JavaScript", "CD", 32));
        danhSachMonHoc.Add(new MonHoc("XYZ", "Chưa đặt tên môn", "", 0)); // Hệ để trống, số tiết = 0

        return danhSachMonHoc;
    }
}

public class Baitap5_1_2
{
    public static void Run()
    {
        List<MonHoc> ds = DuLieu.DS_Mon();

        Console.WriteLine("========== BÀI 5.1: TRUY VẤN CƠ BẢN ==========");
        
        // a. Liệt kê các môn học bắt đầu bằng "Lập trình"
        var cau5_1a = ds.Where(m => m.TenMon.StartsWith("Lập trình"));
        Console.WriteLine("a. Môn học bắt đầu bằng 'Lập trình':");
        foreach (var m in cau5_1a) Console.WriteLine($"   {m.MaMon} - {m.TenMon}");

        // b. Liệt kê các môn thuộc hệ "CD", sắp xếp số tiết giảm dần rồi môn tăng dần
        var cau5_1b = ds.Where(m => m.He == "CD")
                        .OrderByDescending(m => m.SoTiet)
                        .ThenBy(m => m.TenMon);
        Console.WriteLine("\nb. Môn hệ 'CD', sắp xếp theo Số tiết giảm dần, Tên môn tăng dần:");
        foreach (var m in cau5_1b) Console.WriteLine($"   {m.SoTiet} tiết - {m.TenMon}");

        // c. Liệt kê các môn có tên chứa từ "web", chỉ lấy Tên môn và Hệ
        var cau5_1c = ds.Where(m => m.TenMon.ToLower().Contains("web"))
                        .Select(m => new { m.TenMon, m.He });
        Console.WriteLine("\nc. Môn có tên chứa 'web' (Tên môn - Hệ):");
        foreach (var m in cau5_1c) Console.WriteLine($"   {m.TenMon} - {m.He}");

        // d. Liệt kê các môn thuộc hệ "KTV", sắp xếp tăng dần theo Mã môn
        var cau5_1d = ds.Where(m => m.He == "KTV").OrderBy(m => m.MaMon);
        Console.WriteLine("\nd. Môn hệ 'KTV', sắp xếp tăng dần theo Mã môn:");
        foreach (var m in cau5_1d) Console.WriteLine($"   {m.MaMon} - {m.TenMon}");


        Console.WriteLine("\n========== BÀI 5.2: THỐNG KÊ TRÊN List<MonHoc> ==========");

        // a. Cho biết tổng số môn học có.
        Console.WriteLine($"a. Tổng số môn học: {ds.Count}");

        // b. Đếm số môn có tên bắt đầu bằng "Lập trình".
        int demLapTrinh = ds.Count(m => m.TenMon.StartsWith("Lập trình"));
        Console.WriteLine($"b. Số môn bắt đầu bằng 'Lập trình': {demLapTrinh}");

        // c. Tính tổng số tiết của hệ Kỹ thuật viên (KTV).
        int tongTietKTV = ds.Where(m => m.He == "KTV").Sum(m => m.SoTiet);
        Console.WriteLine($"c. Tổng số tiết hệ KTV: {tongTietKTV}");

        // d. Cho biết tổng số môn của mỗi hệ: Hệ, Tổng số môn.
        var cau5_2d = ds.GroupBy(m => m.He).Select(g => new { He = g.Key, TongSoMon = g.Count() });
        Console.WriteLine("d. Tổng số môn của mỗi hệ:");
        foreach (var item in cau5_2d) Console.WriteLine($"   Hệ '{item.He}': {item.TongSoMon} môn");

        // e. Nhóm theo Số tiết; in Số tiết và Tổng số môn, sắp xếp giảm dần theo Số tiết.
        var cau5_2e = ds.GroupBy(m => m.SoTiet)
                        .Select(g => new { SoTiet = g.Key, TongSoMon = g.Count() })
                        .OrderByDescending(x => x.SoTiet);
        Console.WriteLine("e. Nhóm theo Số tiết (Số tiết - Tổng số môn), giảm dần theo Số tiết:");
        foreach (var item in cau5_2e) Console.WriteLine($"   {item.SoTiet} tiết: {item.TongSoMon} môn");

        // f. Cho biết thông tin môn học có số tiết cao nhất.
        byte maxSoTiet = ds.Max(m => m.SoTiet);
        var cau5_2f = ds.Where(m => m.SoTiet == maxSoTiet);
        Console.WriteLine("f. Môn học có số tiết cao nhất:");
        foreach (var m in cau5_2f) Console.WriteLine($"   {m.MaMon} - {m.TenMon} ({m.SoTiet} tiết)");

        // g. Thống kê theo Hệ: tổng số môn, tổng số tiết, số tiết cao nhất, số tiết thấp nhất.
        var cau5_2g = ds.GroupBy(m => m.He).Select(g => new
        {
            He = g.Key,
            TongSoMon = g.Count(),
            TongSoTiet = g.Sum(m => m.SoTiet),
            MaxSoTiet = g.Max(m => m.SoTiet),
            MinSoTiet = g.Min(m => m.SoTiet)
        });
        Console.WriteLine("g. Thống kê theo Hệ:");
        foreach (var item in cau5_2g) 
            Console.WriteLine($"   Hệ '{item.He}': {item.TongSoMon} môn, Tổng {item.TongSoTiet} tiết, Max {item.MaxSoTiet}, Min {item.MinSoTiet}");

        // h. Liệt kê các môn học được phân nhóm theo Hệ.
        Console.WriteLine("h. Phân nhóm môn học theo Hệ:");
        var cau5_2h = ds.GroupBy(m => m.He);
        foreach (var nhom in cau5_2h)
        {
            Console.WriteLine($"   Hệ '{nhom.Key}':");
            foreach (var m in nhom) Console.WriteLine($"      {m.MaMon} - {m.TenMon}");
        }

        // i. Liệt kê các môn học được phân nhóm theo Số tiết và tăng dần theo Số tiết.
        Console.WriteLine("i. Phân nhóm môn học theo Số tiết (tăng dần):");
        var cau5_2i = ds.GroupBy(m => m.SoTiet).OrderBy(g => g.Key);
        foreach (var nhom in cau5_2i)
        {
            Console.WriteLine($"   {nhom.Key} tiết:");
            foreach (var m in nhom) Console.WriteLine($"      {m.MaMon} - {m.TenMon}");
        }

        // j. Với hệ KTV, phân nhóm theo học phần HP2, HP3, HP4, HP5; sắp xếp theo Mã môn.
        Console.WriteLine("j. Hệ KTV phân nhóm theo học phần (HP2, HP3, HP4, HP5):");
        var cau5_2j = ds.Where(m => m.He == "KTV")
                        .GroupBy(m => m.MaMon.Substring(0, 3)) // Lấy 3 ký tự đầu: HP2, HP3...
                        .OrderBy(g => g.Key);
        foreach (var nhom in cau5_2j)
        {
            Console.WriteLine($"   Nhóm {nhom.Key}:");
            foreach (var m in nhom.OrderBy(x => x.MaMon)) // Sắp xếp theo mã môn trong nhóm
                Console.WriteLine($"      {m.MaMon} - {m.TenMon}");
        }

        // k. Phân nhóm theo Hệ, chỉ lấy các môn có Số tiết > 40; trong mỗi nhóm sắp xếp theo Mã môn.
        Console.WriteLine("k. Phân nhóm theo Hệ (chỉ môn > 40 tiết, sắp xếp theo Mã môn):");
        var cau5_2k = ds.GroupBy(m => m.He).Select(g => new
        {
            He = g.Key,
            MonHocs = g.Where(m => m.SoTiet > 40).OrderBy(m => m.MaMon).ToList()
        });
        foreach (var nhom in cau5_2k)
        {
            Console.WriteLine($"   Hệ '{nhom.He}':");
            foreach (var m in nhom.MonHocs) Console.WriteLine($"      {m.MaMon} - {m.TenMon} ({m.SoTiet} tiết)");
        }
    }
}
}