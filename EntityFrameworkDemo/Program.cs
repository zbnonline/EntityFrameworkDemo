using System;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // GetAll();

        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();

            foreach (var product in northwindContext.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void GetByCategoryId(int categoryId)
        {

        }
    }
}
