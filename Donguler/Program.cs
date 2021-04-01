using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Proğramlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //array diziler
            string[] kurslar = new string[]
            {
                "Yazılım geliştirici yetiştirme kampı",
                "Proğramlamaya başlangıç için temel kurs",
                "Java",
                "Python",
                "C++",
                "C#"
            };
            Console.WriteLine("-------------for-------------");

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("---------foreach------------");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu");

            Console.ReadLine();
        }
    }
}
