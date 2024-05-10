using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thuat_Toan.Bai1Alogithms.entity;

namespace Thuat_Toan.Bai1Alogithms
{
    public class Bai14MapProductByCategory
    {
        /// <summary>
        /// Creates a dictionary that maps category indices to category names.
        /// </summary>
        /// <param name="categoryList"></param>
        /// <returns>A dictionary where keys are category indices starting from 1 and values are category names.</returns>
        public Dictionary<int, string> CreateMapCategory(List<string> categoryList)
        {
            Dictionary<int, string> mapCategory = new Dictionary<int, string>();
            for (int i = 0; i < categoryList.Count; i++)
            {
                mapCategory[i + 1] = categoryList[i];
            }
            return mapCategory;
        }

        /// <summary>
        /// Maps each product in the given list to its corresponding category name.
        /// </summary>
        /// <param name="productList"></param>
        /// <param name="categoryList"></param>
        /// <returns>A list of tuples, where each tuple contains a Product object and its corresponding category name.</returns>
        public List<(Product, string)> MapProductByCategory(List<Product> productList, List<string> categoryList)
        {
            Dictionary<int, string> mapCategory = CreateMapCategory(categoryList);
            List<(Product, string)> mappedProducts = new List<(Product, string)>();
            foreach (Product product in productList)
            {
                string categoryName = mapCategory.ContainsKey(product.CategoryId) ? mapCategory[product.CategoryId] : "Unknown";
                mappedProducts.Add((product, categoryName));
            }
            return mappedProducts;
        }
    }
}
