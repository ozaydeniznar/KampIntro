using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
    {
        // okunurluğu arttırmak için biz bunları ' I ' harfi ile başlatırız.
        // interface ( aslında benin şablonum görevi görür)
        void Hesapla();

        void BiseyYap();


        // interface'leri birbirinin alternatifleri olan ve kod içerikleri farklı kodları olanlar için kullanırız
    }
}
