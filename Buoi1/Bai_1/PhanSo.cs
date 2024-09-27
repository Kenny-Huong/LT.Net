using System;

class PhanSo
{
    public int tuSo { get; set; }
    public int mauSo { get; set; }

    // Hàm khởi tạo không tham số
    public PhanSo()
    {
        tuSo = 0;
        mauSo = 1;
    }

    // Hàm nhập phân số
    public void Nhap()
    {
        Console.Write("Nhap tu so: ");
        tuSo = int.Parse(Console.ReadLine());
        do
        {
            Console.Write("Nhap mau so (khac 0): ");
            mauSo = int.Parse(Console.ReadLine());
        } while (mauSo == 0);
    }

    // Hàm xuất phân số
    public void Xuat()
    {
        Console.Write($"{tuSo}/{mauSo}");
    }

    // Hàm rút gọn phân số
    private void RutGon()
    {
        int ucln = UCLN(tuSo, mauSo);
        tuSo /= ucln;
        mauSo /= ucln;
    }

    // Hàm tính ước chung lớn nhất (UCLN)
    private int UCLN(int a, int b)
    {
        while (b != 0)
        {
            int temp = a % b;
            a = b;
            b = temp;
        }
        return a;
    }

    // Các phép toán với phân số
    public PhanSo Cong(PhanSo ps)
    {
        PhanSo ketQua = new PhanSo();
        ketQua.tuSo = tuSo * ps.mauSo + ps.tuSo * mauSo;
        ketQua.mauSo = mauSo * ps.mauSo;
        ketQua.RutGon();
        return ketQua;
    }

    // Tương tự cho các phép trừ, nhân, chia
    public PhanSo Tru(PhanSo ps) 
    {
        PhanSo ketqua = new PhanSo();
        ketqua.tuSo = tuSo * ps.mauSo - ps.tuSo * mauSo;
        ketqua.mauSo = mauSo * ps.mauSo;
        ketqua.RutGon();
        return ketqua;
    }
    public PhanSo Nhan(PhanSo ps) {
        PhanSo ketqua = new PhanSo();
        ketqua.tuSo = tuSo * ps.tuSo;
        ketqua.mauSo = mauSo * ps.mauSo;
        ketqua.RutGon();
        return ketqua;
    }
    public PhanSo Chia(PhanSo ps) {
        PhanSo ketqua = new PhanSo();
        ketqua.tuSo = tuSo * ps.mauSo;
        ketqua.mauSo = mauSo * ps.tuSo;
        ketqua.RutGon();
        return ketqua;
    }
}