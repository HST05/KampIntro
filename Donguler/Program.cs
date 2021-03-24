using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kategoriler = new string[] { "Araba","Montor","SUV","Bisiklet " };
            for (int i = 0; i < kategoriler.Length; i++)
            {
                Console.WriteLine(kategoriler[i]);
            }
            Console.WriteLine("*********************************************");

            foreach (string kategori in kategoriler)
            {
                Console.WriteLine(kategori);
            }
        }
    }
}
