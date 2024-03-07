using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Task.Product
{
    

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public Product(string name, decimal price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }

        public string Detail()
        {
            return $"Name: {Name}, Price: {Price}, Count: {Count}";
        }

        public decimal Discount(int discountPercentage)
        {
            decimal discountAmount = Price * discountPercentage / 100;
            return Price - discountAmount;
        }
    }

}
