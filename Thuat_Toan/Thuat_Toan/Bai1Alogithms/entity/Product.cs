using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuat_Toan.Bai1Alogithms.entity
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quality { get; set; }
        public int CategoryId { get; set; }

        public Product(string name, double price, int quality, int categoryId)
        {
            Name = name;
            Price = price;
            Quality = quality;
            CategoryId = categoryId;
        }
    }
}
