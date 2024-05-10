using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thuat_Toan.Bai1Alogithms.entity;

namespace Thuat_Toan.Bai1Alogithms
{
    public class Bai5FindProductByCategoryId
    {
        /// <summary>
        /// Prompts the user to enter data via the console
        /// </summary>
        /// <returns>The category ID entered by the user.</returns>
        public int GetDataByCategoryId()
        {
            Console.WriteLine("Please enter data");
            var productNameToFind = Convert.ToInt32(Console.ReadLine());
            return productNameToFind;
        }

        /// <summary>
        /// Finds and returns a Product object from the given list with the specified category ID.
        /// </summary>
        /// <param name="productList"></param>
        /// <param name="categoryId"></param>
        /// <returns>
        /// The Product object with the specified category ID if found, or null if no matching product is found.
        /// </returns>
        public Product FindProductByCategoryId(List<Product> productList, int categoryId)
        {
            foreach (Product product in productList)
            {
                if (product.CategoryId == categoryId)
                {
                    return product;
                }
            }
            return null;
        }
    }
}
