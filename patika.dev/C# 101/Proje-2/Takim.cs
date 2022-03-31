namespace Proje_2{
    class Takim{

        int id=0;
        Dictionary<int,string> uyeler=new();
        public Dictionary<int,string> Uyeler {get => uyeler;}

        public void UyeEkle(string isim){
            id++;
            uyeler.Add(id,isim);
        }
    }
}