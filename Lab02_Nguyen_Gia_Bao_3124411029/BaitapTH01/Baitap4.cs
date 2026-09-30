using System;

namespace BaitapTH01
{
    public class Baitap4
    {
        public void Run()
        {
            int x, y;
            Console.WriteLine("Nhap so nguyen x: ");
            while(!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Vui long nhap mot so nguyen hop le cho x: ");
                Console.WriteLine("Nhap lai so nguyen x: ");
            }
            Console.WriteLine("Nhap so nguyen y: ");
            while(!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Vui long nhap mot so nguyen hop le cho y: ");
                Console.WriteLine("Nhap lai so nguyen y: ");
            }
            int mu=1;
            for(int i = 1; i <= y; i++){
                mu*=x;
            }
            Console.WriteLine("Ket qua {0} mu {1} la {2}", x, y, mu);
        }
    }
}