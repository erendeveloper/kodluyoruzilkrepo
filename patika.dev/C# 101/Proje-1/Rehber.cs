using System;

namespace Proje_1
{
    class Rehber{
         List<Kisi> kisiler = new();

         public void Kaydet(Kisi kisi){
             kisiler.Add(kisi);
         }
         public void Sil(Kisi kisi){
             kisiler.Remove(kisi);
         }
         public List<Kisi> Listele(){
             return kisiler;
         }

         public List<Kisi> KisileriIsimIleAra(string isim){
            List<Kisi> kisiListesi = new();
            foreach(Kisi kisi in kisiler){
               if(kisi.Ad==isim || kisi.Soyad==isim){
                  kisiListesi.Add(kisi);
               }
            }
            return kisiListesi;
         }
         public List<Kisi> KisileriTelefonNoIleAra(string telefonNo){
            List<Kisi> kisiListesi = new();
            foreach(Kisi kisi in kisiler){
               if(kisi.TelefonNo==telefonNo){
                  kisiListesi.Add(kisi);
               }
            }
            return kisiListesi;
         }


         

    }
    
}