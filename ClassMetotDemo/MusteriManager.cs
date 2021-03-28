using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine(musteri.mID + "  " + musteri.mName + " " + musteri.mSurname + " " + musteri.mBirthday);

            Console.WriteLine("----------");
        }

        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.mName);

            Console.WriteLine(musteri.mSurname);

            Console.WriteLine(musteri.mBirthday);

            Console.WriteLine("----------");
        }

        public void MusteriCıkar(Musteri musteri)
        {
            Console.WriteLine(musteri.mName);

            Console.WriteLine("----------");
        }
    }
}
