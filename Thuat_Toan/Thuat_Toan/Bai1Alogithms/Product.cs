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

        /// <summary>
        /// Initializes a new instance of the Product class with the specified name, price, quality, and category ID.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="quality"></param>
        /// <param name="categoryId"></param>
        public Product(string name, double price, int quality, int categoryId)
        {
            Name = name;
            Price = price;
            Quality = quality;
            CategoryId = categoryId;
        }
    }
}
