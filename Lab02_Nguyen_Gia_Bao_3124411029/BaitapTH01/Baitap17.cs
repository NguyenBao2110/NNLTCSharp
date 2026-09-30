using System;
using System.Collections.Generic;

namespace BaitapTH01
{
    public class Baitap17
    {
        public static void Nhapdayso(ref int[,] day)
        {
            int n, m;
            Console.Write("Moi ban nhap n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap m: ");
            m = int.Parse(Console.ReadLine());


            Random rd = new Random();
            day = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    day[i, j] = rd.Next(10, 101);
                }
            }
        }
        public static void Xuatmang(int[] day)
    {
        Console.WriteLine("Day so co {0} phan tu:", day.Length);

        for (int i = 0; i < day.Length; i++)
        {
            Console.Write(day[i] + " ");
        }

        Console.WriteLine();
    }
        public static void TachChanLe(int[,] day, out int[] mangChan, out int[] mangLe)
        {
            List<int> dsChan= new List<int>();
            List<int> dsLe= new List<int>();

            int n=day.GetLength(0);
            int m=day.GetLength(1);
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if (day[i, j] % 2 == 0)
                    {
                        dsChan.Add(day[i,j]);
                    }
                    else
                    {
                        dsLe.Add(day[i,j]);
                    }
                }
            }

            mangChan = dsChan.ToArray();
            mangLe = dsLe.ToArray();
        }

        public void Run()
        {
            int[,] a = null;
            Nhapdayso(ref a);

            int[] chan, le;
            TachChanLe(a, out chan, out le);

            Console.WriteLine("Mang cac so chan:");
            Xuatmang(chan); 

            Console.WriteLine("Mang cac so le:");
            Xuatmang(le);
        }

    }
}