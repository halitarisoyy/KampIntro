using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştrici yetiştirme kampı";
            string kurs2 = "Proramlamaya giriş için temel kurs";
            string kurs3 = "Java geliştirci kursu";
            string kurs4 = "Python yazlımcı geliştirme kursu";
            string kurs5 = "C++ Yazılımcı geliştrieme kursu";
            
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            Console.WriteLine("");

            string[] kurslar = new string[] { "Yazılım geliştrici yetiştirme kampı","Proramlamaya giriş için temel kurs", "Java geliştirci kursu","Python yazılımcı geliştirme kursu", "C++ Yazılımcı geliştrieme kursu" };

            for (int i = 0; i < kurslar.Length; i += 1)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For döngüsü bitti.");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }

            Console.WriteLine("");
            Console.WriteLine("Sayfa sonu- Footer");
        }
    }
}
