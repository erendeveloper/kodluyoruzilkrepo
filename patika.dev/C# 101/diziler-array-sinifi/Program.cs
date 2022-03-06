namespace diziler_sttsy_dinifi{
    class Program{
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};

            Console.WriteLine("**** sirasiz dizi ****");
            foreach(var sayi in sayiDizisi)
               Console.WriteLine(sayi);

            Console.WriteLine("**** sirali dizi ****");
            Array.Sort(sayiDizisi);
            foreach(var sayi in sayiDizisi)
               Console.WriteLine(sayi);

            //Clear
            Console.WriteLine("**** Array Clear ****");
            //sayiDizisi elemanlarini kullanarak 2.indeksten itibaren 2 tane elemani 0'lar.
            Array.Clear(sayiDizisi,2,2);
            foreach(var sayi in sayiDizisi)
               Console.WriteLine(sayi);

            //Reverse
            Console.WriteLine("**** Array Reverse ****");
            Array.Reverse(sayiDizisi);
            foreach(var sayi in sayiDizisi)
               Console.WriteLine(sayi);

            //IndexOf
            Console.WriteLine("*** Array IndexOf ****");           
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));//23 un indeksi

            //Resize
            Console.WriteLine("*** Array Resize ****"); 
            Array.Resize<int>(ref sayiDizisi,9);//sayi dizisini referans verip yeni boyutunu 9 yapiyoruym
            sayiDizisi[8]=90;

            foreach(var sayi in sayiDizisi)
               Console.WriteLine(sayi);

        }
    }
}