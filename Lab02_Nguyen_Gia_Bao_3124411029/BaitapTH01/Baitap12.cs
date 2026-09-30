using System;

namespace BaitapTH01
{
    public class Baitap12
    {
        public void Xulychuoi(string str)
        {
            string Chuthuong = str.ToUpper();
            Console.WriteLine("Chu thuong: {0}", Chuthuong);

            string Chuhoa = str.ToLower();
            Console.WriteLine("Chu hoa: {0}", Chuhoa);

            string[] tu=str.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Cac tu trong chuoi:" + tu.Length);
        }

        public void Run()
        {
            Baitap12 baitap12= new Baitap12();
            Console.WriteLine("Nhap chuoi: ");
            string input = Console.ReadLine();
            baitap12.Xulychuoi(input);
        }
    }
}