using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler = new string[5];       // new'leyince yeni adrese geçti ve o adresin 4. indexi ilker
            //isimler[4] = "İlker";          // diğer indexler boş.
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            // değerleri kaybetmemeye yarayan altyapı list
            // listelerin belirli fonksiyonlarını öğren

            List<string> isimler2 = new List<string>{"Engin", "Murat", "Kerem", "Halil"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }


    }
}