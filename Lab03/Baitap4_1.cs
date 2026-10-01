using System;
using System.Collections.Generic;
using System.Linq;


namespace Lab03{

class Baitap4_1
{
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


 public static void Run()
{
    List <MonHoc> ds= DuLieu.DS_Mon();
	Console.WriteLine("--- DANH SÁCH MÔN HỌC ---"); 
	Console.WriteLine($"{"Mã Môn",-10}|{"Tên Môn",-45}|{"Hệ", -5}|{"Số Tiết",-5}");
	Console.WriteLine(new string('-', 75));  
	
	foreach(var mon in ds)
	{
	   Console.WriteLine($"{mon.MaMon,-10}|{mon.TenMon,-45}|{mon.He, -5}|{mon.SoTiet,-5}");
	}
	Console.WriteLine($"\nTổng số môn học: {ds.Count}");
	
}
}
}