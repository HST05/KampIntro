using System;

namespace Karalama_defteri
{
    class Program
    {
        static void Main(string[] args)
        {


            Kullanıcı kullanıcı1 = new Kullanıcı();
            kullanıcı1.KullaniciAdi = "Cağdaş";
            kullanıcı1.KullaniciSifresi = 12345;


            Kullanıcı kullanıcı2 = new Kullanıcı();
            kullanıcı2.KullaniciAdi = "Samet";
            kullanıcı2.KullaniciSifresi = 751248963;

            Kullanıcı kullanıcı3 = new Kullanıcı();
            kullanıcı3.KullaniciAdi = "ADMIN";
            kullanıcı3.KullaniciSifresi = 789456123;

            //Console.WriteLine(kullanıcı1.KullaniciAdi);

            bool durumAdmin = (kullanıcı3.KullaniciAdi == "ADMN" && kullanıcı3.KullaniciSifresi == 789456123) ? true : false;
            bool durumCagdas = (kullanıcı1.KullaniciAdi == "Cağda" && kullanıcı1.KullaniciSifresi == 12345) ? true : false;
            bool durumSamet = (kullanıcı2.KullaniciAdi == "Samet" && kullanıcı2.KullaniciSifresi == 751248963) ? true : false;
            Console.WriteLine(durumAdmin);
            Console.WriteLine(durumCagdas);
            Console.WriteLine(durumAdmin);


            int i = 1;
            while (i <= 10000)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadKey();


        }

    }

    //class Kullanıcı
    //{
    //    public string KullaniciAdi { get; set; }
    //    public int KullaniciSifresi { get; set; }
    //}


}
