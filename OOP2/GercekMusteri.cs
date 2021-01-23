using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Individual
    // özellik class' ıdır. varlıktır yani
    // miras inheritance' denir.  (class GercekMusteri :Musteri) tüzel müşteri bir müşteridir.
    class GercekMusteri :Musteri
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }

    }
}
