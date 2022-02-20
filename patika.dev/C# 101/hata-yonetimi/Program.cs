using System;

namespace hata_yonetimi{
    class Program{
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi girin");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayi);

            try
            {

            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata: "+ex.Message.ToString());
            }
            finally{
                Console.WriteLine("Islem tamamlanmdi");
            }

            try
            {
               // int a = UInt16.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000");

            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Bos deger girdiniz");
                Console.WriteLine(ex);
;           }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Veri tipi uygun degil");
                Console.WriteLine(ex);
;           }
            catch(OverflowException ex)
            {
                Console.WriteLine("cok kucuk yada cok buyuk bir deger girsdiniz");
                Console.WriteLine(ex);
            }
            finally{
                Console.WriteLine("Islem basariyla tamamlanmdi");
            }

        }
    }

}