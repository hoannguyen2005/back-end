using System;
using System.Collections.Generic;
using Baitapvenhautuan2;

class Program
{
    static void Main()
    {
        List<Phanso> danhSach = new List<Phanso>();
        Console.Write("Nhập số lượng phân số: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhập phân số thứ {i + 1}:");
            Phanso ps = new Phanso();
            ps.Nhap();
            danhSach.Add(ps);
        }

        Phanso tong = new Phanso(0, 1);
        foreach (var ps in danhSach)
        {
            tong = Phanso.Cong(tong, ps);
        }

        Console.WriteLine($"\nTổng các phân số là: {tong}");
        Console.ReadLine(); // Dừng màn hình sau khi in kết quả
    }
}
