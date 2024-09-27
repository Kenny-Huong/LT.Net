using System;

class Program
{
    static void Main(string[] args)
    {
        PhanSo ps1 = new PhanSo();
        PhanSo ps2 = new PhanSo();

        Console.WriteLine("Nhap phan so thu nhat:");
        ps1.Nhap();

        Console.WriteLine("Nhap phan so thu hai:");
        ps2.Nhap();

        Console.Write("Tong hai phan so la: ");
        ps1.Cong(ps2).Xuat();
        Console.WriteLine();

        Console.Write("Hieu hai phan so la: ");
        ps1.Tru(ps2).Xuat();
        Console.WriteLine();

        Console.Write("Nhan hai phan so la: ");
        ps1.Nhan(ps2).Xuat();
        Console.WriteLine();

        Console.Write("Chia hai phan so la: ");
        ps1.Chia(ps2).Xuat();
        Console.WriteLine();
    }
}