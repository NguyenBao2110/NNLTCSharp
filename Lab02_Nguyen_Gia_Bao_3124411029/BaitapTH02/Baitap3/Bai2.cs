using System;

namespace BaitapTH03
{
    interface IMyComparable
    {
        int SoSanhVoi(object obj);
    }

    class MySortHelper
    {
        public static void MySort<T>(T[] arr) where T : IMyComparable
        {
            for(int i =0; i<arr.Length-1; i++)
            {
                for(int j=0; j<arr.Length-1-i; j++)
                {
                    if (arr[j].SoSanhVoi(arr[j + 1]) > 0)
                    {
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

    }
    
    class HocSinhInterface : IMyComparable
    {
        public string hoten{get;set;}
        public double dtb{get;set;}
        public HocSinhInterface(string ht, double Dtb)
        {
            hoten=ht;
            dtb=Dtb;
        }

        public int SoSanhVoi(object obj)
        {
            HocSinhInterface other = (HocSinhInterface)obj;
            return this.DiemTB.CompareTo(other.DiemTB);
        }

        public void Output()
        {
            Console.WriteLine("Hoc sinh: {0}, Diem TB: {1}", HoTen, DiemTB);
        }

    }

}