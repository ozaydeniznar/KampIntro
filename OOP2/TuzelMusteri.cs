using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate
    // miras inheritance' denir.  (class TuzelMusteri:Musteri) tüzel müşteri bir müşteridir.
    // inheritance genelde müşteri'de olan özellikler tüzelde ve gerçektete vardır yani ortakları buraya atarız.
    //
    class TuzelMusteri :Musteri
    {

        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
