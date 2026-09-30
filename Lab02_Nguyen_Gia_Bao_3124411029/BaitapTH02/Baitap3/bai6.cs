using System;

namespace Baitap1
{
    // --- Lớp cha: ThiSinh ---
    class ThiSinh
    {
        protected string sbd;
        protected string hoTen;
        protected double bai1, bai2, bai3;

        // Properties
        public string SBD { get { return sbd; } set { sbd = value; } }
        public string HoTen { get { return hoTen; } set { hoTen = value; } }
        public double Bai1 { get { return bai1; } set { bai1 = value; } }
        public double Bai2 { get { return bai2; } set { bai2 = value; } }
        public double Bai3 { get { return bai3; } set { bai3 = value; } }

        // Default Constructor
        public ThiSinh()
        {
            sbd = "";
            hoTen = "";
            bai1 = bai2 = bai3 = 0;
        }

        // Constructor có tham số
        public ThiSinh(string sbd, string ten, double b1, double b2, double b3)
        {
            SBD = sbd;
            HoTen = ten;
            Bai1 = b1;
            Bai2 = b2;
            Bai3 = b3;
        }

        // Copy Constructor
        public ThiSinh(ThiSinh other)
        {
            this.sbd = other.sbd;
            this.hoTen = other.hoTen;
            this.bai1 = other.bai1;
            this.bai2 = other.bai2;
            this.bai3 = other.bai3;
        }

        // Input
        public virtual void Input()
        {
            Console.Write("Nhap SBD: ");
            SBD = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap diem bai 1: ");
            Bai1 = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem bai 2: ");
            Bai2 = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem bai 3: ");
            Bai3 = double.Parse(Console.ReadLine());
        }

        // Output
        public virtual void Output()
        {
            Console.WriteLine("SBD: {0}, Ho ten: {1}, Bai 1: {2}, Bai 2: {3}, Bai 3: {4}", SBD, HoTen, Bai1, Bai2, Bai3);
        }

        public override string ToString()
        {
            return "(" + SBD + ", " + HoTen + ")";
        }

        // Phương thức ảo tính tổng điểm
        public virtual double TinhTongDiem()
        {
            return Bai1 + Bai2 + Bai3;
        }
    }

    // --- Lớp con: ThiSinhChuyen ---
    class ThiSinhChuyen : ThiSinh
    {
        private double tiengAnh;

        public double TiengAnh { get { return tiengAnh; } set { tiengAnh = value; } }

        public ThiSinhChuyen() : base()
        {
            tiengAnh = 0;
        }

        public ThiSinhChuyen(string sbd, string ten, double b1, double b2, double b3, double ta) 
            : base(sbd, ten, b1, b2, b3)
        {
            TiengAnh = ta;
        }

        public ThiSinhChuyen(ThiSinhChuyen other) : base(other)
        {
            this.tiengAnh = other.tiengAnh;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap diem Tieng Anh: ");
            TiengAnh = double.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Diem Tieng Anh: {0}, Tong diem: {1}", TiengAnh, TinhTongDiem());
        }

        public override double TinhTongDiem()
        {
            double tong = base.TinhTongDiem() + TiengAnh;
            
            // Cộng điểm thưởng dựa trên điểm Tiếng Anh
            if (TiengAnh >= 7 && TiengAnh < 8)
            {
                tong += 1;
            }
            else if (TiengAnh >= 9 && TiengAnh <= 10)
            {
                tong += 2;
            }
            return tong;
        }
    }

    // --- Lớp con: ThiSinhSieuCup ---
    class ThiSinhSieuCup : ThiSinh
    {
        private double csdl;

        public double CSDL { get { return csdl; } set { csdl = value; } }

        public ThiSinhSieuCup() : base()
        {
            csdl = 0;
        }

        public ThiSinhSieuCup(string sbd, string ten, double b1, double b2, double b3, double csdl) 
            : base(sbd, ten, b1, b2, b3)
        {
            CSDL = csdl;
        }

        public ThiSinhSieuCup(ThiSinhSieuCup other) : base(other)
        {
            this.csdl = other.csdl;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap diem CSDL: ");
            CSDL = double.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Diem CSDL: {0}, Tong diem: {1}", CSDL, TinhTongDiem());
        }

        public override double TinhTongDiem()
        {
            // Tổng điểm của 4 bài thi (3 bài bắt buộc + CSDL)
            return base.TinhTongDiem() + CSDL;
        }
    }
}