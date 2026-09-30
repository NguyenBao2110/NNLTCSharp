using System;

namespace BaitapTH01
{
    public class Baitap9
    {
        public void MinMax( double a, double b, double c, out double min, out double max)
        {
            max=a;
            if (max < b)
            {
                max=b;
            }
            if (max < c)
            {
                max=c;
            }

            min=a;
            if (min > b)
            {
                min=b;
            }
            if (min > c)
            {
                min=c;
            }
        }

        public void Run()
        {
            Baitap9 baitap9= new Baitap9();
            double a, b, c, min, max;
            Console.Write("Nhap so thuc a");
            a= double.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc b");
            b= double.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc c");
            c= double.Parse(Console.ReadLine());
            baitap9.MinMax(a,b,c,out min,out max);
            Console.Write("Gia tri lon nhat la {0}, nho nhat la {1}.",max,min);

        }
    }
}