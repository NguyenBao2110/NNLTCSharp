using System;

namespace Baitap1
{
    class Mainbai3_1
    {
        static void Main(string[] args)
        {
            // Khởi tạo mảng học sinh
            HocSinh[] arr = new HocSinh[3];
            arr[0] = new HocSinh("Nguyen Van A", 7.5);
            arr[1] = new HocSinh("Tran Thi B", 9.0);
            arr[2] = new HocSinh("Le Van C", 6.5);

            Console.WriteLine("--- Danh sach truoc khi sap xep ---");
            foreach (HocSinh hs in arr) hs.Output();

            // Sử dụng Array.Sort() có sẵn của C#
            Array.Sort(arr);

            Console.WriteLine("--- Danh sach sau khi sap xep (tang dan theo diem) ---");
            foreach (HocSinh hs in arr) hs.Output();
        }
    }
}