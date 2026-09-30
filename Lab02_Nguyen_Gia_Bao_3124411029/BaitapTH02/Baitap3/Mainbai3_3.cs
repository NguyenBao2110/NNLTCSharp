using System;

namespace Baitap1
{
    class Mainbai3_3
    {
        static void Main(string[] args)
        {
            HocSinhDelegate[] arr = new HocSinhDelegate[3];
            arr[0] = new HocSinhDelegate("Nguyen Van A", 7.5);
            arr[1] = new HocSinhDelegate("Tran Thi B", 9.0);
            arr[2] = new HocSinhDelegate("Le Van C", 6.5);

            Console.WriteLine("--- Danh sach truoc khi sap xep ---");
            foreach (HocSinhDelegate hs in arr) hs.Output();

            // Sử dụng Delegate (Lambda Expression) để định nghĩa cách so sánh
            MySortDelegateHelper.MySort(arr, (a, b) => a.DiemTB.CompareTo(b.DiemTB));

            Console.WriteLine("--- Danh sach sau khi sap xep (Delegate) ---");
            foreach (HocSinhDelegate hs in arr) hs.Output();
        }
    }
}