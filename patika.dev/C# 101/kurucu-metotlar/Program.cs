using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calisan1");
            Calisan calisan1 = new Calisan("Ayse","Kara",2345634,"Insan Kaynaklari");
            calisan1.Departman="Insan Kaynaklari";

            calisan1.CalisanBilgileri();

            Console.WriteLine("Calisan2");
            Calisan calisan2 = new Calisan();
            calisan2.Ad="Deniz";
            calisan2.Soyad="Arda";
            calisan2.No = 2345634;
            calisan2.Departman="satin Alma";

            calisan2.CalisanBilgileri();

            Console.WriteLine("Calisan3");
            Calisan calisan3 = new Calisan("Ahmet","Koltuk");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad=ad;
            this.Soyad=soyad;
            this.No=no;
            this.Departman=departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.Ad=ad;
            this.Soyad=soyad;
        }
        public Calisan(){}
        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisan Adi:{0}",Ad);
            Console.WriteLine("Calisan SoyAdi:{0}",Soyad);
            Console.WriteLine("Calisan Numaraswi::{0}",No);
            Console.WriteLine("Calisan Departmani:{0}",Departman);
        }
    }
}