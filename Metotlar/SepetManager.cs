using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler, sepete eklendi : "+ urun.Adi + " " + urun.UrunAdedi);
        }

        // alttaki hatalı kullanımdır.
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine ("Tebrikler sepete eklendi : "+ urunAdi);
        }
    }
}
