using System;

namespace BaitapTH02
{
    public class Dayso
    {
        private int[] arr;
        private int n;

        public int N
        {
            get{return n;}
            set{n=value;}
        }

        public Dayso()
        {
            n=0;
            arr = new int[0];
        }

        public Dayso(int size)
        {
            n=size;
            arr= new int[n];
        }


        public Dayso(Dayso other)
        {
            this.n=other.n;
            this.arr= new int[this.n];
            for(int i=0; i < this.n; i++)
            {
                this.arr[i]=other.arr[i];
            }
        }

        public int this[int indexer]
        {
            get{return ar[indexer];}
            set{arr[indexer]=value;}
        }


        public void Input()
        {
            Console.Write("Nhap so luong phan tu: ");
            int n= int.Parse(Console.ReadLine());
            arr= new int[n];
            for(int i=0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ",i+1);
                arr[i]= int.Parse(Console.ReadLine());
            }
        }

        public void Output()
        {
            Console.Write("Day so: ");
            for(int i=0; i < n; i++)
            {
                Console.Write(arr[i]+" ");

            }
            Console.Write();
        }


        public override string ToString()
        {
            string s="";
            for(int i=0; i<n; i++)
            {
                s+= arr[i] +"";

            }
            return s;
        }


        public Dayso Timchan()
        {
            Dayso result= new Dayso();
            int count =0;
            for(int i=0; i<n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count++;
                }
            }
            
            result.n=count;
            result.arr= new int[count];

            int index=0;
            for(int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    result.arr[index]=arr[i];
                    index++;
                }
            }
            return result;
        }

    }
}