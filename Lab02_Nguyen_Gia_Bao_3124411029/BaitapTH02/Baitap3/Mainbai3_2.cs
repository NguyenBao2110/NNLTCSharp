using System;

namespace Baitap1
{
    class Mainbai3_2
    {
        static void Main(string[] args)
        {
            HocSinhInterface[] arr = new HocSinhInterface[3];
            arr[0] = new HocSinhInterface("Nguyen Van A", 7.5);
            arr[1] = new HocSinhInterface("Tran Thi B", 9.0);
            arr[2] = new HocSinhInterface("Le Van C", 6.5);

            Console.WriteLine("--- Danh sach truoc khi sap xep ---");
            foreach (HocSinhInterface hs in arr) hs.Output();

            // Gọi hàm sắp xếp tổng quát tự viết
            MySortHelper.MySort(arr);

            Console.WriteLine("--- Danh sach sau khi sap xep (Interface) ---");
            foreach (HocSinhInterface hs in arr) hs.Output();
        }
    }
}