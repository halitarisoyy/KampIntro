using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyat = 14;
            string detay = "Amasya elması";

            Console.WriteLine("{0}: {1} Tl.", detay, fiyat);


            string[] meyveler = new string[] { };


            //urun1
            Urunler urun1 = new Urunler();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya elması";
            urun1.stokAdedi = 110;

            //urun2
            Urunler urun2 = new Urunler();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.stokAdedi = 120;

            Urunler[] urunlers = new Urunler[] { urun1, urun2 };


            foreach (Urunler urun in urunlers)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyat+" Tl");
                Console.WriteLine(urun.stokAdedi+" adet");
                Console.WriteLine("-----------------------------------");
            }


            Console.WriteLine("---------------Metotlar----------------------");
            Console.WriteLine(" ");
            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("");

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,100);
            sepetManager.Ekle2("Elma", "Amasya elması", 13,120);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 32,180);
            sepetManager.Ekle2("Kiraz", "Niğde kirazı", 10,120);







        }
    }
}
