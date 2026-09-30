using System;

namespace BaitapTH01
{
    public class Baitap3
    {
        public void Run()
        {
            int x, y;
            Console.WriteLine("Nhap so nguyen x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen y: ");
            y = int.Parse(Console.ReadLine());
            int mu=1;
            for(int i = 1; i <= y; i++){
                mu*=x;
            }
            Console.WriteLine("Ket qua {0} mu {1} la {2}", x, y, mu);
        }
    }
}