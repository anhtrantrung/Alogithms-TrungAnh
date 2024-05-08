using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thuat_Toan.Bai1Alogithms.entity;

namespace Thuat_Toan.Bai1Alogithms
{
    internal class Bai4FindProductByName
    {
        /// <summary>
        /// Prompts the user to enter data via the console
        /// </summary>
        /// <returns>The data entered by the user as a string.</returns>
        public string GetDataByName()
        {
            Console.WriteLine("Please enter data");
            var productNameToFind = Console.ReadLine();
            return productNameToFind;
        }

        /// <summary>
        /// Finds and returns a Product object from the given list with the specified name.
        /// </summary>
        /// <param name="productList"></param>
        /// <param name="nameProduct"></param>
        /// <returns>
        /// The Product object with the specified name if found, or null if no matching product is found.
        /// </returns>
        public Product FindProductByName(List<Product> productList, string nameProduct)
        {
            foreach (Product product in productList)
            {
                if (product.Name == nameProduct)
                {
                    return product;
                }
            }
            return null;
        }
    }
}
