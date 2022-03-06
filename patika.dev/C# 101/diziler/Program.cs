namespace diziler{
    class Program{
        static void Main(string[] args)
        {
            string[] renkler = new string[5];

            string[] hayvanlar = {"kedi","kopek","kus"};

            int[] dizi;
            dizi = new int[5];

            renkler[0] = "Mavi";

            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            Console.WriteLine("dizinin eleman sayisini gir");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for(int i=0; i<diziUzunlugu; i++){
                Console.WriteLine("{0}. sayiyi gir",i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam=0;
            foreach(var sayi in sayiDizisi){
                toplam += sayi;
            }
            Console.WriteLine("ortalama: "+toplam/diziUzunlugu);
        }
    }
}