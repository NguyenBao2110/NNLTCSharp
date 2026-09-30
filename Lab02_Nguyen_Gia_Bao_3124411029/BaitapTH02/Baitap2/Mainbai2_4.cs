using System;

namespace Baitap1
{
    class Mainbai2_4
    {
        static void Main(string[] args)
        {
            // --- Test Constructor mặc định ---
            Mang2Chieu m0 = new Mang2Chieu();
            Console.WriteLine("Ma tran mac dinh: ");
            m0.Output();

            // --- Test Input/Output ---
            Mang2Chieu m1 = new Mang2Chieu();
            Console.WriteLine("--- Nhap ma tran m1 ---");
            m1.Input();
            m1.Output();

            // --- Test Copy Constructor ---
            Mang2Chieu m2 = new Mang2Chieu(m1);
            Console.WriteLine("--- Ma tran m2 (copy tu m1) ---");
            m2.Output();

            // --- Test Tìm số nguyên tố ---
            m1.TimSoNguyenTo();

            // --- Test Indexer ---
            Console.WriteLine("--- Test Indexer ---");
            if (m1.N > 0 && m1.M > 0)
            {
                Console.WriteLine("Phan tu [0,0] cua m1: " + m1[0, 0]);
                m1[0, 0] = 99;
                Console.WriteLine("Sau khi doi m1[0,0] = 99:");
                m1.Output();
            }
        }
    }
}
