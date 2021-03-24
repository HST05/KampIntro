using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public static SepetManager sepetManager { get; internal set; }

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi : "+urun.Adi);

        }
        public void Ekle2(string urunAdi,string aciklama, double fiyat)
        {
            Console.WriteLine("Sepete eklendi 2 : " + urunAdi);
        }
    }
}
