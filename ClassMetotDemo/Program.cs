using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.mID = 123456789;
            musteri1.mName = "Çağdaş";
            musteri1.mSurname = "Demirel";
            musteri1.mBirthday = "10/07/2001";


            Musteri musteri2 = new Musteri();
            musteri2.mID = 987654321;
            musteri2.mName = "Samet";
            musteri2.mSurname = "TECİR";
            musteri2.mBirthday = "01/10/2000";


            Musteri musteri3 = new Musteri();
            musteri3.mID = 01;
            musteri3.mName = "ADMİN";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();


            Console.WriteLine("Müşteri başarıyla eklenmiştir");
            Console.WriteLine("Eklenen müşteri bilgileri : ");

            Console.WriteLine(" ");

            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriListele(musteri2);
            musteriManager.MusteriListele(musteri3);

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("Müşteri başarıyla eklenmiştir");
            Console.WriteLine("Eklenen müşteri bilgileri : ");

            Console.WriteLine(" ");

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("Müşteri başarıyla Çıkarılmıştır");
            Console.WriteLine("Çıkarılan müşteri ismi : ");

            Console.WriteLine(" ");

            musteriManager.MusteriCıkar(musteri1);
            musteriManager.MusteriCıkar(musteri2);
            musteriManager.MusteriCıkar(musteri3);

            Console.WriteLine(" ");
            Console.WriteLine(" ");

        }
    }
}
