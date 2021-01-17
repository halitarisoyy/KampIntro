using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            Console.Write("Sayı giriniz: ");
            num1 = double.Parse(Console.ReadLine());

            double num2;
            Console.Write("Sayı giriniz: ");
            num2 = double.Parse(Console.ReadLine());

            //
            DortIslem dortislem = new DortIslem();
            //

            dortislem.Apostro();

            Console.WriteLine("TOPLAMA");
            dortislem.Topla(num1, num2);

            dortislem.Apostro();

            Console.WriteLine("ÇARPMA");
            dortislem.Carp(num1, num2);

            dortislem.Apostro();

            Console.WriteLine("BÖLME");
            dortislem.Bol(num1,num2);

            dortislem.Apostro();

            Console.WriteLine("ÇIKARTMA");
            dortislem.Cikart(num1, num2);

            dortislem.Apostro();

            Console.WriteLine("ÜS ALMA");
            //dortislem.UsAlma(num1,num2);

            double sonuc = 1;
            for (int i = 1; i <= num2; i++)
            {
                sonuc = num1 * sonuc;
            }
            Console.WriteLine("Sonuç: " + sonuc);

            dortislem.Apostro();




        }
    }
}
