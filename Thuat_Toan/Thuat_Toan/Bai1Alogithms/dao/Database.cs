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

        public List<string> FindProductByPrice(List<Product> productList, double price)
        {
            List<string> productsWithinPrice = new List<string>();
            foreach (Product product in productList)
            {
                if (product.Price <= price)
                {
                    productsWithinPrice.Add(product.Name);
                }
            }
            return productsWithinPrice;
        }

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

        public static List<Product> SortByCategoryName(List<Product> listProduct, List<Category> listCategory)
        {
            // Tạo một từ điển để ánh xạ ID loại sản phẩm với tên loại sản phẩm tương ứng
            Dictionary<int, string> categoryNames = new Dictionary<int, string>();
            foreach (var category in listCategory)
            {
                categoryNames.Add(category.Id, category.Name);
            }

            // Tạo một danh sách mới để lưu trữ các sản phẩm đã được sắp xếp
            List<Product> sortedList = new List<Product>();

            // Lặp qua từng loại sản phẩm và thêm các sản phẩm của loại đó vào danh sách đã sắp xếp
            foreach (var category in listCategory)
            {
                foreach (var product in listProduct)
                {
                    if (product.CategoryId == category.Id)
                    {
                        sortedList.Add(product);
                    }
                }
            }

            var sortedProducts = listProduct.OrderBy(p => categoryNames[p.CategoryId]);
            return sortedList;
        }

        public Dictionary<int, string> CreateMapCategory(List<string> categoryList)
        {
            Dictionary<int, string> mapCategory = new Dictionary<int, string>();

            for (int i = 0; i < categoryList.Count; i++)
            {
                mapCategory[i + 1] = categoryList[i]; 
            }
            return mapCategory;
        }

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

            public double CalculateSalaryRecursive(double salary, int n)
        {
            if (n == 1)
            {
                return salary;
            }
            else
            {
                return CalculateSalaryRecursive(salary * 1.1, n - 1);
            }
        }

        public double CalculateSalary(double salary, int n)
        {
            for (int i = 1; i < n; i++)
            {
                salary *= 1.1;     
            }
            return salary;
        }

        public int CalMonthNoRecursive(double money, double rate)
        {
            double target = money * 2; 
            int months = 0;

            while (money < target)
            {
                money += money * rate / 100; 
                months++; 
            }

            return months;
        }

        public int CalMonthRecursive(double money, double rate, double target)
        {
            if (money >= target)
            {
                return 0; 
            }
            else
            {
                double total = money + money * rate / 100;
                return 1 + CalMonthRecursive(total, rate, target);
            }
        }

        public int CalMonth(double money, double rate)
        {
            double target = money * 2;
            return CalMonthRecursive(money, rate, target);
        }

        public void PrintMenu(List<MenuItem> menus, string prefix = "")
        {
            foreach (var menu in menus)
            {
                Console.WriteLine($"{prefix}{menu.Name}");
                PrintMenu(menu.SubMenuItems, prefix + "--");
            }
        }
    }
}
