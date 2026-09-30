using System;

namespace BaitapTH02
{
    class Mainbai3
    {
        static void Main(string[] args)
        {
            // --- Test Constructor mặc định ---
            Person p0 = new Person();
            Console.WriteLine("Person mac dinh p0: " + p0); // tự động gọi ToString()

            // --- Test Method Input/Output ---
            Person p1 = new Person();
            Console.WriteLine("--- Nhap thong tin p1 ---");
            p1.Input();
            p1.Output();

            // --- Test Copy Constructor ---
            Person p2 = new Person(p1);
            Console.WriteLine("--- Thong tin p2 (copy tu p1) ---");
            p2.Output();

            // --- Test IsLiving ---
            Console.WriteLine("p1 co song khong? " + p1.IsLiving());
            Console.WriteLine("p2 co song khong? " + p2.IsLiving());

            // --- Test trường hợp đã mất (yod != 0) ---
            Person p3 = new Person();
            p3.Id = "3";
            p3.Name = "Nguyen Van C";
            p3.Yob = 1900;
            p3.Yod = 1980;
            Console.WriteLine("--- Thong tin p3 (da mat) ---");
            p3.Output();
            Console.WriteLine("p3 co song khong? " + p3.IsLiving());
        }
    }
}