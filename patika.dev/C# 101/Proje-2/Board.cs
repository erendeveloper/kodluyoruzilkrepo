namespace Proje_2{
    class Board{

        List<Kart> toDoListesi =new();
        List<Kart> inProgressListesi =new();
        List<Kart> doneListesi =new();
        public List<Kart> ToDoListesi { get => toDoListesi; }
        public List<Kart> InProgressListesi { get => inProgressListesi; }
        public List<Kart> DoneListesi { get => doneListesi; }

        public void Ekle(Kart kart){
            toDoListesi.Add(kart);
        }
        public bool Sil(string baslik){

            int silenenToplamkartSayisi=0;

            silenenToplamkartSayisi=KolondanKartSil(baslik,toDoListesi);
            silenenToplamkartSayisi=KolondanKartSil(baslik,inProgressListesi);
            silenenToplamkartSayisi=KolondanKartSil(baslik,doneListesi);

            if(silenenToplamkartSayisi>0){
                return true;
            }
            else{
                return false;
            }

        }
        private int KolondanKartSil(string baslik, List<Kart> kolon){
            int silenenKartSayisi=0;
            foreach(Kart kart in toDoListesi.ToList()){
                if(kart.Baslik==baslik){
                    toDoListesi.Remove(kart);
                    silenenKartSayisi++;
                }
            }
            return silenenKartSayisi;
        }
        public KolondakiKart KartBul(string baslik){      
            foreach(Kart kart in toDoListesi){
                if(kart.Baslik==baslik){
                    return new KolondakiKart(kart,toDoListesi,"TODO");
                }
            }
            foreach(Kart kart in inProgressListesi){
                if(kart.Baslik==baslik){
                   return new KolondakiKart(kart,inProgressListesi,"IN PROGRESS");
                }
            }
            foreach(Kart kart in doneListesi){
                if(kart.Baslik==baslik){
                    return new KolondakiKart(kart,doneListesi,"DONE");
                }
            }
            return null;
        }
        public void KartTasi(KolondakiKart kolondakiKart, Kolon yeniKolonIsmi){
           kolondakiKart.Kolon.Remove(kolondakiKart.SeciliKart);
           List<Kart> yeniKolon;
           if(yeniKolonIsmi==Kolon.TODO){
               yeniKolon=toDoListesi;
           }
           else if(yeniKolonIsmi==Kolon.INPROGRESS){
               yeniKolon=inProgressListesi;
           }
           else{
               yeniKolon=doneListesi;
           }
           yeniKolon.Add(kolondakiKart.SeciliKart);
        }

    } 
}