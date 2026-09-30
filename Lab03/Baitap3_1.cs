using System;
using System.Linq;
using System.Collections.Generic;

class Baitap3_1
{
    static void Run()
    {
	    int[] mangso = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };
	    
		// a. Tổng số phần tử, số phần tử chẵn, số phần tử lẻ
		int sopt= mangso.Length;
		int soptchan= mangso.Count(x=> x % 2==0);
		int soptle= mangso.Count(x=> x % 2!=0);
		
		Console.WriteLine($"a. Tổng số phần tử: {sopt}");
        Console.WriteLine($"   Số phần tử chẵn: {soptchan}");
        Console.WriteLine($"   Số phần tử lẻ: {soptle}");
		
		
		// b. Tính tổng, giá trị lớn nhất, nhỏ nhất
		
		int tong=mangso.Sum();
		int max=mangso.Max();
		int min=mangso.Min();
		
		Console.WriteLine($"b. Tổng giá trị: {tong}");
        Console.WriteLine($"   Giá trị lớn nhất: {min}");
        Console.WriteLine($"   Giá trị nhỏ nhất: {max}");
		
		// c. Số lượng giá trị khác nhau trong mảng
		
		int slgtkn= mangso.Distinct().Count();
		Console.WriteLine($"c. Số lượng giá trị khác nhau: {slgtkn}");
		
		
		// d. Phân nhóm theo số dư khi chia cho 5
		
		var CauD= mangso.GroupBy(x=>x%5).OrderBy(g=>g.Key);
		Console.WriteLine("d. Phân nhóm theo số dư khi chia cho 5:");
		foreach(var nhom in CauD)
		{
		    Console.WriteLine($" Dư {nhom.Key}: {string.Join(", ",nhom)}");
		}
		Console.WriteLine();

	}
}