using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thuat_Toan.Bai1Alogithms.entity;

namespace Thuat_Toan.Bai1Alogithms
{
    internal class Bai6FindProductByPrice
    {
        /// <summary>
        /// Prompts the user to enter data via the console 
        /// </summary>
        /// <returns>The price entered by the user.</returns>
        public double GetDataByPrice()
        {
            Console.WriteLine("Please enter data");
            var productNameToFind = Double.Parse(Console.ReadLine());
            return productNameToFind;
        }

        /// <summary>
        /// Finds and returns a list of product names from the given list whose prices are less than or equal to the specified price.
        /// </summary>
        /// <param name="productList"></param>
        /// <param name="price"></param>
        /// <returns>
        /// A list of product names whose prices are less than or equal to the specified price.
        /// </returns>
        public List<string> FindProductByPrice(List<Product> productList, double price)
        {
            List<string> productsWithinPrice = new List<string>();
            foreach (Product product in productList)
            {
                if (product.Price <= price)
                {
                    productsWithinPrice.Add(product.Name);
                }
            }
            return productsWithinPrice;
        }
    }
}
