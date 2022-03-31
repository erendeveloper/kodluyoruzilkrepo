namespace Proje_2{
    class Kart{
        public Kart(string baslik, string icerik, int atanankisi, Buyukluk buyukluk){
            Baslik=baslik;
            Icerik=icerik;
            AtananKisi=atanankisi;
            KartBuyuklugu=buyukluk;
        }
        public string Baslik {get;set;}
        public string Icerik {get;set;}
        public int AtananKisi {get;set;}
        public Buyukluk KartBuyuklugu {get;set;}
    } 
}