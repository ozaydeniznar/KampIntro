using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {

        public void Add(Customer customer)
        {
            Console.WriteLine("Welcome:" +customer.CustomerName + +customer.CustomerAge );
        }


       
    }
}
