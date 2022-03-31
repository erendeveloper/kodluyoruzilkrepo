namespace Proje_2{
    class KolondakiKart{
        Kart kart;
        List<Kart> kolon;
        string kolonIsmi;
        public KolondakiKart(Kart kart, List<Kart> kolon, string kolonIsmi){
           this.kart=kart;
           this.kolon=kolon;
           this.kolonIsmi=kolonIsmi;
        }
        public Kart SeciliKart{get=>kart;}
        public List<Kart> Kolon{get=>kolon;}
        public string KolonIsmi{get=>kolonIsmi;}
    }
}