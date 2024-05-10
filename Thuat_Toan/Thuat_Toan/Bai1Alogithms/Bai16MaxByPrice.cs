using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thuat_Toan.Bai1Alogithms.entity;

namespace Thuat_Toan.Bai1Alogithms
{
    public class Bai16MaxByPrice
    {
        /// <summary>
        /// Finds and returns the product with the maximum price from the given list.
        /// </summary>
        /// <param name="productList"></param>
        /// <returns>The product with the maximum price, or null if the list is empty.</returns>
        public Product MaxByPrice(List<Product> productList)
        {
            if (productList.Count == 0)
            {
                return null;
            }

            Product maxProduct = productList[0];
            foreach (Product product in productList)
            {
                if (product.Price > maxProduct.Price)
                {
                    maxProduct = product;
                }
            }
            return maxProduct;
        }
    }
}
