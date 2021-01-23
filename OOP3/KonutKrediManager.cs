using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // ampülden yararlan ( implement yap)
    class KonutKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut Kredisi Ödeme Planı hesaplandı");
        }
    }
}
