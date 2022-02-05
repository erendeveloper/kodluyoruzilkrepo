using System;

namespace tip_donusumleri{
    class Program{
        static void Main(string[] args)
        {
            //implicit conversion
            byte a=5;
            sbyte b=30;
            short c=10;

            int d=a+b+c;
            Console.WriteLine("d:"+d);

            long h=d;
            Console.WriteLine("h:"+h);

            float i=h;
            Console.WriteLine("i:"+i);

            string e="Joe";
            char f='k';
            object g =e+f+d;
            Console.WriteLine("g:"+g);

            //explicit  conversion

            Console.WriteLine("*******explicit conversion*********");

            int x=4;
            byte y=(byte)x;
            Console.WriteLine("y:"+y);

            float w=18.3f;
            byte v=(byte)w;
            Console.WriteLine("v:"+v);

           //ToString
           Console.WriteLine("*******ToString*********");
           int xx=6;
           string yy=xx.ToString();
           Console.WriteLine("yy:"+yy);

           string zz=12.5f.ToString();
           Console.WriteLine("zz:"+zz);

           //System.Convert
           Console.WriteLine("********* System.Convert sinifi **********");
           string s1="10", s2="20";
           int sayi1, sayi2;
           int Toplam;

           sayi1=Convert.ToInt32(s1);
           sayi2=Convert.ToInt32(s2);

           Toplam=sayi1+sayi2;
           Console.WriteLine("Toplam:"+Toplam);

           //Parse
           Console.WriteLine("****** Parse M|Ethodu*****");
           ParseMethod();

        }

        public static void ParseMethod(){
            string metin1="10";
            string metin2="10.25";
            int rakam1;
            double double1;
            rakam1=Int32.Parse(metin1);
            Console.WriteLine("rakam1:"+rakam1);
            double1=Double.Parse(metin2);
            Console.WriteLine("doubl11:"+double1);
        }
    }

}