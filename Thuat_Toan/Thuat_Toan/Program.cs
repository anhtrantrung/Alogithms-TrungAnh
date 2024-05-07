using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Thuat_Toan.Bai1Alogithms.Database;
using Thuat_Toan.Bai1Alogithms;
using Thuat_Toan.Bai1Alogithms.entity;

namespace Thuat_Toan
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Database database = new Database();
            List<Product> productList = new List<Product>();
            productList.Add(new Product("CPU", 750, 10, 1));
            productList.Add(new Product("GPU", 1000, 5, 2));
            productList.Add(new Product("RAM", 150, 20, 3));

            //var productNameToFind = database.GetDataByName();
            //Product foundProduct = database.FindProductByName(productList, productNameToFind);

            var productNameToFind = database.GetDataByCategoryId();
            Product foundProduct = database.FindProductByCategoryId(productList, productNameToFind);

            //var productNameToFind = database.GetDataByPrice();
            //Product foundProduct = database.FindProductByPrice(productList, productNameToFind);

            if (foundProduct != null)
            {
                Console.WriteLine(foundProduct.Name+ " " + foundProduct.Price + " " + foundProduct.Quality + " " + foundProduct.CategoryId);
            }
            else
            {
                Console.WriteLine("No data found");
            }
        }


    }
}
