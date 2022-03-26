using System;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collection.Generic
            Dictionary<int,string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(10,"Ayse Yilmaz");
            kullanicilar.Add(12,"Ahmet Yilmaz");
            //kullanicilar.Add(12,"VEli Yilmaz");//Ayni key veremessin
            kullanicilar.Add(18,"ADeniz Arda");
            kullanicilar.Add(20,"Ozcan Cosar");

            //Dizinin elamanlarina erisim
            Console.WriteLine("*** elemanlara Erisim ***");
            Console.WriteLine(kullanicilar[12]);
            foreach(var item in kullanicilar)
               Console.WriteLine(item);

            //Count
            Console.WriteLine(kullanicilar.Count);

            //Contains
            Console.WriteLine("*** Contains ***");
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Ali Yilmaz"));
        
            //REmove
            Console.WriteLine("*** Remove ***");
            kullanicilar.Remove(12);
            foreach(var item in kullanicilar)
               Console.WriteLine(item.Value);

            //Keys
            Console.WriteLine("*** Keys ***");
            foreach(var item in kullanicilar.Keys)
               Console.WriteLine(item);
            //Values
            Console.WriteLine("*** Values ***");
            foreach(var item in kullanicilar.Values)
               Console.WriteLine(item);
        }
    }
}