using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar=3;
            dikdortgen.UzunKenar=4;
            Console.WriteLine("Class Alan Hesabi:{0}",dikdortgen.AlanHesapla());
       
            //Constructor vermeden
            //Dikdortgen_Struct dikdortgen_struct = new Dikdortgen_Struct();
            //Dikdortgen_Struct dikdortgen_struct; //boyle de calisir, degerlerini vermen lazim
            //dikdortgen_struct.KisaKenar=3;
            //dikdortgen_struct.UzunKenar=4;
            //Constructor verirsen
            Dikdortgen_Struct dikdortgen_struct = new Dikdortgen_Struct(3,4);
            dikdortgen_struct.KisaKenar=3;
            dikdortgen_struct.UzunKenar=4;

            Console.WriteLine("Struct Alan Hesabi:{0}",dikdortgen_struct.AlanHesapla());
            
       
        }
    }
    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;
        public Dikdortgen(){
            KisaKenar=1;
            UzunKenar=2;
        }
        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;
        /*
        public Dikdortgen_struct(){ //struct da parameteresiz vermessin
            KisaKenar=1;
            UzunKenar=2;
        }
        */
        public Dikdortgen_Struct(int kisaKenar, int uzunKenar){
            KisaKenar=kisaKenar;
            UzunKenar=uzunKenar;
        }
        public long AlanHesapla(){
        return this.KisaKenar * this.UzunKenar;
        }
    }
}