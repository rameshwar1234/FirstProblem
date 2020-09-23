namespace FirstProblem
{
    public class ProductType
    {
        /// <summary>
        /// This Method for Get the Product ID and Assign the price of that.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Product object which have ID and Price</returns>
        /// 
        public Product GetProductType(string id)
        {
            Product product = new Product();
            product.Id = id;
            switch (id)
            {
                case "A":
                    product.Price = 50;

                    break;
                case "B":
                    product.Price = 30;

                    break;
                case "C":
                    product.Price = 20;

                    break;
                case "D":
                    product.Price = 15;
                    break;
            }

            return product;
        }
    }
}
