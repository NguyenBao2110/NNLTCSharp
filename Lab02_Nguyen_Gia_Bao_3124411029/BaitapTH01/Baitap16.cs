using System;


namespace BaitapTH01
{
    public class Baitap16
    {
        public static void Nhapmang(ref string[] ten)
        {
            Console.Write("Nhap so luong ten:");
            int n= int.Parse(Console.ReadLine());
            ten= new String[n];
            for(int i=0; i < n; i++)
            {
                Console.Write("Nhap ho ten thu {0}:", i);
                ten[i]= Console.ReadLine();
            }
        }

        public static void Xuatmang(string[] ten)
        {
            Console.WriteLine("Danh sach ho ten vua nhap la:");
            for(int i=0; i < ten.Length; i++)
            {
                Console.WriteLine(ten[i]);
            }
        }

        // Hàm phụ: Tách lấy tên chính (từ cuối cùng) trong chuỗi họ tên
public static string LayTenChinh(string hoTen)
{
    if (string.IsNullOrWhiteSpace(hoTen)) return "";
    string[] tu = hoTen.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    return tu[tu.Length - 1]; // Trả về từ cuối cùng
}

public static void Xapxepmang(string[] ten)
{
    for (int i = 0; i <= ten.Length - 2; i++)
    {
        for (int j = 0; j <= ten.Length - 2 - i; j++)
        {
            // Lấy tên chính của 2 phần tử để so sánh
            string ten1 = LayTenChinh(ten[j]);
            string ten2 = LayTenChinh(ten[j + 1]);

            // Sắp xếp tăng dần theo tên chính
            if (string.Compare(ten1, ten2, StringComparison.OrdinalIgnoreCase) > 0)
            {
                string temp = ten[j];
                ten[j] = ten[j + 1];
                ten[j + 1] = temp;
            }
        }
    }
}


        public void Run()
        {
            string[] a=null;
            Nhapmang(ref a);
            Xuatmang(a);
            Xapxepmang( a);
            Console.WriteLine("Danh sach ho ten sau khi sap xep la:");
            Xuatmang(a);
        }
    }
}