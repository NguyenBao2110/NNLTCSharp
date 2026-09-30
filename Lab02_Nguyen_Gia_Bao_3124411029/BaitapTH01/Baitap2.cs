using System;

namespace BaitapTH01
{
    public class Baitap2
    {
        public void Run()
        {
            Console.WriteLine("Nhap ten cua ban: ");
            string name = Console.ReadLine(); // đọc cả dòng người dùng nhập
            Console.WriteLine("Chao ban {0}!", name); // {0} được thay bằng giá trị của name
        }
    }
}