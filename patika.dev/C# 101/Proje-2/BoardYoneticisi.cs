namespace Proje_2{
    class BoardYoneticisi{
        Board board = new();
        Takim takim=new();
        
        public void BaslangicEkrani(){
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            while(true){
                string islem=Console.ReadLine();
                if(islem=="1"){
                    BoardListele();
                }
                else if(islem=="2"){
                    KartEkle();
                }
                else if(islem=="3"){
                    KartSil();
                }
                else if(islem=="4"){
                    KartTasi();
                }
                else{
                    continue;
                }
                break;
            }
            
        }
        void KartEkle(){
            string baslik;
            string icerik;
            int buyukluk;
            int kisi;
            Console.Write("Başlık Giriniz                                  :");
            baslik=Console.ReadLine();
            Console.Write("İçerik Giriniz                                  :");
            icerik=Console.ReadLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            while(true){
                try{
                    buyukluk=int.Parse(Console.ReadLine());
                }
                catch{
                    continue;
                }
                if(buyukluk>=1 && buyukluk<=5){
                    break;
                }                
            }
            Console.Write("Kişi Seçiniz                                    :");
            while(true){
                try{
                    kisi=int.Parse(Console.ReadLine());
                }
                catch{
                    continue;
                }
                bool kisiKayitli=false;
                if(!takim.Uyeler.ContainsKey(kisi)){
                    Console.WriteLine("Kisi mevcut degil");
                    continue;
                }
                
                break;        
            }
            board.Ekle(new Kart(baslik,icerik,kisi,(Buyukluk)buyukluk));
            BoardListele();
            
        }
        void KartSil(){
            string baslik;
            bool kartSilindi=false;
            while(!kartSilindi){
               Console.WriteLine("Öncelikle silmek istediğiniz karti seçmeniz gerekiyor.");
               Console.Write("Lütfen kart başligini yaziniz:  ");
               baslik=Console.ReadLine();
               kartSilindi=!board.Sil(baslik);
               if(!kartSilindi){
                   Console.WriteLine("Aradiğiniz krtiterlere uygun kart board'da bulunamadi. Lütfen bir seçim yapiniz.");
                   Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                   Console.WriteLine("* Yeniden denemek için : (2)");
                   string islem;
                   while(true){                     
                      islem=Console.ReadLine();
                      if(islem=="1" || islem=="2"){
                          break;                         
                      }
                   }
                   if(islem=="1"){
                       break;
                   }                
               }             
            }
            BoardListele();         
        }
        void KartTasi(){
            string baslik;
            KolondakiKart kolondakiKart=null;
            while(kolondakiKart==null){
               Console.WriteLine("Öncelikle tasimak istediğiniz karti seçmeniz gerekiyor.");
               Console.Write("Lütfen kart başligini yaziniz:  ");
               baslik=Console.ReadLine();
               kolondakiKart=board.KartBul(baslik);
               if(kolondakiKart==null){
                   Console.WriteLine("Aradiginiz krtiterlere uygun kart board'da bulunamadi. Lütfen bir seçim yapiniz.");
                   Console.WriteLine("* Islemi sonlandırmak için : (1)");
                   Console.WriteLine("* Yeniden denemek için : (2)");
                   string islem;
                   while(true){                     
                      islem=Console.ReadLine();
                      if(islem=="1" || islem=="2"){
                          break;                         
                      }
                   }
                   if(islem=="1"){
                       break;
                   }      
               }
               else{
                   Console.WriteLine("Bulunan Kart Bilgileri");
                   KartBilgileriGoster(kolondakiKart.SeciliKart);
                   Console.WriteLine(kolondakiKart.KolonIsmi);
                   Console.WriteLine("");
                   Console.WriteLine("Lütfen tasimak istediğiniz Line'i seciniz:");
                   Console.WriteLine("(1) TODO");
                   Console.WriteLine("(2) IN PROGRESS");
                   Console.WriteLine("(3) DONE");
                   String islem;
                   while(true){
                       islem=Console.ReadLine();
                      if(islem=="1"){
                          board.KartTasi(kolondakiKart,Kolon.TODO);
                          break;
                      }
                      else if(islem=="2"){
                          board.KartTasi(kolondakiKart,Kolon.INPROGRESS);
                          break;
                      }
                      else if(islem=="3"){
                          board.KartTasi(kolondakiKart,Kolon.DONE);
                          break; 
                      }
                   }
                   
               }             
            }
            BoardListele();     
        }
        void BoardListele(){
            Console.WriteLine("TODO Line");
            BoardKolonGoster(board.ToDoListesi);
            Console.WriteLine();
            Console.WriteLine("IN PROGRESS Line");
            BoardKolonGoster(board.InProgressListesi);
            Console.WriteLine();
            Console.WriteLine("DONE Line");
            BoardKolonGoster(board.DoneListesi);          
        }
        void BoardKolonGoster(List<Kart> kolon){
            Console.WriteLine("************************");
             if(kolon.Count==0){
                Console.WriteLine("~ BOŞ ~");
            }
            else{
                for(int i=0; i<kolon.Count; i++){
                    KartBilgileriGoster(kolon[i]);
                    if(i != kolon.Count-1){
                        Console.WriteLine("-");
                    }
                }
            }
        }
        void KartBilgileriGoster(Kart kart){
            Console.WriteLine("Baslik:"+kart.Baslik);
            Console.WriteLine("Icerik:"+kart.Icerik);
            Console.WriteLine("AtananKisi:"+kart.AtananKisi);
            Console.WriteLine("Buyukluk:"+kart.KartBuyuklugu);
        }

        public void VarsayilanlarlaDoldur(){
             takim.UyeEkle("Ali");
             takim.UyeEkle("Ahmet");
             takim.UyeEkle("Mehmet");
             takim.UyeEkle("Ayse");
             takim.UyeEkle("Fatma");
             board.Ekle(new Kart("Baslik1","Icerik1",1,Buyukluk.XS));
             board.Ekle(new Kart("Baslik2","Icerik2",2,Buyukluk.L));
             board.Ekle(new Kart("Baslik3","Icerik3",3,Buyukluk.M));
        }

    } 
}