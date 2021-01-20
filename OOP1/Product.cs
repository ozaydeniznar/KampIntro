using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet ( hazır kodlar demek aslında)
    class Product //Entity gibi varlık isimleride verebiliriz Producta
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public double UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        //CRUD Operations
        //(Create Read Uptade Delete)
    }
}
