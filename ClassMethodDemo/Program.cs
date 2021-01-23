using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerName = "Deniz";
            customer1.CustomerAge = 22;

            Customer customer2 = new Customer();
            customer2.CustomerName = "Alper";
            customer2.CustomerAge = 20;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
