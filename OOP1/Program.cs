using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;


            // bu şekildede yazılabilir. gerçek hayatta en çok kullanılanlar.
            Product product2 = new Product {Id =2, CategoryId=5, UnitsInStock=5, ProductName="Kalem", UnitPrice=35};

            //PascalCase   //CamelCase     // new ile yeni bir referans numarası aldırıyoruz.
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.);


            //Case sensitive büyük ve küçük harf duyarlılığı

            //int, double, bool ... değer tip
            //diziler, class, abstract class, interface ... referans tip

            // atamalar referans numarası ile yapılır (adresteki)

            //ref ve out keyword
        }
    }
}
