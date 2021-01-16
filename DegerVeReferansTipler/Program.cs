using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? = 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] 999

            //int-decimal-fload-double-bool=değer tip,
            //array,class,interface= referans tip

            // peki bunlar nasıl çalışıyorlar?
            //bellekte stack ve heap ike tane alan vardır.
            //değer tip olanlar stack'te gerçekleşir. örnek:sayi1=10 herşey stackta gerçekleşir.
            //sayi 1 in değeri eşittir sayi2 değeri. sadece değer aktar öbür bağlantı kopar.(değer kopyalar iş biter)
            

            //değer tipler sadece Stack' gerçekleşir.
            //new demek bellekten yeni bir adres ve yer oluşturmak demektir.
            // sayilar 1 in sayilar 2 nin referans numarasına eşittir diye okunmalı.
            //pointer ismi ile çıkar "C" gibi dillerde.

        }
    }
}
