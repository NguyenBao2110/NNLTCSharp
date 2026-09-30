using System;

namespace Baitap1
{
    class DaThuc
    {
        private int n;        // Bậc cao nhất
        private double[] a;   // Mảng hệ số a[0] -> a[n]

        // Property cho bậc n
        public int N
        {
            get { return n; }
            set { n = value; }
        }

        // --- a. Các loại Constructor ---

        // Default Constructor (Đa thức bậc 0: P(x) = 0)
        public DaThuc()
        {
            n = 0;
            a = new double[1];
        }

        // Constructor có tham số (truyền vào bậc)
        public DaThuc(int bac)
        {
            n = bac;
            a = new double[n + 1];
        }

        // Copy Constructor
        public DaThuc(DaThuc other)
        {
            this.n = other.n;
            this.a = new double[this.n + 1];
            for (int i = 0; i <= this.n; i++)
            {
                this.a[i] = other.a[i];
            }
        }

        // --- b. Indexer để truy cập đơn thức thứ i (hệ số a_i) ---
        public double this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }

        // --- c. Nhập / Xuất ---

        public void Input()
        {
            Console.Write("Nhap bac cua da thuc n: ");
            n = int.Parse(Console.ReadLine());
            a = new double[n + 1]; // Cấp phát mảng hệ số

            for (int i = 0; i <= n; i++)
            {
                Console.Write("Nhap he so a[" + i + "]: ");
                a[i] = double.Parse(Console.ReadLine());
            }
        }

        public void Output()
        {
            Console.Write("Da thuc: ");
            for (int i = n; i >= 0; i--)
            {
                if (a[i] == 0) continue;

                if (i == 0)
                {
                    Console.Write(a[i]);
                }
                else if (i == 1)
                {
                    Console.Write(a[i] + "x");
                }
                else
                {
                    Console.Write(a[i] + "x^" + i);
                }

                // In dấu + cho các số hạng tiếp theo (nếu có)
                if (i > 0 && a[i-1] != 0) // Kiểm tra thô, có thể cải tiến
                {
                   // Có thể bỏ qua logic dấu + phức tạp, in đơn giản
                }
                
                // Cách đơn giản hơn: In nối chuỗi
            }
            Console.WriteLine();
        }

        // Override ToString để in đẹp hơn
        public override string ToString()
        {
            string s = "";
            for (int i = n; i >= 0; i--)
            {
                if (a[i] == 0) continue;

                if (s != "" && a[i] > 0) s += " + ";
                else if (s != "" && a[i] < 0) s += " - ";

                double heSo = Math.Abs(a[i]);
                
                if (i == 0) s += heSo;
                else if (i == 1) s += (heSo == 1 ? "" : heSo.ToString()) + "x";
                else s += (heSo == 1 ? "" : heSo.ToString()) + "x^" + i;
            }
            if (s == "") s = "0";
            return s;
        }

        // --- d. Tính giá trị của đa thức với giá trị x nhập từ bàn phím ---
        public double TinhGiaTri(double x)
        {
            double ketQua = 0;
            for (int i = 0; i <= n; i++)
            {
                ketQua += a[i] * Math.Pow(x, i);
            }
            return ketQua;
        }
    }
}