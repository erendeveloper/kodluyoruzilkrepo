using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {

            Calisan calisan = new Calisan("Ayse","Yilmaz","IK");
            Console.WriteLine("Calisan Sayisi {0}", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Deniz","Arda","IK");
            Calisan calisan2 = new Calisan("Megmet","Ahmi","IK");
            Console.WriteLine("Calisan Sayisi {0}", Calisan.CalisanSayisi);
      
            Console.WriteLine("Toplama isleminin sonucu"+Islemler.Topla(100,200));
            Console.WriteLine("Cikarma isleminin sonucu"+Islemler.Topla(400,50));
       }
    }
    class Calisan
    {
        private static int calisanSayisi;
        public static int CalisanSayisi { get => calisanSayisi;}
        private string Isim;
        private string Soyisim;
        private string Departman;
        static Calisan(){//burayi oncelikle calistirir ve sadece ilk class yaratildiginda calisitirir
            calisanSayisi=0;
        }
        public Calisan(string isim, string soyisim, string departman){
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi ++;
        }
    }
    static class Islemler{
        public static long Topla(int sayi1, int sayi2){
            return sayi1+sayi2;
        }
        public static long Cikar(int sayi1, int sayi2){
            return sayi1-sayi2;
        }
    }
}