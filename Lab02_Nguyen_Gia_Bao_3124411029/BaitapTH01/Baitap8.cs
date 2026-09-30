using System;

namespace BaitapTH01
{
    public class Baitap8
    {
        public void Hoanvi(ref double a, ref double b)
        {
            double tam=a;
            a=b;
            b=tam;
        }

        public void Run()
        {
            Baitap8 baitap8=new Baitap8();
            double a,b;
            Console.Write("Nhap so thuc a");
            a= double.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc b");
            b= double.Parse(Console.ReadLine());
            Console.Write("So thuc a={0}, b={1}",a,b);
            baitap8.Hoanvi(ref a, ref b);
            Console.Write("So thuc a va b sau hoan vi: a={0}, b={1}",a,b);
        }
    }
}