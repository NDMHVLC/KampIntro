using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety -- tip güvenliği
            //do not repeat your self -- kendini tekrarlama
            /*
             * değerTipi değerTutucu(alias) =  "değer";
             * string     kategoriEtiketi   = "Kategori";
             */
            
            string katagoriEtiketi = "Katagori";    //(Sayısal veriler)
            int ogrenciSayisi = 32000;
            double faizOrani = 1.75;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış oku");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış oku");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }


            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(katagoriEtiketi);

            
            Console.ReadLine();
        }
    }
}
