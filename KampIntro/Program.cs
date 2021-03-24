using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
             else if (dolarDun < dolarBugun) 
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Düz Çizgi");            }

            if (sistemeGirisYapmisMi == true) 
            {
                Console.WriteLine("kullanıcı ayarları menüsü");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }
        }
    }
}
