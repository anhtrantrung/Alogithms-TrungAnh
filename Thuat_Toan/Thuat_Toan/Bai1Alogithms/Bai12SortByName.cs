using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thuat_Toan.Bai1Alogithms.entity;

namespace Thuat_Toan.Bai1Alogithms
{
    internal class Bai12SortByName
    {
        /// <summary>
        /// Sorts the given list of Product objects by their names' lengths in descending order using the insertion sort algorithm.
        /// </summary>
        /// <param name="productList"></param>
        /// <returns>A sorted list of Product objects by their names' lengths in descending order.</returns>
        public List<Product> SortByName(List<Product> productList)
        {
            for (int i = 1; i < productList.Count; i++)
            {
                Product key = productList[i];
                int j = i - 1;
                while (j >= 0 && productList[j].Name.Length < key.Name.Length)
                {
                    productList[j + 1] = productList[j];
                    j = j - 1;
                }
                productList[j + 1] = key;
            }
            return productList;
        }
    }
}
