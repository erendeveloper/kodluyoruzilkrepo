using System;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz Csharp, Hosgeldiniz";
            string degisken2 = "Dersimiz Csharp";

            //Length
            Console.WriteLine(degisken.Length);

            //ToUpper, ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degisken,"Merhaba"));

            //Compare, compareTo
            Console.WriteLine(degisken.CompareTo(degisken2));//0 1 -1, esitse 0, 1. karakter sayisi buyukse 1, kucukse -1 doner
            Console.WriteLine(String.Compare(degisken,degisken2,true));//igmore case true dedgimiz icin buyuk kucuk harf duyarsiz
            Console.WriteLine(String.Compare(degisken,degisken2,false));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.Contains("Hosgeldiniz"));
            Console.WriteLine(degisken.Contains("Merhaba"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("Cs"));//bulamassa -1 doner

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba "));
            Console.WriteLine(degisken);

            //PadLeft, PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30)); //bosluk koyuyor
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));

            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("Csharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);//split ypip 1.yi getirdi

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));


        }
    }
}