using System;

namespace Baitap1
{
    class Mainbai2_3_DaThuc
    {
        static void Main(string[] args)
        {
            // --- Test Constructor mặc định ---
            DaThuc dt0 = new DaThuc();
            Console.WriteLine("Da thuc mac dinh: " + dt0);

            // --- Test Input/Output ---
            DaThuc dt1 = new DaThuc();
            Console.WriteLine("--- Nhap da thuc dt1 ---");
            dt1.Input();
            Console.WriteLine("Da thuc vua nhap: " + dt1);

            // --- Test Copy Constructor ---
            DaThuc dt2 = new DaThuc(dt1);
            Console.WriteLine("Da thuc dt2 (copy tu dt1): " + dt2);

            // --- Test Indexer ---
            Console.WriteLine("--- Test Indexer ---");
            Console.WriteLine("He so bac 0 cua dt1 (a[0]): " + dt1[0]);
            dt1[0] = 99; // Thay đổi hệ số tự do
            Console.WriteLine("Sau khi doi a[0] = 99: " + dt1);

            // --- Test Tính giá trị ---
            Console.Write("Nhap gia tri x de tinh P(x): ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Gia tri cua da thuc tai x = {0} la: {1}", x, dt1.TinhGiaTri(x));
        }
    }
}