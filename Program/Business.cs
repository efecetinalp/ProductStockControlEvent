using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Business
    {
        Product[] _products;
        public Business(params Product[] products)
        {
            _products = products;
        }
        public void Sell(int amount)
        {
            foreach (Product product in _products)
            {
                product.UnitsInStock -= amount;
                Console.WriteLine("{0} stock amount: {1}", product.ProductName, product.UnitsInStock);
            }
        }
    }
}
