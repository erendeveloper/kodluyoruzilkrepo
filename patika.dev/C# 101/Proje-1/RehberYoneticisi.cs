using System;

namespace Proje_1
{
    class RehberYoneticisi{

        Rehber rehber = new();

        public void KisiEkle(){
            string ad, soyad, telefonNo;

            Console.WriteLine("Lütfen isim giriniz             :");   
            Console.WriteLine("Lütfen soyisim giriniz          :"); 
            Console.WriteLine("Lütfen telefon numarasi giriniz :");          
            ad=Console.ReadLine();
            soyad=Console.ReadLine();
            telefonNo=Console.ReadLine();

            rehber.Kaydet(new Kisi(ad,soyad,telefonNo));
            RehberiListele();
         }
        public void KisiSil(){
            string isim;
            Kisi kisi;
            while(true){
                Console.WriteLine("Lütfen numarasini silmek istediğiniz kişinin adini ya da soyadini giriniz:");
                List<Kisi> kisiListesi=rehber.KisileriIsimIleAra(Console.ReadLine());
                if(kisiListesi.Count!=0){
                    Console.WriteLine($"{kisiListesi[0].Ad} {kisiListesi[0].Soyad} isimli kişi rehberden silinmek üzere, onayliyor musunuz ?(y/n)");
                    string islem;
                    while(true){
                        islem=Console.ReadLine();
                        if(islem=="y"){
                            rehber.Sil(kisiListesi[0]);
                            RehberiListele();
                            break;
                        }
                        else if(islem=="n"){
                            break;
                        }
                    }
                    break;                   
                }
                else{
                    Console.WriteLine("Aradiginiz krtiterlere uygun veri rehberde bulunamadi.Lütfen bir seçim yapiniz.");
                    Console.WriteLine("* Silmeyi sonlandirmak icin : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    int islemNo;
                    while(true){           
                       try{
                           islemNo=int.Parse(Console.ReadLine());
                           if(islemNo>=1 && islemNo<=2)
                              break;                  
                       }
                       catch(Exception e){
                           Console.WriteLine(e.ToString());
                       }
                    }
                    if(islemNo==1){
                        break;
                    }
                    else
                        continue;
                }
            }            
        }
        public void KisininNumarasiGuncelle(){
            string isim;
            Kisi kisi;
            while(true){
                Console.WriteLine("Lütfen numarasini guncellemek istediğiniz kişinin adini ya da soyadini giriniz:");
                isim=Console.ReadLine();
                List<Kisi> kisiListesi = rehber.KisileriIsimIleAra(isim);
                if(kisiListesi.Count!=0){
                    Console.WriteLine($"{kisiListesi[0].Ad} {kisiListesi[0].Soyad}'in yeni numarasini giriniz:");
                    string yeniTelefonNo=Console.ReadLine();
                    kisiListesi[0].TelefonNo=yeniTelefonNo;  
                    RehberiListele();
                    break;      
                }
                else{
                    Console.WriteLine("Aradiginiz krtiterlere uygun veri rehberde bulunamadi. Lütfen bir seçim yapiniz.");
                    Console.WriteLine("* Güncellemeyi sonlandirmak için    : (1)");
                    Console.WriteLine("* Yeniden denemek için              : (2)");
                    int islemNo;
                    while(true){           
                       try{
                           islemNo=int.Parse(Console.ReadLine());
                           if(islemNo>=1 && islemNo<=2)
                              break;                  
                       }
                       catch(Exception e){
                           Console.WriteLine(e.ToString());
                       }
                    }
                    if(islemNo==1){
                        break;
                    }
                    else
                        continue;
                }
            } 
        }
        public void RehberiListele(){
            Console.WriteLine("Telefon Rehberi");
            List<Kisi> kisiListesi = rehber.Listele();
            KisileriListele(kisiListesi);
        }
        public void KisileriAra(){
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasina göre arama yapmak için: (2)");
            List<Kisi> kisiListesi;
            int islemNo;
            while(true){           
                try{
                    islemNo=int.Parse(Console.ReadLine());
                    if(islemNo>=1 && islemNo<=2)
                        break;                  
                }
                catch(Exception e){
                    Console.WriteLine(e.ToString());
                }
            }
            while(true){
                if(islemNo==1){
                    Console.WriteLine("Ad veya soyad gir");
                    kisiListesi=rehber.KisileriIsimIleAra(Console.ReadLine());                          
                    break;
                }
                else if(islemNo==2){
                    Console.WriteLine("telefon gir");
                    kisiListesi=rehber.KisileriTelefonNoIleAra(Console.ReadLine());    
                    break;
                }
            }
            KisileriListele(kisiListesi);
        }

        
        public void RehberiVarsayilanlarlaDoldur(){
            rehber.Kaydet(new Kisi("Ali","Cicek","1111"));
            rehber.Kaydet(new Kisi("Kemal","Portakal","2222"));
            rehber.Kaydet(new Kisi("Ayse","Ikinci","3333"));
            rehber.Kaydet(new Kisi("Necdet","Akasya","4444"));
            rehber.Kaydet(new Kisi("Ahmet","Ormanci","5555"));
        }
        public void IslemSor(){
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayi Silmek");
            Console.WriteLine("(3) Varolan Numarayi Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            int islemNo;
            while(true){           
                try{
                   islemNo=int.Parse(Console.ReadLine());
                   if(islemNo>=1 && islemNo<=5)
                      break;                  
                }
                catch(Exception e){
                   Console.WriteLine(e.ToString());
                }
            }
            switch (islemNo)
            {
                case 1: KisiEkle(); break;
                case 2: KisiSil(); break;
                case 3: KisininNumarasiGuncelle(); break;
                case 4: RehberiListele(); break;
                case 5: KisileriAra(); break;
            }
            
        }
        void KisileriListele(List<Kisi> kisiListesi){
            Console.WriteLine("**********************************************");
            for(int i=0; i<kisiListesi.Count; i++){
               Console.WriteLine($"isim: {kisiListesi[i].Ad}");
               Console.WriteLine($"Soyisim: {kisiListesi[i].Soyad}");
               Console.WriteLine($"Telefon Numarasi: {kisiListesi[i].TelefonNo}");
               if(i!=kisiListesi.Count-1){
                   Console.WriteLine("-");
               }
            }
            Console.WriteLine(".");
            Console.WriteLine(".");
        }

    }
}