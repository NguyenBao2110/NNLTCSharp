using System;

namespace Baitap1
{
    // --- Lớp giải phương trình bậc 2 ---
    class PTBac2
    {
        private double a, b, c;

        // Properties
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }

        // Default Constructor
        public PTBac2()
        {
            a = 0; b = 0; c = 0;
        }

        // Constructor có tham số
        public PTBac2(double a, double b, double c)
        {
            this.a = a; this.b = b; this.c = c;
        }

        // Copy Constructor
        public PTBac2(PTBac2 other)
        {
            this.a = other.a;
            this.b = other.b;
            this.c = other.c;
        }

        // Input
        public void Input()
        {
            Console.Write("Nhap a: ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            B = double.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            C = double.Parse(Console.ReadLine());
        }

        // Phương thức giải phương trình
        public string Giai()
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    return (c == 0) ? "Phuong trinh vo so nghiem" : "Phuong trinh vo nghiem";
                }
                return "Phuong trinh co 1 nghiem: x = " + (-c / b);
            }

            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                return "Phuong trinh vo nghiem";
            }
            else if (delta == 0)
            {
                return "Phuong trinh co nghiem kep: x1 = x2 = " + (-b / (2 * a));
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return "Phuong trinh co 2 nghiem phan biet: x1 = " + x1 + ", x2 = " + x2;
            }
        }

        // Override ToString
        public override string ToString()
        {
            return "(" + a + ")x^2 + (" + b + ")x + (" + c + ") = 0";
        }
    }

    // --- Lớp ConsoleMenu tổng quát ---
    class ConsoleMenu
    {
        // Định nghĩa Delegate cho sự kiện chọn chức năng
        public delegate void ChooseEventHandler(int choice);
        
        // Định nghĩa Event
        public event ChooseEventHandler Choose;

        // Phương thức hiển thị menu và kích hoạt sự kiện
        public void Show()
        {
            while (true)
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1. Chuc nang 1 (Giai PT bac 2)");
                Console.WriteLine("2. Chuc nang 2 (Xuat thong tin)");
                Console.WriteLine("0. Thoat chuong trinh");
                Console.Write("Thuc hien: ");

                int choice = int.Parse(Console.ReadLine());
                
                // Kích hoạt sự kiện nếu có người đăng ký
                Choose?.Invoke(choice);

                if (choice == 0) break;
            }
        }
    }

    // --- Lớp PTBac2Console kế thừa ConsoleMenu ---
    class PTBac2Console : ConsoleMenu
    {
        private PTBac2 pt;

        // Constructor: Đăng ký sự kiện
        public PTBac2Console()
        {
            pt = new PTBac2();
            // Đăng ký phương thức xử lý sự kiện
            this.Choose += XuLyChon;
        }

        // Phương thức xử lý khi người dùng chọn chức năng
        private void XuLyChon(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("--- Giai phuong trinh bac 2 ---");
                    pt.Input();
                    Console.WriteLine("Ket qua: " + pt.Giai());
                    break;
                case 2:
                    Console.WriteLine("--- Thong tin phuong trinh da nhap ---");
                    Console.WriteLine("Phuong trinh: " + pt.ToString());
                    break;
                case 0:
                    Console.WriteLine("Tam biet!");
                    break;
                default:
                    Console.WriteLine("Chuc nang khong hop le!");
                    break;
            }
        }
    }
}