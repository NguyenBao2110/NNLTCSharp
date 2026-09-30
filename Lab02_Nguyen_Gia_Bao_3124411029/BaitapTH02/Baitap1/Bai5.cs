using System;

namespace Baitap1
{
    class DonThuc
    {
        private double a;
        private int n;

        // Properties
        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public int N
        {
            get { return n; }
            set { 
                if (value >= 0) n = value; 
                else Console.WriteLine("So mu phai >= 0!"); 
            }
        }

        // Default Constructor
        public DonThuc()
        {
            a = 0;
            n = 0;
        }

        // Constructor có tham số
        public DonThuc(double a, int n)
        {
            A = a;
            N = n;
        }

        // Copy Constructor
        public DonThuc(DonThuc other)
        {
            this.a = other.a;
            this.n = other.n;
        }

        // Input
        public void Input()
        {
            Console.Write("Nhap he so a: ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Nhap so mu n: ");
            N = int.Parse(Console.ReadLine());
        }

        // Output
        public void Output()
        {
            Console.WriteLine("Don thuc: {0}x^{1}", A, N);
        }

        // Override ToString
        public override string ToString()
        {
            return A + "x^" + N;
        }

        // (a) Tính giá trị đơn thức P(x) = a * x^n
        public double TinhGiaTri(double x)
        {
            return A * Math.Pow(x, N);
        }

        // (b) Đạo hàm P'(x) = a * n * x^(n-1)
        public DonThuc TinhDaoHam()
        {
            if (N == 0)
            {
                // Đạo hàm của hằng số là 0
                return new DonThuc(0, 0);
            }
            return new DonThuc(A * N, N - 1);
        }
    }
}