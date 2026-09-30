using System;

namespace Baitap1
{
    class PhanSo
    {
        private int tuSo, mauSo;

        // Properties
        public int TuSo
        {
            get { return tuSo; }
            set { tuSo = value; }
        }

        public int MauSo
        {
            get { return mauSo; }
            set { 
                if (value != 0) mauSo = value; 
                else Console.WriteLine("Mau so phai khac 0!"); 
            }
        }

        // Default Constructor
        public PhanSo()
        {
            tuSo = 0;
            mauSo = 1;
        }

        // Constructor có tham số
        public PhanSo(int tu, int mau)
        {
            TuSo = tu;
            MauSo = mau;
        }

        // Copy Constructor
        public PhanSo(PhanSo other)
        {
            this.tuSo = other.tuSo;
            this.mauSo = other.mauSo;
        }

        // Input
        public void Input()
        {
            Console.Write("Nhap tu so: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            MauSo = int.Parse(Console.ReadLine());
        }

        // Output
        public void Output()
        {
            Console.WriteLine("Phan so: {0}/{1}", TuSo, MauSo);
        }

        // Override ToString
        public override string ToString()
        {
            return TuSo + "/" + MauSo;
        }

        // --- Nạp chồng toán tử ---

        // Một ngôi
        public static PhanSo operator +(PhanSo a)
        {
            return new PhanSo(a.TuSo, a.MauSo);
        }

        public static PhanSo operator -(PhanSo a)
        {
            return new PhanSo(-a.TuSo, a.MauSo);
        }

        // Hai ngôi
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.TuSo = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            kq.MauSo = a.MauSo * b.MauSo;
            return kq;
        }

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.TuSo = a.TuSo * b.MauSo - b.TuSo * a.MauSo;
            kq.MauSo = a.MauSo * b.MauSo;
            return kq;
        }

        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.TuSo = a.TuSo * b.TuSo;
            kq.MauSo = a.MauSo * b.MauSo;
            return kq;
        }

        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            if (b.TuSo == 0)
            {
                Console.WriteLine("Khong the chia cho 0!");
                return kq;
            }
            kq.TuSo = a.TuSo * b.MauSo;
            kq.MauSo = a.MauSo * b.TuSo;
            return kq;
        }

        // So sánh
        public static bool operator >(PhanSo a, PhanSo b)
        {
            return a.TuSo * b.MauSo > b.TuSo * a.MauSo;
        }

        public static bool operator <(PhanSo a, PhanSo b)
        {
            return a.TuSo * b.MauSo < b.TuSo * a.MauSo;
        }

        public static bool operator >=(PhanSo a, PhanSo b)
        {
            return a.TuSo * b.MauSo >= b.TuSo * a.MauSo;
        }

        public static bool operator <=(PhanSo a, PhanSo b)
        {
            return a.TuSo * b.MauSo <= b.TuSo * a.MauSo;
        }

        public static bool operator ==(PhanSo a, PhanSo b)
        {
            return a.TuSo * b.MauSo == b.TuSo * a.MauSo;
        }

        public static bool operator !=(PhanSo a, PhanSo b)
        {
            return a.TuSo * b.MauSo != b.TuSo * a.MauSo;
        }
    }
}