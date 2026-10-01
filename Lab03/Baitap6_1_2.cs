using System;
using System.Collections.Generic;
using System.Linq;


namespace Lab03{

    class Baitap6_1_2
    {
// ================= BÀI 6.1 =================
public class He
{
    public string MaHe { get; set; } = "";
    public string TenHe { get; set; } = "";

    public He(string maHe, string tenHe)
    {
        MaHe = maHe;
        TenHe = tenHe;
    }
}

public class MonHoc
{
    public string MaMon { get; set; } = "";
    public string TenMon { get; set; } = "";
    public string He { get; set; } = "";
    public byte SoTiet { get; set; }

    public MonHoc(string maMon, string tenMon, string he, byte soTiet)
    {
        MaMon = maMon;
        TenMon = tenMon;
        He = he;
        SoTiet = soTiet;
    }
}

public class DuLieu
{
    public static List<He> DS_He()
    {
        return new List<He>
        {
            new He("KTV", "Kỹ thuật viên"),
            new He("CD", "Chuyên đề"),
            new He("QT", "Chứng chỉ quốc tế") // Hệ này chưa có môn học nào
        };
    }

    public static List<MonHoc> DS_Mon()
    {
        List<MonHoc> ds = new List<MonHoc>();
        ds.Add(new MonHoc("HP2_1", "Nền tảng C#", "KTV", 64));
        ds.Add(new MonHoc("HP2_2", "Công nghệ ADO.NET", "KTV", 64));
        ds.Add(new MonHoc("HP3_1", "Lập trình Windows Forms", "KTV", 64));
        ds.Add(new MonHoc("HP3_2", "Xây dựng ứng dụng Windows Forms", "KTV", 64));
        ds.Add(new MonHoc("HP4_1", "Lập trình Web với HTML, CSS và JavaScript", "KTV", 64));
        ds.Add(new MonHoc("HP4_2", "Xây dựng ứng dụng Web với ASP.NET", "KTV", 64));
        ds.Add(new MonHoc("HP5_1", "Lập trình CSDL SQL Server căn bản", "KTV", 64));
        ds.Add(new MonHoc("HP5_2", "Lập trình CSDL SQL Server nâng cao", "KTV", 64));
        ds.Add(new MonHoc("JLCB", "Joomla cơ bản", "CD", 72));
        ds.Add(new MonHoc("LINQ", "Language-Integrated Query", "CD", 64));
        ds.Add(new MonHoc("DAWEB", "Đồ án thực tế Web với ASP.NET", "CD", 40));
        ds.Add(new MonHoc("DAWIN", "Đồ án thực tế Windows Forms", "CD", 40));
        ds.Add(new MonHoc("CC++", "Lập trình hướng đối tượng với C/C++", "CD", 128));
        ds.Add(new MonHoc("JQUE", "JQuery", "CD", 22));
        ds.Add(new MonHoc("XML", "Công nghệ XML", "CD", 32));
        ds.Add(new MonHoc("CRYS", "Crystal Report trong Visual Studio", "CD", 32));
        ds.Add(new MonHoc("BWEB", "HTML, CSS và JavaScript", "CD", 32));
        ds.Add(new MonHoc("XYZ", "Chưa đặt tên môn", "", 0)); // Môn chưa khai báo hệ
        return ds;
    }
}

class Program
{
    static void Main()
    {
        List<He> dsHe = DuLieu.DS_He();
        List<MonHoc> dsMon = DuLieu.DS_Mon();

        Console.WriteLine("========== BÀI 6.2: JOIN VÀ CÁC TOÁN TỬ TẬP HỢP ==========\n");

        // a. Dùng join để liệt kê: Tên hệ, Mã môn, Tên môn.
        var cauA = dsMon.Join(dsHe,
            m => m.He,
            h => h.MaHe,
            (m, h) => new { h.TenHe, m.MaMon, m.TenMon });

        Console.WriteLine("a. Join Tên hệ, Mã môn, Tên môn:");
        foreach (var item in cauA)
            Console.WriteLine($"   {item.TenHe} - {item.MaMon} - {item.TenMon}");


        // b. Liệt kê cả những hệ chưa có môn học (Left Outer Join với GroupJoin + DefaultIfEmpty)
        var cauB = dsHe.GroupJoin(dsMon,
            h => h.MaHe,
            m => m.He,
            (h, monHocs) => new { HeInfo = h, MonHocs = monHocs })
            .SelectMany(
                x => x.MonHocs.DefaultIfEmpty(),
                (x, m) => new { x.HeInfo.TenHe, MaMon = m?.MaMon ?? "Chưa có" });

        Console.WriteLine("\nb. Các hệ (kể cả hệ chưa có môn):");
        foreach (var item in cauB)
            Console.WriteLine($"   {item.TenHe} - {item.MaMon}");


        // c. Liệt kê cả hệ chưa có môn học và môn học chưa khai báo hệ (Full Outer Join)
        Console.WriteLine("\nc. Hệ chưa có môn VÀ Môn chưa khai báo hệ:");
        // Lấy hệ chưa có môn
        var heChuaCoMon = dsHe.Where(h => !dsMon.Any(m => m.He == h.MaHe));
        foreach (var h in heChuaCoMon)
            Console.WriteLine($"   Hệ chưa có môn: {h.MaHe} - {h.TenHe}");

        // Lấy môn chưa khai báo hệ
        var monChuaCoHe = dsMon.Where(m => string.IsNullOrEmpty(m.He) || !dsHe.Any(h => h.MaHe == m.He));
        foreach (var m in monChuaCoHe)
            Console.WriteLine($"   Môn chưa khai báo hệ: {m.MaMon} - {m.TenMon}");


        // d. Chỉ liệt kê những hệ chưa có môn học VÀ những môn học chưa khai báo hệ.
        Console.WriteLine("\nd. Chỉ liệt kê hệ chưa có môn VÀ môn chưa khai báo hệ:");
        var cauD_He = dsHe.Where(h => !dsMon.Any(m => m.He == h.MaHe)).Select(h => $"Hệ: {h.TenHe}");
        var cauD_Mon = dsMon.Where(m => string.IsNullOrEmpty(m.He)).Select(m => $"Môn: {m.TenMon}");
        var cauD = cauD_He.Concat(cauD_Mon);
        foreach (var item in cauD)
            Console.WriteLine($"   {item}");


        // e. Lấy 5 môn học đầu tiên có số tiết giảm dần; hiển thị Tên hệ, Mã môn, Tên môn, Số tiết.
        var cauE = dsMon.Join(dsHe, m => m.He, h => h.MaHe, (m, h) => new { h.TenHe, m.MaMon, m.TenMon, m.SoTiet })
                        .OrderByDescending(x => x.SoTiet)
                        .Take(5);

        Console.WriteLine("\ne. 5 môn học có số tiết giảm dần:");
        foreach (var item in cauE)
            Console.WriteLine($"   {item.TenHe} - {item.MaMon} - {item.TenMon} ({item.SoTiet} tiết)");


        // f. Cho biết tổng số môn học của mỗi hệ: Mã hệ, Tên hệ, Tổng số môn.
        var cauF = dsHe.GroupJoin(dsMon,
            h => h.MaHe,
            m => m.He,
            (h, monHocs) => new { h.MaHe, h.TenHe, TongSoMon = monHocs.Count() });

        Console.WriteLine("\nf. Tổng số môn học của mỗi hệ:");
        foreach (var item in cauF)
            Console.WriteLine($"   {item.MaHe} - {item.TenHe}: {item.TongSoMon} môn");


        // g. Cho biết có bao nhiêu loại Số tiết khác nhau trong danh sách môn học.
        int soLoaiSoTiet = dsMon.Select(m => m.SoTiet).Distinct().Count();
        Console.WriteLine($"\ng. Số loại Số tiết khác nhau: {soLoaiSoTiet}");


        // h. Tìm môn học đầu tiên có tên bắt đầu bằng “Lập trình”.
        var cauH = dsMon.FirstOrDefault(m => m.TenMon.StartsWith("Lập trình"));
        Console.WriteLine("\nh. Môn học đầu tiên bắt đầu bằng 'Lập trình':");
        if (cauH != null)
            Console.WriteLine($"   {cauH.MaMon} - {cauH.TenMon}");
        else
            Console.WriteLine("   Không tìm thấy môn nào.");


        // i. Liệt kê các môn theo từng hệ, đánh số thứ tự trong mỗi nhóm.
        Console.WriteLine("\ni. Liệt kê các môn theo từng hệ (có đánh số thứ tự):");
        var cauI = dsMon.GroupBy(m => m.He);
        foreach (var nhom in cauI)
        {
            string tenHe = string.IsNullOrEmpty(nhom.Key) ? "Chưa khai báo" : nhom.Key;
            Console.WriteLine($"   Hệ '{tenHe}':");
            int stt = 1;
            foreach (var m in nhom)
            {
                Console.WriteLine($"      {stt}. {m.MaMon} - {m.TenMon}");
                stt++;
            }
        }
    }
}

}
}