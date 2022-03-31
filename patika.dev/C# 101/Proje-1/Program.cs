using System;

namespace Proje_1
{
    class Program
    {
        static void Main(string[] args)
        {
             RehberYoneticisi rehberYoneticisi=new();
             rehberYoneticisi.RehberiVarsayilanlarlaDoldur();
             rehberYoneticisi.IslemSor();
        }
    }
}