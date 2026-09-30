using System;

namespace Baitap1
{
    class Mainbai2_1
    {
        static void Main(string[] args)
        {
            ArrayPoint arrP = new ArrayPoint();

            // Thêm các điểm vào danh sách
            Point p1 = new Point(1, 2);
            Point p2 = new Point(3, 4);
            Point p3 = new Point(5, 6);

            arrP.Add(p1);
            arrP.Add(p2);
            arrP.Add(p3);

            // Xuất danh sách
            arrP.Output();

            // Test Indexer
            Console.WriteLine("--- Test Indexer ---");
            Console.WriteLine("Phan tu thu 2 (index 1): " + arrP[1]);
        }
    }
}