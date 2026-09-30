using System;

namespace Baitap1
{
    class DayPhanSo
    {
        private PhanSo[] arr;
        private int n;

        // Property
        public int N
        {
            get { return n; }
            set { n = value; }
        }

        // --- Các loại Constructor ---

        // Default Constructor
        public DayPhanSo()
        {
            n = 0;
            arr = new PhanSo[0];
        }

        // Constructor có tham số (kích thước)
        public DayPhanSo(int size)
        {
            n = size;
            arr = new PhanSo[n];
        }

        // Copy Constructor (Sao chép sâu)
        public DayPhanSo(DayPhanSo other)
        {
            this.n = other.n;
            this.arr = new PhanSo[this.n];
            for (int i = 0; i < this.n; i++)
            {
                // Sử dụng Copy Constructor của lớp PhanSo
                this.arr[i] = new PhanSo(other.arr[i]);
            }
        }

        // --- Indexer ---
        public PhanSo this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }

        // --- Nhập / Xuất ---

        public void Input()
        {
            Console.Write("Nhap so luong phan so: ");
            n = int.Parse(Console.ReadLine());
            arr = new PhanSo[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("--- Nhap phan so thu " + (i + 1) + " ---");
                arr[i] = new PhanSo();
                arr[i].Input();
            }
        }

        public void Output()
        {
            Console.WriteLine("Danh sach phan so:");
            for (int i = 0; i < n; i++)
            {
                arr[i].Output();
            }
        }

        // Override ToString
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < n; i++)
            {
                s += arr[i].ToString() + "  ";
            }
            return s;
        }

        // --- Tính tổng của n phân số ---
        public PhanSo TinhTong()
        {
            // Khởi tạo phân số 0/1
            PhanSo tong = new PhanSo(0, 1);
            
            for (int i = 0; i < n; i++)
            {
                // Sử dụng toán tử + đã nạp chồng của lớp PhanSo
                tong = tong + arr[i];
            }
            return tong;
        }
    }
}