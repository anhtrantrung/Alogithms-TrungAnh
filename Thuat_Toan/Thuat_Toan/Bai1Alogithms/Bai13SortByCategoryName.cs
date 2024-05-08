using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thuat_Toan.Bai1Alogithms.entity;

namespace Thuat_Toan.Bai1Alogithms
{
    internal class Bai13SortByCategoryName
    {
        /// <summary>
        /// Sorts the given list of Product objects by the categories' positions in the provided category list.
        /// </summary>
        /// <param name="productList"></param>
        /// <param name="categoryList"></param>
        /// <returns>A sorted list of Product objects by the categories' positions in the provided category list.</returns>
        public List<Product> SortByCategoryName(List<Product> productList, List<string> categoryList)
        {
            for (int i = 1; i < productList.Count; i++)
            {
                Product key = productList[i];
                int j = i - 1;

                while (j >= 0 && GetCategoryIndex(productList[j].Name, categoryList) > GetCategoryIndex(key.Name, categoryList))
                {
                    productList[j + 1] = productList[j];
                    j = j - 1;
                }
                productList[j + 1] = key;
            }
            return productList;
        }

        /// <summary>
        /// Retrieves the index of the specified category name in the provided category list.
        /// </summary>
        /// <param name="categoryName"></param>
        /// <param name="categoryList"></param>
        /// <returns>The index of the specified category name in the category list, or -1 if the category name is not found.</returns>
        public static int GetCategoryIndex(string categoryName, List<string> categoryList)
        {
            return categoryList.IndexOf(categoryName);
        }
    }
}
