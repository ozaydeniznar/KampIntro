using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği (string tanımlamak istersen onun veri tipini yazmalısın)
            //metinsel olanları tek Tırnak ile yapma. Noktalı virgül zorunludu yapıdır.
            //değer tutucu (alias) kategorietiketi ( çift tırnak içinde yazmıyoruz)
            //int belli sınırları vardır. sayı anlamında
            //double veri tipi ondalıklı sayılar gösterilir.
            //boolean = bool(C#). sistemi giriş yapmış mı (yapmış ise kayıt ol butonu çıkmasın v.s....)yapmamışmı şart blokları...
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
