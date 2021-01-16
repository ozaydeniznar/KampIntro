using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "test";
            string kurs2 = "Yazılım Geliştirici Kapmı";
            string kurs3 = "Java";
            string kurs4 = "Python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            //array - dizi [] -- yani istediğin kadar kursu array' de tutabilirsin. de Tektek tanımlamak yerine Array' de tutuyoruz)

            string[] kurslar = new string[] { "test", "Yazılım Geliştirici Kapmı", "Java", "Python" };


            for (int i = 0; i<kurslar.Length; i++) //2-2 arttır demek +2,+2  //kurslar.lenght (hepsini yazar kaç tane eleman var ise hepsini yazar) dinamikleştirmek önemli
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar) //foreach dizi temelli yapıları tek tek dönmeye yarar.. kursları dolaşır(dizi leri kolay dolaşırsınız)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
