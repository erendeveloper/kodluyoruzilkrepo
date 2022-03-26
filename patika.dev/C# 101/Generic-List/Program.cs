using System;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kirmizi");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sari");
            renkListesi.Add("Yesil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //foreech ve List.ForEach ile lemanlara erisim
            foreach(var sayi in sayiListesi)
               Console.WriteLine(sayi);
            foreach(var renk in renkListesi)
               Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            sayiListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman cikarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yesil");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            sayiListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste icerisinde Arama
            if(sayiListesi.Contains(10))
               Console.WriteLine("10 Liste icerisinde bulundu");

            //eleman ile index'e erisme
            Console.WriteLine(renkListesi.BinarySearch("Sari"));

            //Diziyi List'e cevirme
            string[] hayvanlar = {"Kedi","Kopek","Kus"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi nasil temizleriz
            hayvanListesi.Clear();

            //List icerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
            
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim="Ayse";
            kullanici1.SoyIsim = "Yilaz";
            kullanici1.Yas=26;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim="Ozcan";
            kullanici2.SoyIsim = "Caliskan";
            kullanici2.Yas=26;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar(){
                Isim="Deniz",
                SoyIsim="Arda",
                Yas=24
            });

            foreach(var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanici Adi" + kullanici.Isim);
                Console.WriteLine("Kullanici soyadi" + kullanici.SoyIsim);
                Console.WriteLine("Kullanici Yas:"+kullanici.Yas);
            }

            yeniListe.Clear();
        }
    }

    public class Kullanicilar{
        private string isim;
        private string soyisim;
        private int yas;
        public string Isim { get => isim; set => isim = value; }
        public string SoyIsim { get => soyisim; set => soyisim =value; }
        public int Yas { get => yas; set => yas = value; }
    }
}