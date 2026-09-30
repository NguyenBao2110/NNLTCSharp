using System;

namespace BaitapTH01
{
    public class Baitap05
    {
        static void Nhapsothuc(ref double x,ref double y)
        {
            Console.WriteLine("Nhap so thuc x: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thuc y: ");
            y = double.Parse(Console.ReadLine());
        }

        static void xmuy(double x, double y)
        {
            double mu = Math.Pow(x, y);
            Console.WriteLine("Ket qua {0} mu {1} la {2}", x, y, mu);
        }

         static void Canbachai(double x, double y)
        {

            if(x<0|| y < 0)
            {
                Console.WriteLine("Khong tinh duoc can bac hai cua so am!");
                return;
            }
            Console.WriteLine("Ket qua can bac hai cua x={0} la {1} ", x,Math.Sqrt(x));
            Console.WriteLine("Ket qua can bac hai cua y={0} la {1}", y,Math.Sqrt(y));
        }

        public void Run()
        {
            double x=0, y=0;
            int luachon;
            bool thoat = false;
            while (!thoat)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Nhap hai so thuc cho x va y");
                Console.WriteLine("2. Tinh x^y");
                Console.WriteLine("3. Tinh can bac hai cua x va y");
                Console.WriteLine("4. Thoat");
                Console.WriteLine("Chon chuc nang: ");
                luachon= int.Parse(Console.ReadLine());

                switch (luachon)
                {
                    case 1:
                        Nhapsothuc(ref x , ref y);
                        break;
                    case 2:
                        xmuy(x, y);
                        break;
                    case 3:
                        Canbachai(x, y);
                        break;
                    case 4:
                        thoat = true;
                        Console.WriteLine("Ban da thoat chuong trinh.");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le, vui long chon lai.");
                        break;
                }
            }

        }
    }
}