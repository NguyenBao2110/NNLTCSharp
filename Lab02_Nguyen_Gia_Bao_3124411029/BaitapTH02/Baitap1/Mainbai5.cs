using System;

namespace Baitap1
{
    class Mainbai5
    {
        static void Main(string[] args)
        {
            // --- Test Constructor ---
            DonThuc d0 = new DonThuc();
            Console.WriteLine("Don thuc mac dinh d0: " + d0);

            // --- Test Input/Output ---
            DonThuc d1 = new DonThuc();
            Console.WriteLine("--- Nhap don thuc d1 ---");
            d1.Input();
            d1.Output();

            // --- Test Copy Constructor ---
            DonThuc d2 = new DonThuc(d1);
            Console.WriteLine("Don thuc d2 (copy tu d1): " + d2);

            // --- Test (a) Tinh gia tri ---
            Console.Write("Nhap gia tri x de tinh P(x): ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Gia tri cua d1 tai x = {0} la: {1}", x, d1.TinhGiaTri(x));

            // --- Test (b) Tinh dao ham ---
            DonThuc daoHam = d1.TinhDaoHam();
            Console.WriteLine("Dao ham cua d1 la: " + daoHam);
            
            // Thử tính giá trị đạo hàm tại x
            Console.WriteLine("Gia tri dao ham tai x = {0} la: {1}", x, daoHam.TinhGiaTri(x));
        }
    }
}