using System;

namespace Baitap1
{
    // --- Lớp cha: NhanVien ---
    class NhanVien
    {
        protected string maNV;
        protected string hoTen;
        protected double luongCoBan;

        // Properties
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public double LuongCoBan
        {
            get { return luongCoBan; }
            set { luongCoBan = value; }
        }

        // Default Constructor
        public NhanVien()
        {
            maNV = "";
            hoTen = "";
            luongCoBan = 0;
        }

        // Constructor có tham số
        public NhanVien(string ma, string ten, double luong)
        {
            MaNV = ma;
            HoTen = ten;
            LuongCoBan = luong;
        }

        // Copy Constructor
        public NhanVien(NhanVien other)
        {
            this.maNV = other.maNV;
            this.hoTen = other.hoTen;
            this.luongCoBan = other.luongCoBan;
        }

        // Input
        public virtual void Input()
        {
            Console.Write("Nhap ma nhan vien: ");
            MaNV = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap luong co ban: ");
            LuongCoBan = double.Parse(Console.ReadLine());
        }

        // Output
        public virtual void Output()
        {
            Console.WriteLine("Ma NV: {0}, Ho ten: {1}, Luong co ban: {2}", MaNV, HoTen, LuongCoBan);
        }

        // Override ToString
        public override string ToString()
        {
            return "(" + MaNV + ", " + HoTen + ", " + LuongCoBan + ")";
        }

        // Phương thức ảo tính lương
        public virtual double TinhLuong()
        {
            return LuongCoBan;
        }
    }

    // --- Lớp con: NhanVienKinhDoanh ---
    class NhanVienKinhDoanh : NhanVien
    {
        private int soHopDong;

        public int SoHopDong
        {
            get { return soHopDong; }
            set { soHopDong = value; }
        }

        public NhanVienKinhDoanh() : base()
        {
            soHopDong = 0;
        }

        public NhanVienKinhDoanh(string ma, string ten, double luong, int shd) : base(ma, ten, luong)
        {
            SoHopDong = shd;
        }

        public NhanVienKinhDoanh(NhanVienKinhDoanh other) : base(other)
        {
            this.soHopDong = other.soHopDong;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap so hop dong: ");
            SoHopDong = int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("So hop dong: {0}, Tong luong: {1}", SoHopDong, TinhLuong());
        }

        public override string ToString()
        {
            return base.ToString() + " - Kinh doanh";
        }

        public override double TinhLuong()
        {
            return LuongCoBan + SoHopDong * 500000;
        }
    }

    // --- Lớp con: NhanVienSanXuat ---
    class NhanVienSanXuat : NhanVien
    {
        private int soSanPham;

        public int SoSanPham
        {
            get { return soSanPham; }
            set { soSanPham = value; }
        }

        public NhanVienSanXuat() : base()
        {
            soSanPham = 0;
        }

        public NhanVienSanXuat(string ma, string ten, double luong, int ssp) : base(ma, ten, luong)
        {
            SoSanPham = ssp;
        }

        public NhanVienSanXuat(NhanVienSanXuat other) : base(other)
        {
            this.soSanPham = other.soSanPham;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap so san pham: ");
            SoSanPham = int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("So san pham: {0}, Tong luong: {1}", SoSanPham, TinhLuong());
        }

        public override string ToString()
        {
            return base.ToString() + " - San xuat";
        }

        public override double TinhLuong()
        {
            double luong = SoSanPham * 1000;
            if (SoSanPham > 3000)
            {
                luong += luong * 0.05; // Thưởng thêm 5%
            }
            return luong;
        }
    }
}