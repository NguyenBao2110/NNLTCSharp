using System;

namespace BaitapTH02
{
    class Person
    {
        private string id;
        private string name;
        private int yob;
        private int yod;

        // Properties
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Yob
        {
            get { return yob; }
            set { yob = value; }
        }

        public int Yod
        {
            get { return yod; }
            set { yod = value; }
        }

        // Default Constructor — khởi tạo giá trị ban đầu
        public Person()
        {
            id = "";
            name = "";
            yob = 0;
            yod = 0;
        }

        // Copy Constructor — sao chép từ đối tượng Person khác
        public Person(Person other)
        {
            this.id = other.id;
            this.name = other.name;
            this.yob = other.yob;
            this.yod = other.yod;
        }

        // Method Input — nhập dữ liệu
        public void Input()
        {
            Console.Write("Nhap id: ");
            Id = Console.ReadLine(); // gọi set của property Id
            Console.Write("Nhap ten: ");
            Name = Console.ReadLine(); // gọi set của property Name
            Console.Write("Nhap nam sinh (yob): ");
            Yob = int.Parse(Console.ReadLine()); // gọi set của property Yob
            Console.Write("Nhap nam mat (yod, nhap 0 neu con song): ");
            Yod = int.Parse(Console.ReadLine()); // gọi set của property Yod
        }

        // Method Output — xuất dữ liệu
        public void Output()
        {
            Console.WriteLine("Person: Id = {0}, Name = {1}, Yob = {2}, Yod = {3}", Id, Name, Yob, Yod);
        }

        // Method IsLiving — kiểm tra còn sống hay đã mất
        public bool IsLiving()
        {
            // Nếu yod bằng 0 thì trả về true (còn sống), khác 0 trả về false (đã mất)
            return Yod == 0;
        }

        // Override ToString (để hỗ trợ in ấn tương tự như Bai2)
        public override string ToString()
        {
            return "(" + Id + ", " + Name + ", " + Yob + ", " + Yod + ")";
        }
    }
}