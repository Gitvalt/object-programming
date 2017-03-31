using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava2_Shoppingcart
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating List for the products
            List<Product> product_list = new List<Product>();

            //Creating some products
            Product fish = new Product("Fish", 15.50);
            Product beer = new Product("Beer", 5.00);
            Product ice_cream = new Product("Fish", 2.00);
            Product bread = new Product("Fish", 1.50);

            product_list.Add(fish);
            product_list.Add(beer);
            product_list.Add(ice_cream);
            product_list.Add(bread);

            product_list.Add(new Product("testi", 50.00));


            Console.WriteLine("All products in collection:");
            foreach(Product product in product_list)
            {
                Console.WriteLine(product.ToString());
            }

            Console.WriteLine("\nPress enter key to continue...");
            Console.ReadLine();

        }
    }
}
