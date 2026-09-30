using System;
using System.Text;

namespace BaitapTH01
{
    public class Baitap11
    {
        public string DaoNguocChuoi(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }

            StringBuilder Daonguoc = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Daonguoc.Append(str[i]);
            }
            return Daonguoc.ToString();
        } 

        public void Run()
        {
            Baitap11 baitap11= new Baitap11();
            Console.WriteLine("Nhap chuoi: ");
            string input = Console.ReadLine();
            string Chuoidaonguoc = baitap11.DaoNguocChuoi(input);
            Console.WriteLine("Chuoi dao nguoc: {0}", Chuoidaonguoc);
        }
    }
}