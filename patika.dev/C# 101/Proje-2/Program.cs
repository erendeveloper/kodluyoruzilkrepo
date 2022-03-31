using System;

namespace Proje_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BoardYoneticisi boardYoneticisi=new();
            boardYoneticisi.VarsayilanlarlaDoldur();
            boardYoneticisi.BaslangicEkrani();            
        }
    }
}