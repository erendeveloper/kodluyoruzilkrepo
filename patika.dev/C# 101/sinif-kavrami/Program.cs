using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.Ad="Ayse";
            calisan1.Soyad="Kara";
            calisan1.No = 2345634;
            calisan1.Departman="Insan Kaynaklari";

            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad="Deniz";
            calisan2.Soyad="Arda";
            calisan2.No = 2345634;
            calisan2.Departman="satin Alma";

            calisan2.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisan Adi:{0}",Ad);
            Console.WriteLine("Calisan SoyAdi:{0}",Soyad);
            Console.WriteLine("Calisan Numaraswi::{0}",No);
            Console.WriteLine("Calisan Departmani:{0}",Departman);
        }
    }
}