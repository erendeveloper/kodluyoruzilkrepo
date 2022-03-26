using System;

namespace koleksiyonlar_soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] sesliHarfler={'a','e','i','o','u','A','E','I','I','U'};
            List<char> cumledekiSesliHarfler=new List<char>();
            Console.WriteLine("Cumle yaz");
            string cumle = Console.ReadLine();
            for(int i=0; i<cumle.Length; i++){
                if(sesliHarfler.Contains(cumle[i])){
                    cumledekiSesliHarfler.Add(cumle[i]);
                }
            }
            cumledekiSesliHarfler.Sort();
            Console.WriteLine("cumledeki sesli harfler alfabetik olarak:");
            foreach(char ch in cumledekiSesliHarfler){
                Console.WriteLine(ch);
            }

        }
    }
}