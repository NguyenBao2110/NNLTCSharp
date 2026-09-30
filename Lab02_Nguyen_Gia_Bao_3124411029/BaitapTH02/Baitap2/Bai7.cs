using System;
using System.Reflection.Metadata.Ecma335;

namespace BaitapTH02
{
    public class NhanVien
    {
        private string ten;
        private double luong;
        private int songaynghi;

        public string TEN
        {
            get{return ten;}
            set{ten=value;}
        }

        public double LUONG
        {
            get{return luong;}
            set{luong=value;}
        }

        public int SONGAYNGHI
        {
            get{return songaynghi;}
            set{songaynghi=value;}
        }

        public NhanVien()
        {
            ten="";
            luong=0;
            songaynghi=0;
        }


        public NhanVien(string t, double l, int snn)
        {
            ten=t;
            luong=l;
            songaynghi=snn;
        }


        public NhanVien(NhanVien other)
        {
            this.ten=other.ten;
            this.luong=other.ten;
            this.songaynghi=other.songaynghi;
        }

        // Input
        public void Input()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap muc luong: ");
            Luong = double.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay vang: ");
            SoNgayVang = int.Parse(Console.ReadLine());
        }

        // Output
        public void Output()
        {
            Console.WriteLine("Nhan vien: {0}, Luong: {1}, Ngay vang: {2}, Thuc linh: {3}", 
                HoTen, Luong, SoNgayVang, TinhLuongThucLinh());
        }

        // Override ToString
        public override string ToString()
        {
            return "(" + HoTen + ", " + Luong + ", " + SoNgayVang + ")";
        }

        // Tính lương thực lĩnh (trừ 100.000 VNĐ mỗi ngày vắng)
        public double TinhLuongThucLinh()
        {
            return Luong - SoNgayVang * 100000;
        }

    }


    class PhongBan
    {
        private NhanVien[] arr;
        private int n;


        public int N
        {
            get{return n;}
            set{n=value;}
        }

        public PhongBan()
        {
            n=0;
            arr= new Array[0];
        }

        public PhongBan(int size)
        {
            n=size;
            arr= new Array[n];
        }

        public PhongBan(PhongBan other)
        {
            this.n=other.n;
            this.arr= new NhanVien[this.n];

        for(int i = 1; i < this.n; i++)
            {
                this.arr[i]= new NhanVien[other.arr[i]];
            } 
        }

        public NhanVien this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }

        // Input
        public void Input()
        {
            Console.Write("Nhap so luong nhan vien: ");
            n = int.Parse(Console.ReadLine());
            arr = new NhanVien[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("--- Nhap thong tin nhan vien thu " + (i + 1) + " ---");
                arr[i] = new NhanVien();
                arr[i].Input();
            }
        }

        // Output
        public void Output()
        {
            Console.WriteLine("Danh sach nhan vien:");
            for (int i = 0; i < n; i++)
            {
                arr[i].Output();
            }
        }

        // Tính tổng lương của phòng ban
        public double TinhTongLuong()
        {
            double tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += arr[i].TinhLuongThucLinh();
            }
            return tong;
        }


    }
}