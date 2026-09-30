using System;

namespace Baitap1
{
    class Mainbai2_3
    {
        static void Main(string[] args)
        {
            // --- Test Constructor mặc định ---
            DaySo ds0 = new DaySo();
            Console.WriteLine("Day so mac dinh: " + ds0);

            // --- Test Input/Output ---
            DaySo ds1 = new DaySo();
            Console.WriteLine("--- Nhap day so ds1 ---");
            ds1.Input();
            ds1.Output();

            // --- Test Copy Constructor ---
            DaySo ds2 = new DaySo(ds1);
            Console.WriteLine("--- Day so ds2 (copy tu ds1) ---");
            ds2.Output();

            // --- Test Tìm số chẵn ---
            DaySo dsChan = ds1.TimSoChan();
            Console.WriteLine("--- Day so chan cua ds1 ---");
            dsChan.Output();

            // --- Test Indexer ---
            Console.WriteLine("--- Test Indexer ---");
            if (ds1.N > 0)
            {
                Console.WriteLine("Phan tu thu 0 cua ds1: " + ds1[0]);
                ds1[0] = 99; // Thay đổi giá trị thông qua indexer
                Console.WriteLine("Sau khi doi ds1[0] = 99:");
                ds1.Output();
            }
        }
    }
}