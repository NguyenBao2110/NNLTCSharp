using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab03{
class Baitap3_2
{
    public static void Run()
    {
	    string[] monan = { "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì", "Nước Cà phê", "Mì quảng", "Cơm tấm", "Nước Chanh dây", "Mì xào", "Bún riêu", "Bánh cuốn", "Mì gói", "Bún chả", "Hủ tiếu Nam vang" };
		
		// a. Tìm các phần tử có chiều dài ngắn nhất và dài nhất
		int max= monan.Max(s=>s.Length);
		int min= monan.Min(s=>s.Length);
		
		var ptdainhat= monan.Where(s=>s.Length==max);
		var ptngannhat= monan.Where(s=>s.Length==min);
		
		Console.WriteLine($"a. Độ dài ngắn nhất ({min} ký tự): {string.Join(", ", ptngannhat)}");
        Console.WriteLine($"   Độ dài dài nhất ({max} ký tự): {string.Join(", ", ptdainhat)}");
		
		// b. Phân nhóm theo từ đầu tiên của tên món
		
		var CauB= monan.GroupBy(s=>s.Split(" ")[0]);
		Console.WriteLine("b. Phân nhóm theo từ đầu tiên của tên món:");
		foreach(var mon in CauB)
		{
		    Console.WriteLine($"   Nhóm {mon.Key}: {string.Join(", ",mon)}");
		}
		
		 // c. Đếm số phần tử có từ đầu tiên là "Bánh"
		 
		 int CauC= monan.Count(s=>s.Split(" ")[0]=="Bánh");
		 Console.WriteLine($"c. Số món có từ đầu tiên là 'Bánh': {CauC}");
		
	}
}
}