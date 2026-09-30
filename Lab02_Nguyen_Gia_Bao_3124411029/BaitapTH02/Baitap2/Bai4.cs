using System;

namespace Baitap1
{
    class Mang2Chieu
    {
        private int[,] arr;
        private int n, m;

        // Properties
        public int N
        {
            get { return n; }
            set { n = value; }
        }
        public int M
        {
            get { return m; }
            set { m = value; }
        }

        // --- a. Các loại Constructor ---

        // Default Constructor
        public Mang2Chieu()
        {
            n = 0;
            m = 0;
            arr = new int[0, 0];
        }

        // Constructor có tham số (kích thước)
        public Mang2Chieu(int n, int m)
        {
            this.n = n;
            this.m = m;
            arr = new int[n, m];
        }

        // Copy Constructor (Sao chép sâu)
        public Mang2Chieu(Mang2Chieu other)
        {
            this.n = other.n;
            this.m = other.m;
            this.arr = new int[this.n, this.m];
            for (int i = 0; i < this.n; i++)
            {
                for (int j = 0; j < this.m; j++)
                {
                    this.arr[i, j] = other.arr[i, j];
                }
            }
        }

        // --- b. Indexer ---
        public int this[int i, int j]
        {
            get { return arr[i, j]; }
            set { arr[i, j] = value; }
        }

        // --- c. Nhập / Xuất ---

        public void Input()
        {
            Console.Write("Nhap so dong n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot m: ");
            m = int.Parse(Console.ReadLine());

            arr = new int[n, m]; // Cấp phát mảng

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Nhap phan tu [" + i + "," + j + "]: ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Output()
        {
            Console.WriteLine("Ma tran " + n + "x" + m + ":");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // --- d. Tìm các số nguyên tố trong mảng ---

        // Hàm phụ kiểm tra số nguyên tố
        private bool IsPrime(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }

        public void TimSoNguyenTo()
        {
            Console.Write("Cac so nguyen to trong mang: ");
            bool found = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (IsPrime(arr[i, j]))
                    {
                        Console.Write(arr[i, j] + " ");
                        found = true;
                    }
                }
            }
            if (!found) Console.Write("Khong co so nguyen to nao.");
            Console.WriteLine();
        }
    }
}