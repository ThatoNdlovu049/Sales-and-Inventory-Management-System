using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_amd_Invemtory_Management_System
{
    internal class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public Product(string name, string category, double price, int stockQuantity)
        {
            Name = name;
            Category = category;
            Price = price;
            StockQuantity = stockQuantity;
        }
        public Product() { }
    }
}
