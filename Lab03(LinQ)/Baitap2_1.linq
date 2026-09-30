<Query Kind="Program" />

using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
	{
	    int[] mangso= { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };
		
		// a. Liệt kê các phần tử chia hết cho 4 và 3 
		var CauA= mangso.Where(x => x % 4 == 0 && x % 3 == 0);
		Console.WriteLine("a. Chia het cho 4 va 3: "+ string.Join(",", CauA));
		
		// b. Liệt kê các phần tử nhỏ hơn hoặc bằng 3
		var CauB= mangso.Where(x => x <= 3);
		Console.WriteLine("b.Nho hon hoac bang 3: "+ string.Join(",", CauB));
		
		//c.Tạo một dãy mới: số chẵn chia đôi, số lẻ giữ nguyên giá trị.
		int[] CauC= mangso.Select(x => x % 2 == 0 ? x/2 : x).ToArray();
		Console.WriteLine("c. Số chẵn giữ nguyên, số lẻ đổi dấu: " + string.Join(", ", CauC));
        Console.WriteLine();
	}
}