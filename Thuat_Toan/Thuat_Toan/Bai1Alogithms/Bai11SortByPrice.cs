using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thuat_Toan.Bai1Alogithms.entity;

namespace Thuat_Toan.Bai1Alogithms
{
    internal class Bai11SortByPrice
    {
        /// <summary>
        /// Sorts the given list of Product objects by their prices in ascending order using the bubble sort algorithm.
        /// </summary>
        /// <param name="productList"></param>
        /// <returns>A sorted list of Product objects by their prices in ascending order.</returns>
        public List<Product> SortByPrice(List<Product> productList)
        {
            int n = productList.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (productList[j].Price > productList[j + 1].Price)
                    {
                        Product temp = productList[j];
                        productList[j] = productList[j + 1];
                        productList[j + 1] = temp;
                    }
                }
            }
            return productList;
        }
    }
}
