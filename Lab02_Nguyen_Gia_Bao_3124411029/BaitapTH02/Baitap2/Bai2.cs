using System;
using System.Collections;


namespace BaitapTH02
{
    public class PersonList
    {
        private ArrayList list ;


        public PersonList()
        {
            list= new ArrayList();
        }

        public PersonLisst(PersonList other)
        {
         this.list=new ArrayList();
         foreach(Person b in other.list)
            {
                this.list.Add(new Person(p));
            }   
        }


        public void Input()
        {
            Console.Write("Nhap so luong nguoi: ");
            int n= int.Parse(Console.ReadLine());

            for(int i=0; i < n; i++)
            {
                Console.Write("Nhap thong tin nguoi thu {0}: ", i+1);
                Person p= new Person();
                p.Input();
                list.Add(p);
            }
        }


        public void Output()
        {
            Console.WriteLine("Danh sach nguoi:");
            foreach (Person p in list)
            {
                p.Output();
            }
        }

        // Method Add — Thêm một Person vào danh sách
        public void Add(Person x)
        {
            list.Add(x);
        }

        public PersonList LivingPeople()
        {
            PersonList result= new PersonList();
            foreach(Person p in list)
            {
                if (p.IsLiving)
                {
                    result.Add(new Person(p));

                }
            }

            return result;
        }

    }
}