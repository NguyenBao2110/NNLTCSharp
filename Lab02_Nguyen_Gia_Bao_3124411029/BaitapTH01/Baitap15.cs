using System;
using System.Collections.Generic;

namespace BaitapTH01
{
    public class Baitap15
    {
        public void Nhapdayso(ref int[] day)
        {
            int i, n;
            do
            {
                Console.Write("Moi ban nhap so luong phan tu (1 - 500): ");
                n = int.Parse(Console.ReadLine());
                if (n < 1 || n > 500)
                {
                    Console.WriteLine("So luong phan tu phai tu 1 den 500!");
                }
            } while (n < 1 || n > 500);

            day = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i);
                day[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Xuatdayso(int[] day)
        {
            Console.WriteLine("Day so co {0} phan tu:", day.Length);
            for (int i = 0; i < day.Length; i++)
            {
                Console.Write(day[i] + " ");
            }
            Console.WriteLine();
        }

        public void TimMaxMin(int[] arr, out int max, out int min)
        {
            if (arr == null || arr.Length == 0)
            {
                max = 0; min = 0; return;
            }
            max = arr[0];
            min = arr[0];
            foreach (int item in arr)
            {
                if (item > max) max = item;
                if (item < min) min = item;
            }
        }

        public int[] LayMangNguyenTo(int[] arr)
        {
            List<int> dsNguyenTo = new List<int>();
            foreach (int item in arr)
            {
                if (KiemTraNguyenTo(item))
                {
                    dsNguyenTo.Add(item);
                }
            }
            return dsNguyenTo.ToArray();
        }

        private bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public void Run()
        {
            Baitap15 baitap15 = new Baitap15();
            int[] a = null;
            baitap15.Nhapdayso(ref a);
            baitap15.Xuatdayso(a);

            baitap15.TimMaxMin(a, out int max, out int min);
            Console.WriteLine("Gia tri lon nhat: {0}", max);
            Console.WriteLine("Gia tri nho nhat: {0}", min);

            int[] mangNguyenTo = baitap15.LayMangNguyenTo(a);
            Console.WriteLine("Cac so nguyen to trong day la: ");
            if (mangNguyenTo.Length == 0)
                Console.WriteLine("Khong co so nguyen to nao trong day.");
            else
                baitap15.Xuatdayso(mangNguyenTo);
        }
    }
}