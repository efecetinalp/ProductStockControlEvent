using Entities;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(50);
            product1.ProductName = "Example Product-1";

            Product product2 = new Product(50);
            product2.ProductName = "Example Product-2";
            product2.StockControlEvent += Product2_StockControlEvent;

            Business business = new Business(product1,product2);

            for (int i = 0; i <= 10; i++)
            {
                business.Sell(10);
                Console.ReadLine();
            }
        }

        private static void Product2_StockControlEvent()
        {
            Console.WriteLine("product-2 is about to out of stock");
        }
    }
}
