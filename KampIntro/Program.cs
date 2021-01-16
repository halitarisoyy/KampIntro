using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            string kategoriEtiketi = "Kategori";
            int OgrenciSayısı = 32000;
            long TcNo = 1234567891025;
            double FaizOranı = 1.45;
            bool KayıtliMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.75;

            if (dolarDun > dolarBugun) 
            {
                Console.WriteLine("<<<AZALAN OK>>>");
            }
            else if (dolarBugun == dolarDun) 
            {
                Console.WriteLine("<<<SABİT OK>>>");
            }
            else
            {
                Console.WriteLine("<<<ARTAN OK>>>");
            }

            if (KayıtliMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu.");
            
            }
            Console.WriteLine(kategoriEtiketi);

        }
                    
    }
}