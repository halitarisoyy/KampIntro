using System;

namespace Bank_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Costumer costumer1 = new Costumer();
            costumer1.Id = 502;
            costumer1.NameLastname = "Anıl Umur Urun";
            costumer1.Adress = "Ankara";
            costumer1.Amount = 5000;

            Costumer costumer2 = new Costumer();
            costumer2.Id = 542;
            costumer2.NameLastname = "Bahadır Halit Arısoy";
            costumer2.Adress = "İstanbul";
            costumer2.Amount = 100000;

            Costumer costumer3 = new Costumer();
            costumer3.Id = 500;
            costumer3.NameLastname = "İrem Karaşin";
            costumer3.Adress = "Adana";
            costumer3.Amount = 3000;

            Costumer costumer4 = new Costumer();
            costumer4.Id = 555;
            costumer4.NameLastname = "Eren Çiçek";
            costumer4.Adress = "Sarıçam";
            costumer4.Amount = 2400;

            Costumer costumer5 = new Costumer();
            costumer5.Id = 565;
            costumer5.NameLastname = "Melike Kaya";
            costumer5.Adress = "İzmir";
            costumer5.Amount = 8100;


            Costumer[] costumers = new Costumer[] { costumer1, costumer2, costumer3, costumer4, costumer5 };

            foreach (var costum in costumers)
            {
                Console.WriteLine("Müşteri İD:   " +costum.Id);
                Console.WriteLine("İsim Soyisim: "+costum.NameLastname);
                Console.WriteLine("Adres:        "+costum.Adress);
                Console.WriteLine("Tutar:        "+costum.Amount+" TL");
                Console.WriteLine("--------------------------------");
            }

            CostumerManager costumerManager = new CostumerManager();

            Console.WriteLine();
            Console.WriteLine("--------------------------------");


            costumerManager.Entrance(costumer1);

            Console.WriteLine("--------------------------------");

            costumerManager.Entrance(costumer2);

            Console.WriteLine("--------------------------------");

            costumerManager.Entrance(costumer3);

            Console.WriteLine("--------------------------------");

            costumerManager.Entrance(costumer4);

            Console.WriteLine("--------------------------------");

            costumerManager.Entrance(costumer5);

            Console.WriteLine("--------------------------------");





        }
    }
}
