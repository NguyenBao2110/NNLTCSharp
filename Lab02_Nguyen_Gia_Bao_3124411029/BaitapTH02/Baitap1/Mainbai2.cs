using System;

namespace Baitap1
{
    class Mainbai2
    {
        static void Main(string[] args)
        {
            // --- Test Constructor mặc định ---
            Point p0 = new Point();
            Console.WriteLine("Diem mac dinh p0: " + p0);   // tự động gọi ToString()

            // --- Test Method Input/Output ---
            Point p1 = new Point();
            Console.WriteLine("--- Nhap toa do p1 ---");
            p1.Input();
            p1.Output();

            Point p2 = new Point();
            Console.WriteLine("--- Nhap toa do p2 ---");
            p2.Input();
            p2.Output();

            // --- Test toan tu + - lay am ---
            Point tong = p1 + p2;
            Point hieu = p1 - p2;
            Point am = -p1;

            Console.WriteLine("p1 + p2 = " + tong);
            Console.WriteLine("p1 - p2 = " + hieu);
            Console.WriteLine("-p1 = " + am);

            // --- Test TinhKhoangCach: phuong thuc THANH VIEN vs TINH ---
            double kc1 = p1.TinhKhoangCach(p2);        // goi qua doi tuong p1
            double kc2 = Point.TinhKhoangCach(p1, p2); // goi qua ten class Point

            Console.WriteLine("Khoang cach (thanh vien): " + kc1);
            Console.WriteLine("Khoang cach (tinh): " + kc2);

            // --- Test TimTrungDiem: phuong thuc THANH VIEN vs TINH ---
            Point td1 = p1.TimTrungDiem(p2);         // goi qua doi tuong p1
            Point td2 = Point.TimTrungDiem(p1, p2);  // goi qua ten class Point

            Console.WriteLine("Trung diem (thanh vien): " + td1);
            Console.WriteLine("Trung diem (tinh): " + td2);
        }
    }
}