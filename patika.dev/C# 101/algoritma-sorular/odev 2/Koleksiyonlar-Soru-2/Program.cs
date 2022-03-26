using System;
using System.Collections;

namespace koleksiyonlar_soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList tumSayilar = new ArrayList();
            ArrayList enBuyukSayilar = new ArrayList();
            ArrayList enKucukSayilar = new ArrayList();
            int numberCount=1;
            while(numberCount<=20){
                Console.WriteLine(numberCount+". sayiyi gir:");
                int sayi=0;              
                try{
                    sayi=Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) {
                    Console.WriteLine("sayi girmelisin");
                    continue;
                }
                tumSayilar.Add(sayi);
                numberCount++;                     
            }

            int count=3;
            tumSayilar.Sort();
            for(int i=0; i<count; i++){
                enKucukSayilar.Add(tumSayilar[i]);
                //tumSayilar.RemoveAt(0);
            }
            tumSayilar.Reverse();
            for(int i=0; i<count; i++){
                enBuyukSayilar.Add(tumSayilar[i]);
                //tumSayilar.RemoveAt(0);
            }

            float enKucuklerOrtalama=Ortalama(enKucukSayilar);
            float enBuyuklerOrtalama=Ortalama(enBuyukSayilar);
            Console.WriteLine("En kucuk 3 sayinin ortalamasi: "+enKucuklerOrtalama);
            Console.WriteLine("En buyuk 3 sayinin ortalamasi: "+enBuyuklerOrtalama);
            Console.WriteLine("En buyuk ve en kucuk 3 sayinin ortalama toplamnlari: "+(enKucuklerOrtalama+enBuyuklerOrtalama));

            float Ortalama(ArrayList arrayList){
               int sum=0;
               foreach(var item in arrayList){
                 sum+=(int)item;
               }
               return ((float)sum/arrayList.Count);
            }
        }
        

    }
}