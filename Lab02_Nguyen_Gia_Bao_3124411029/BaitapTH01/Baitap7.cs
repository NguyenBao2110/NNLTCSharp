using System;

namespace BaitapTH01
{
    public class Baitap7
    {
        public bool KTSNT(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
            
        }

        public void Run()
        {
            Baitap7 baitap7=new Baitap7();
            int n;
            Console.WriteLine("Nhap so nguyen n: ");
            n = int.Parse(Console.ReadLine());
            if (baitap7.KTSNT(n))
            {
                Console.WriteLine("{0} la so nguyen to", n);
            }
            else
            {
                Console.WriteLine("{0} khong phai la so nguyen to", n);
            }
        }
    }

}