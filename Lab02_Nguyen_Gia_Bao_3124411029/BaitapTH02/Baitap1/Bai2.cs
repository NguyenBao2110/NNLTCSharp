using System;


namespace Baitap1
{
    class Point
    {
        private double x,y;

        // Property: X,Y
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        // Default constructor — khởi tạo x, y = 0
        public Point()
        {
            x=0;
            y=0;
        }
        
        //Constructor có tham số
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        
        // Method Input — nhập tọa độ, nên gán qua property X, Y (không gán trực tiếp field)
        public void Input()
        {
            Console.Write("Nhap x: ");
            X= double.Parse(Console.ReadLine()); // gọi set của property X
            Console.Write("Nhap y: ");
            Y= double.Parse(Console.ReadLine()); // gọi set của property Y

        }

        // Method Output — xuất tọa độ
        public void Output()
        {
            Console.WriteLine("Point: ({0}, {1})", X, Y);   // gọi get của property X, Y
        }

        // Override ToString
        public override string ToString()
        {
        return "(" + X + ", " + Y + ")";
        }


        //Phép +
        public static Point operator +(Point a, Point b)
        {
            Point kq = new Point();
            kq.X = a.X + b.X;
            kq.Y = a.Y + b.Y;
            return kq;
        }

        //Phép -
        public static Point operator -(Point a, Point b)
        {
            Point kq = new Point();
            kq.X = a.X - b.X;
            kq.Y = a.Y - b.Y;
            return kq;
        }

        public static Point operator -(Point a)
        {
            Point kq = new Point();
            kq.X = -a.X;
            kq.Y = -a.Y;
            return kq;
        }

        // (a) Phương thức thành viên
        public double TinhKhoangCach(Point b)
        {
            return Math.Sqrt(Math.Pow(this.x - b.x, 2) + Math.Pow(this.y - b.y, 2));
        }

        // (a) Phương thức tĩnh
        public static double TinhKhoangCach(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2));
        }



        // (b) Phương thức thành viên
        public Point TimTrungDiem(Point b)
        {
            double xI = (this.x + b.x) / 2;
            double yI = (this.y + b.y) / 2;
            return new Point(xI, yI);
        }

        // (b) Phương thức tĩnh
        public static Point TimTrungDiem(Point a, Point b)
        { 
            double xI = (a.x + b.x) / 2;
            double yI = (a.y + b.y) / 2;
            return new Point(xI, yI);
        }



    }
}