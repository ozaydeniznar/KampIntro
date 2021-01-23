using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)

            //// inheritance
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Deniz";
            musteri1.Soyadi = "NAR";
            musteri1.TcNo = "34655622135434";

            ///Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "234235235";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "373523562345";



            //Gerçek Müşteri - Tüzel Müşteri (bunlar sırf birbirine benziyor diye birbirinin yerine kullanılamazlar.
            // SOLID - bu teknigi 'L' harfi söyler .

            // new GercekMusteri(); / new bellekteki referans no' su
            //hem gerçekmüşteri ve hem tüzel müşteri referansını tutar.

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Deniz";
            //musteri1.Soyadi = "NAR";
            //musteri1.Id = 1;
            //musteri1.TcNo = "23423423";
            //musteri1.MusteriNo = "234324";
            //musteri1.SirketAdi = "?";
        }
    }
}
