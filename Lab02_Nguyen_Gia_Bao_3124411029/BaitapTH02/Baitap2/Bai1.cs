using System;
using System.Collections; // Bắt buộc để dùng ArrayList

namespace Baitap1
{
    class ArrayPoint
    {
        private ArrayList list;

        // Default Constructor
        public ArrayPoint()
        {
            list = new ArrayList();
        }

        // Indexer cho phép truy cập phần tử thứ i
        public Point this[int index]
        {
            get { return (Point)list[index]; }
            set { list[index] = value; }
        }

        // Thêm một Point vào danh sách
        public void Add(Point p)
        {
            list.Add(p);
        }

        // Xuất danh sách các Point
        public void Output()
        {
            Console.WriteLine("Danh sach cac diem:");
            foreach (Point p in list)
            {
                p.Output(); // Gọi Output của lớp Point
            }
        }
    }
}