using System;

namespace Baitap1
{
    class Mainbai4
    {
        static void Main(string[] args)
        {
            // --- Test Constructor ---
            PhanSo p0 = new PhanSo();
            Console.WriteLine("Phan so mac dinh p0: " + p0);

            // --- Test Input/Output ---
            PhanSo p1 = new PhanSo();
            Console.WriteLine("--- Nhap phan so p1 ---");
            p1.Input();

            PhanSo p2 = new PhanSo();
            Console.WriteLine("--- Nhap phan so p2 ---");
            p2.Input();

            // --- Test Copy Constructor ---
            PhanSo p3 = new PhanSo(p1);
            Console.WriteLine("Phan so p3 (copy tu p1): " + p3);

            // --- Test toan tu ---
            Console.WriteLine("p1 + p2 = " + (p1 + p2));
            Console.WriteLine("p1 - p2 = " + (p1 - p2));
            Console.WriteLine("p1 * p2 = " + (p1 * p2));
            Console.WriteLine("p1 / p2 = " + (p1 / p2));
            Console.WriteLine("-p1 = " + (-p1));

            // --- Test so sanh ---
            Console.WriteLine("p1 > p2? " + (p1 > p2));
            Console.WriteLine("p1 == p2? " + (p1 == p2));
        }
    }
}