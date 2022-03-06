using System;

namespace donguler_while_foreach{
    class Program{
        static void Main(string[] args)
        {
            //1 den baslayarak konsoldan girilen sayiya kadar sayi dahil ortalama hesapla
            Console.WriteLine("sayi gir");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while(sayac<=sayi){
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            //a'dan z ye kadar tum harfleri konsola yazdir
            char character ='a';
            while(character < 'z'){
                Console.Write(character);
                character ++;
            }

            Console.WriteLine("*** foreach ***");
            string[] arabalar = {"bmw","ford","nissan"};
            foreach(var araba in arabalar){
                Console.WriteLine(araba);
            }
        }
    }

}