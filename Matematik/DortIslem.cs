using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {


        public void Topla(Double sayi1, Double sayi2)
        {
            Double toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç: " + toplam);
        }
        public void Carp(Double sayi1, Double sayi2)
        {
            Double carpim = sayi1 * sayi2;
            Console.WriteLine("Sonuç: " + carpim);
        }

        public void Bol(double sayi1, double sayi2)
        {
            double bolum = sayi1 / sayi2;
            Console.WriteLine("Sonuç: "+bolum);
        }               
        
        public void Cikart(Double sayi1, Double sayi2)
        {
            double cikartma = sayi1 - sayi2;
            Console.WriteLine("Sonuç: "+cikartma);
        }

        public void Apostro()
        {
            string star = "--------------------------" ;
            Console.WriteLine(star);
        }



    }

}
