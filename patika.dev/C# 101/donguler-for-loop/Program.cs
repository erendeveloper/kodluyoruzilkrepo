﻿using System;

namespace donguler_for_loop{
    class Program{
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayi girin");
            int sayac = int.Parse(Console.ReadLine());
            for(int i=1; i<=sayac; i++){
                if(i%2==1)
                   Console.WriteLine(i);
            }
            
            //1 ile 100 arasindaki tek ve cift sayilarin iclerindeki toplami yazdir
            int tekToplam=0;
            int ciftToplam=0;
            for(int i=0; i<=1000; i++){
                if(i%2==1)
                   tekToplam+=1;
                else
                ciftToplam +=1;
            }
            Console.WriteLine("Tek toplam:" + tekToplam);
            Console.WriteLine("Cift toplam"+ ciftToplam);
            
            //braeak, continue

            for(int i=1; i<10; i++){
               if(i==4)
                  continue;
               Console.WriteLine(i);
            }

        }
    }

}