using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
        }

        private static void CategoryTest()
        {
            CategoryManager manager = new CategoryManager(new EfCategoryDal());

            foreach (var category in manager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager manager = new ProductManager(new EfProductDal());

            foreach (var item in manager.GetProductDetails().Data)
            {
                Console.WriteLine(item.ProductName.ToString());
            }
        }
    }
}
