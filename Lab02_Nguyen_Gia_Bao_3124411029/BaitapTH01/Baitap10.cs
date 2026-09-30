using System;


namespace BaitapTH01
{
    public class Baitap10
    {
        public bool KiemTraDoiXung(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }

            int left =0;
            int right = str.Length -1;
            while (left < right)
            {
                if(str[left]!= str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }



        public void Run()
        {
            Baitap10 baitap10 = new Baitap10();
            Console.WriteLine("Nhap chuoi: ");
            string input= Console.ReadLine();
            if (baitap10.KiemTraDoiXung(input) == true)
            {
                Console.WriteLine("Chuoi doi xung");
            }
            else
            {
                Console.WriteLine("Chuoi khong doi xung");
            }
        }
    }
}