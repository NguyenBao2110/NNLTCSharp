using System;

namespace BaitapTH02
{
    class Mainbai2_2
    {
        static void Main(string[] args)
        {
            // --- Test Constructor mặc định và Input/Output ---
            PersonList pl1 = new PersonList();
            Console.WriteLine("--- Nhap danh sach nguoi pl1 ---");
            pl1.Input();
            pl1.Output();

            // --- Test Copy Constructor ---
            PersonList pl2 = new PersonList(pl1);
            Console.WriteLine("--- Danh sach pl2 (copy tu pl1) ---");
            pl2.Output();

            // --- Test phương thức LivingPeople ---
            PersonList plLiving = pl1.LivingPeople();
            Console.WriteLine("--- Danh sach nhung nguoi con song ---");
            plLiving.Output();
        }
    }
}