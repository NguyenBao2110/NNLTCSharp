using System;

namespace BaitapTH02
{
    //IComparable là một interface có sẵn trong C# (nằm trong System), dùng để định nghĩa cách so sánh 2 đối tượng cùng kiểu với nhau
    class HoSinh : IComparable
    {
        private string hoten;
        private double dtb;


        public string HOTEN
        {
            get{return hoten;}
            set{hoten=value;}
        }

        public double DTB
        {
            get{return dtb;}
            set{dtb=value;}
        }

        public HocSinh()
        {
            hoten="";
            dtb=0;
        }

        public HocSinh(string ht, double Dtb)
        {
            hoten=ht;
            dtb=Dtb;
        }

        public HocSinh( HocSinh other)
        {
            this.hoten= other.hoten;
            this.dtb= other.dtb;
        }

        public void Input()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap diem trung binh: ");
            DiemTB = double.Parse(Console.ReadLine());
        }

        // Output
        public void Output()
        {
            Console.WriteLine("Hoc sinh: {0}, Diem TB: {1}", HoTen, DiemTB);
        }

        // --- Implement IComparable (Dùng cho Bài 3.1) ---
        public int CompareTo(object obj)
        {
            HocSinh other = (HocSinh)obj;
            // So sánh theo điểm trung bình
            return this.DiemTB.CompareTo(other.DiemTB);
        }

    }
}