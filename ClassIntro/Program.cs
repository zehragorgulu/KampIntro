using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "ZG";
            int yas = 24;

            Kurs kurs1 = new Kurs();   // --> bir kurs değişkeni tanımlama ve atama
            kurs1.KursAdi = "C#";
            kurs1.egitmen = "Engin";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.egitmen = "ZG";
            kurs2.izlenmeOrani = 25;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.egitmen = "Burukali";
            kurs3.izlenmeOrani = 13;

            //Console.WriteLine(kurs1.KursAdi + " "+  kurs1.egitmen+" " + kurs2.izlenmeOrani);
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }

        class Kurs           // kendi veri tipini oluşturuyor gibi düşün 3 özellik(prop) tutuyor
        {
            public string KursAdi { get; set; }
            public string egitmen { get; set; }

            public int izlenmeOrani { get; set; }

        }
    }
}