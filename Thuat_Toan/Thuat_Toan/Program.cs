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
        private List<Product> productList;
        Database database = new Database();
        Bai24Queu<int> bai24Queu = new Bai24Queu<int>();
        Bai25Stack<int> Bai25Stack = new Bai25Stack<int>();

        public Program()
        {
            productList = new List<Product>();
            productList.Add(new Product("CPU", 750, 10, 1));
            productList.Add(new Product("RAM", 50, 2, 2));
            productList.Add(new Product("HDD", 70, 1, 2));
            productList.Add(new Product("Main", 400, 3, 1));
            productList.Add(new Product("Keyboard", 30, 8, 4));
            productList.Add(new Product("Mouse", 25, 50, 4));
            productList.Add(new Product("VGA", 60, 35, 3));
            productList.Add(new Product("Monitor", 120, 28, 2));
            productList.Add(new Product("Case", 120, 28, 5));
        }

       
        static void Main(string[] args)
        {
            Program program = new Program();

            //program.CheckOutputData();
            //program.TestB6();
            //program.TestB11();
            //program.TestB12();
            //program.TestB13();
            //program.TestB14();
            //program.TestB15();
            //program.TestB16();
            //program.TestB21();
            //program.TestB22();
            program.TestB23();
            //program.TestB24();
            //program.TestB25();


        }
        public void TestB4()
        {
            var productNameToFind = database.GetDataByName();
            Product foundProduct = database.FindProductByName(productList, productNameToFind);

            //var productNameToFind = database.GetDataByCategoryId();
            //Product foundProduct = database.FindProductByCategoryId(productList, productNameToFind);

            if (foundProduct != null)
            {
                Console.WriteLine(foundProduct.Name+ " " + foundProduct.Price + " " + foundProduct.Quality + " " + foundProduct.CategoryId);
            }
            else
            {
                Console.WriteLine("No data found");
            }
        }

        public void TestB6()
        {
            var priceToFind = database.GetDataByPrice();
            List<string> productsWithinPrice = database.FindProductByPrice(productList, priceToFind);
            Console.WriteLine("Products with a price less than or equal to {priceToFind}:");
            foreach (string productName in productsWithinPrice)
            {
                Console.WriteLine(productName);
            }
        }

        public void TestB11()
        {
            productList = database.SortByPrice(productList);
            Console.WriteLine("List of products sorted by price from low to high:");
            foreach (Product product in productList)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Quality: {product.Quality}, ICategoryId: {product.CategoryId}");
            }
        }

        public void TestB12()
        {
            productList = database.SortByName(productList);
            Console.WriteLine("Product list after sorting by name length from highest to lowest:");
            foreach (Product product in productList)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Quality: {product.Quality}, ICategoryId: {product.CategoryId}");
            }
        }

        public void TestB13()
        {
            List<string> categoryList = new List<string> { "CPU", "Case", "HDD", "Keyboard", "Main", "Monitor", "Mouse", "RAM", "VGA" };
            productList = database.SortByCategoryName(productList, categoryList);
            Console.WriteLine("Product list after sorting by category name alphabetically:");
            foreach (Product product in productList)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Quality: {product.Quality}, ICategoryId: {product.CategoryId}");
            }
        }

        public void TestB14()
        {
            List<string> categoryList = new List<string> { "Comuter", "Memory", "Card", "Acsesory", "Null" };
            List<(Product, string)> mappedProducts = database.MapProductByCategory(productList, categoryList);
            Console.WriteLine("List of products and corresponding categories:");
            foreach ((Product product, string categoryName) in mappedProducts)
            {            
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Quality: {product.Quality}, ICategoryId: {product.CategoryId}, category: {categoryName}");
            }
        }

        public void TestB15()
        {
            Product minProduct = database.MinByPrice(productList);
            if (minProduct != null)
            {
                Console.WriteLine($"The product with the smallest price is: {minProduct.Name}, Price: {minProduct.Price}");
            }
            else
            {
                Console.WriteLine("There are no products in the list.");
            }
        }

        public void TestB16()
        {
            Product maxProduct = database.MaxByPrice(productList);
            if (maxProduct != null)
            {
                Console.WriteLine($"The product with the highest price is: {maxProduct.Name}, Price: {maxProduct.Price}");
            }
            else
            {
                Console.WriteLine("There are no products in the list.");
            }
        }

        public void TestB21()
        {
            double initialSalary = 1000;
            int year = 5;

            //double salary = database.CalculateSalaryRecursive(initialSalary, year);
            //Console.WriteLine($"Fifth salary {year} is: {salary}");

            double salary = database.CalculateSalary(initialSalary, year);
            Console.WriteLine($"Fifth salary {year} is: {salary}");
        }

        public void TestB22()
        {
            double money = 1000;
            double rate = 5;
            int months = database.CalMonth(money, rate);

            Console.WriteLine($"The number of months it takes for the principal and interest to double is: {months}");

            //int months = database.CalMonthNoRecursive(money, rate);
            //Console.WriteLine($"The number of months it takes for the principal and interest to double is: {months}");
        }

        public void TestB23()
        {
            MenuItem menu1 = new MenuItem("The Thao");
            MenuItem ttTrongNuoc = new MenuItem("The thaao trong nuoc");
            MenuItem ttNuocNgoai = new MenuItem("The thaao nuoc ngoai");
            menu1.AddSubMenu(ttTrongNuoc);
            menu1.AddSubMenu(ttNuocNgoai);

            MenuItem menu2 = new MenuItem("Xa Hoi");
            MenuItem giaoThong = new MenuItem("Giao thong");
            giaoThong.AddSubMenu(new MenuItem("Giao thong un tac"));          
            menu2.AddSubMenu(giaoThong);

            List<MenuItem> menus = new List<MenuItem> { menu1, menu2 };

            Console.WriteLine("Menu:");
            database.PrintMenu(menus);
        }

        public void TestB24()
        {
            bai24Queu.Push(1);
            bai24Queu.Push(2);
            bai24Queu.Push(3);

            Console.WriteLine("Prints the elements in first in, first out order");
            Console.WriteLine(bai24Queu.Get()); 
            Console.WriteLine(bai24Queu.Get()); 
            Console.WriteLine(bai24Queu.Get()); 

            Console.WriteLine("Add a new element and retrieve it");
            bai24Queu.Push(4);
            Console.WriteLine(bai24Queu.Get());

        }

        public void TestB25()
        {
            Bai25Stack.Push(1);
            Bai25Stack.Push(2);
            Bai25Stack.Push(3);

            Console.WriteLine("Prints the elements in last in, first out order");
            Console.WriteLine(Bai25Stack.Get()); 
            Console.WriteLine(Bai25Stack.Get());
            Console.WriteLine(Bai25Stack.Get()); 

            Console.WriteLine("Add a new element and retrieve it");
            Bai25Stack.Push(4);
            Console.WriteLine(Bai25Stack.Get()); 
        }
    }
}
