using System;

namespace BaitapTH01
{
    public class Baitap6
    {
        public int Max(int x, int y, int z)
        {
            int max=x;
            if (y > max)
            {
                max=y;
            }
            if(z> max)
            {
                max=z;
            }
            return max;
        }

        public void Run()
        {
            Baitap6 baitap6=new Baitap6();
            int x, y, z;
            Console.WriteLine("Nhap so nguye x: ");
            x= int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguye y: ");
            y= int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguye z: ");
            z= int.Parse(Console.ReadLine());
            int max=baitap6.Max(x, y, z);
            Console.WriteLine("So lon nhat trong ba so {0}, {1}, {2} la: {3}.", x, y, z, max);
        }
    }
}