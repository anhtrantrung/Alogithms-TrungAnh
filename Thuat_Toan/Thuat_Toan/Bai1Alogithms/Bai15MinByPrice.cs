using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thuat_Toan.Bai1Alogithms.entity;

namespace Thuat_Toan.Bai1Alogithms
{
    public class Bai15MinByPrice
    {
        /// <summary>
        /// Finds and returns the product with the minimum price from the given list.
        /// </summary>
        /// <param name="productList"></param>
        /// <returns>The product with the minimum price, or null if the list is empty.</returns>
        public Product MinByPrice(List<Product> productList)
        {
            if (productList.Count == 0)
            {
                return null;
            }

            Product minProduct = productList[0];
            foreach (Product product in productList)
            {
                if (product.Price < minProduct.Price)
                {
                    minProduct = product;
                }
            }
            return minProduct;
        }
    }
}
