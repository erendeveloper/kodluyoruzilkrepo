using System;

namespace swwitch_case{
    class Program{
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            //expression
            switch (month)
            {
                case 1:
                   Console.WriteLine("Ocak ayindasiniz");
                   break;
                case 2:
                   Console.WriteLine("Subat ayindasiniz");
                   break;

                case 4:
                   Console.WriteLine("Nisan ayindasiniz");
                   break;
                
                case 3:
                   Console.WriteLine("Mart ayindasiniz");
                   break;

                default:
                   Console.WriteLine("Yanlis veri girdiniz");
                   break;
            }
        }
    }

}