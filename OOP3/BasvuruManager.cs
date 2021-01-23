using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme v.b.. bu kodlar buraya yazılır.
            // birden fazla logger yollamak istersen List<ILoggerService> yap.
            krediManager.Hesapla();
            loggerService.Log();

            //Method injection



            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            // bu demek hepsi konut kredimanagerden hesaplanır. yani tüm başvuruyu konut kredisi haline getirdin.
        }


        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
