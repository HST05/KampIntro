using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //string adi = "Samet";
            //int yas = 20;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Engin";
            kurs1.KursunDili = "Türkçe";
            kurs1.IzlenmeOranı = 65;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "Cado";
            kurs2.IzlenmeOranı = 6;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursunEgitmeni = "Hakkı";
            kurs3.IzlenmeOranı = 15;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C#";
            kurs4.KursunEgitmeni = "Engin";
            kurs4.KursunDili = "Türkçe";
            kurs4.IzlenmeOranı = 65;

            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursunEgitmeni);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3,kurs4 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.IzlenmeOranı);
            }
        }

    }
    public class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public string KursunDili { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}


