using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thuat_Toan.Bai1Alogithms.entity;

namespace Thuat_Toan.Bai1Alogithms
{
    internal class Database
    {
        public string GetDataByName()
        {
            Console.WriteLine("Please enter data");
            var productNameToFind = Console.ReadLine();
            return productNameToFind;
        }

        public int GetDataByCategoryId()
        {
            Console.WriteLine("Please enter data");
            var productNameToFind = Convert.ToInt32(Console.ReadLine());
            return productNameToFind;
        }

        public double GetDataByPrice()
        {
            Console.WriteLine("Please enter data");
            var productNameToFind = Double.Parse(Console.ReadLine());
            return productNameToFind;
        }

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

        public Product FindProductByPrice(List<Product> productList, double price)
        {
            foreach (Product product in productList)
            {
                if (product.Price == price)
                {
                    return product;
                }
            }
            return null;
        }
    }

}
