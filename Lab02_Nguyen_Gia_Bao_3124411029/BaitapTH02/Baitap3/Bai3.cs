using System;

namespace Baitap1
{
    // Định nghĩa Delegate so sánh
    public delegate int SoSanhDelegate<T>(T a, T b);

    class MySortDelegateHelper
    {
        // Hàm sắp xếp tổng quát sử dụng Delegate
        public static void MySort<T>(T[] arr, SoSanhDelegate<T> cmp)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    // Sử dụng delegate để so sánh
                    if (cmp(arr[j], arr[j + 1]) > 0)
                    {
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }

    // Lớp HocSinh đơn giản (không cần implement interface)
    class HocSinhDelegate
    {
        public string HoTen { get; set; }
        public double DiemTB { get; set; }

        public HocSinhDelegate(string ht, double d)
        {
            HoTen = ht;
            DiemTB = d;
        }

        public void Output()
        {
            Console.WriteLine("Hoc sinh: {0}, Diem TB: {1}", HoTen, DiemTB);
        }
    }
}