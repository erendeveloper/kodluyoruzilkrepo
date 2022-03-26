using System;
using System.Collections;

namespace koleksiyonlar_soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
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
                
                if(sayi<0){
                    Console.WriteLine("negatif girdin");
                    continue;
                }
                if(AsalSayi(sayi)){
                    asalSayilar.Add(sayi);
                }
                else{
                    asalOlmayanSayilar.Add(sayi);
                }

                numberCount++;     
            }
            asalSayilar.Reverse();
            asalOlmayanSayilar.Reverse();

            Console.WriteLine("Asal sayilar buyukten kucuge");
            foreach(var item in asalSayilar){
                Console.WriteLine(item);
            }
            Console.WriteLine("Asal olmayan sayilar buyukten kucuge");
            foreach(var item in asalOlmayanSayilar){
                Console.WriteLine(item);
            }
            Console.WriteLine("Asal sayilarin kac tane oldugu");
            Console.WriteLine(asalSayilar.Count);
            Console.WriteLine("Asal olmayansayilarin kac tane oldugu");
            Console.WriteLine(asalOlmayanSayilar.Count);

            Console.WriteLine("Asal sayilarin ortalamasi");
            OrtalamaGoster(asalSayilar);

            Console.WriteLine("Asal olmayansayilarin ortalamasi");
            OrtalamaGoster(asalOlmayanSayilar);

            void OrtalamaGoster(ArrayList arrayList){
              int sum=0;
              foreach(var item in arrayList){
                sum+=(int)item;
              }
              Console.WriteLine((float)sum/arrayList.Count);
            }
            bool AsalSayi(int sayi){
                int asalSayiCount=0;
                for (int i = 1; i <= sayi; i++) 
                {
                    if (sayi % i == 0) {
                         asalSayiCount++;
                    }
                }
                if(asalSayiCount==2){
                    return true;
                }
                else{
                    return false;
                }
            }

        }
        
        
    }
}