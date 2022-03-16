using System;

namespace algoritma_sorular{
    class Program{
        static void Main(string[] args){
            /*
            int n,m;
            //soru 1
            Console.WriteLine("Pozitif sayi gir");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} tane pozitif sayi gir",n);
            List<int> ciftSayialr = new();
            for(int i=1; i<=n; i++){
                int sayi = int.Parse(Console.ReadLine());
                if(sayi%2==0){
                    ciftSayialr.Add(sayi);
                }
            }
            Console.WriteLine("Girmis oldugun cift sayilar");
            foreach(int ciftSayi in ciftSayialr){
                Console.Write(ciftSayi+" ");
            }
            //soru 2
            Console.WriteLine("Pozitif iki sayi gir");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} tane pozitif sayi gir",n);
            List<int> myeTamBolunenler = new();
            for(int i=1; i<=n; i++){
                int sayi = int.Parse(Console.ReadLine());
                if(sayi%m==0){
                    myeTamBolunenler.Add(sayi);
                }
            }
            Console.WriteLine("Basta 2.girdigin sayiya tam bolunen sayilar");
            foreach(int myeTamBolunen in myeTamBolunenler){
                Console.Write(myeTamBolunen+" ");
            }
            //soru 3
            Console.WriteLine("Pozitif sayi gir");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} tane kelime gir",n);
            List<string> kelimeler = new();
            for(int i=1; i<=n; i++){
                kelimeler.Add(Console.ReadLine());
            }
            Console.WriteLine("Yazdigin kelimler ters sirayla:");
            for(int i=n-1; i>=0; i--){
                Console.Write(kelimeler[i]+" ");
            }
            */
            //soru4
            Console.WriteLine("Cumle yaz");
            string cumle = Console.ReadLine();
            int kelimeSayisi =0;
            int harfSayisi=0;
            if(cumle!=""){
                kelimeSayisi=1;
            }
            foreach(char ch in cumle){
                 if(ch!=' '){
                     harfSayisi++;
                 }
                 else{
                     kelimeSayisi++;
                 }
            }
            int n=0;
            Console.WriteLine("Yazdigin cumlede {0} kelime, {1} harf var",kelimeSayisi,harfSayisi);
        }
    }
}