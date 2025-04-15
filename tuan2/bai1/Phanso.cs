using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapvenhautuan2
{
    internal class Phanso
    {
       public int Tu { get; set; }
        public int Mau { get; set; }
        public Phanso() 
        { 
            Tu = 0;
            Mau = 1;
        }
        public Phanso(int tu, int mau)
        {
            if (mau == 0)
                throw new ArgumentException("mẫu số không được bằng 0");
            Tu = tu; 
            Mau = mau;
            RutGon();
        }
        public void Nhap() 
        {
            Console.Write("Nhập tử số:");
            Tu= int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập mẫu số:");
            Mau = int.Parse(Console.ReadLine());
            while (Mau == 0) 
            {
                Console.WriteLine("Mẫu số không được bằng 0.Nhập lại:");
                Mau= int.Parse(Console.ReadLine());
            }
            RutGon();
        }
        public static Phanso Cong (Phanso a, Phanso b)
        {
            int tuMoi = a.Tu* b.Mau+b.Tu*a.Mau;
            int mauMoi = a.Mau * b.Mau;
            return new Phanso(tuMoi, mauMoi);
        }
        public void RutGon()
        { 
            int ucln = UCLN(Math.Abs(Tu),Math.Abs(Mau);
            Tu /= ucln;
            Mau /= ucln;
            if (Mau < 0)
            {
                Tu = -Tu;
                Mau = -Mau;
            }
        }
        private int UCLN(int a ,  int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }
        public override string ToString()
        {
            return $"{Tu}/{Mau}";
        }
    }
}
