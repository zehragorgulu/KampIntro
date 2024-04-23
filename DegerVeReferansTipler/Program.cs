using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            // int,decimal,float double bool --> değer tip 
            // array class interface --> referans tip 
            // stack--> değer tip     heap--> referans tip  
            
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
        }
    }
}