using System;
using System.Collections.Generic;


namespace FirstProblem
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Decleration of Object and Variables

            List<Product> products = new List<Product>();
            ProductType productTypes = new ProductType();
            Calculate calculate = new Calculate();
            Product productAssign = new Product();

            #endregion

            #region Taking User input and Assigning the Product with Prices

            Console.WriteLine("Please Enter total number of orders");
            int totalNumberOfOrders = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < totalNumberOfOrders; i++)
            {
                Console.WriteLine("Enter the variation/Type of products like :A,B,C or D");
                string type = Console.ReadLine();
                productAssign = productTypes.GetProductType(type);
                products.Add(productAssign);
            }

            #endregion

            #region Action Methods 

            int totalPrice = calculate.GetTotalPrice(products);

            #endregion

            #region Display the Calculated Data to the User

            Console.WriteLine(totalPrice);
            Console.ReadLine();

            #endregion

        }

    }

}
