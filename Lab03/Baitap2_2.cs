using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab03{
class Baitap2_2
{
     public static void Run()
	 {
	      string[] mangchuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga", "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân" };
		  
		  // a. Liệt kê các phần tử có 4 ký tự và sắp xếp tăng dần
		  var CauA= mangchuoi.Where(s=> s.Length==4).OrderBy(s => s);
		  Console.WriteLine("a.Các phần tử có 4 ký tự và sắp xếp tăng dần: "+ string.Join(",", CauA));
		  
		  // b. Biến đổi mỗi phần tử thành dạng: <chữ thường> -> <CHỮ HOA>
		  var CauB= mangchuoi.Select(s=> $"{s.ToLower()}-> {s.ToUpper()}");
		  Console.WriteLine("b.Biến đổi <chữ thường> -> <CHỮ HOA>: ");
		  foreach(var item in CauB)
		  {
		       Console.WriteLine("   "+item);
		  }
		  
		  // c. Các từ bắt đầu bằng chữ in hoa
		  var CauC = mangchuoi.Where(s => s.Length>0 && char.IsUpper(s[0]));
		  Console.WriteLine("c. Các từ bắt đầu bằng chữ in hoa: " + string.Join(" ", CauC));
		  
	 }
}
}