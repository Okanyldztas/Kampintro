using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repat yourself - Kendini tekrarlama



            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Kur değişmedi");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
          
            Console.WriteLine(kategoriEtiketi);






            Console.WriteLine("-----------------");

            int canavarHasar = 15;
            int benimCan = 15;

            if (canavarHasar >= benimCan)
            {
                Console.WriteLine("öldü");
            }
            
            else
            {
                Console.WriteLine("yasadım");
            }
        }
    }
}
