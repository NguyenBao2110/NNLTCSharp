using System;

namespace Baitap1
{
    class Sinhvien
    {
        static void Main(String[] args)
        {
            //Nhập họ va tên sinh viên
            Console.Write("Nhap ho va ten: ");
            string hoten = Console.ReadLine();
            //Nhập năm sinh của sinh viên
            Console.Write("Nhap nam sinh: ");
            int ns= int.Parse(Console.ReadLine());

            //Tính tuổi của sinh viên = năm hiện tại - năm sinh.
            int tuoi= DateTime.Now.Year -ns;

            Console.Write(" Sinh vien {0} co so tuoi la: {1}.",hoten,tuoi);
        }
    }
}