using System.Collections.Generic;
using FirstProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace FirstProblemTestProject
{
    [TestClass]
    public class Tests
    {

        [TestMethod]
        public void Test_ProductPrice()
        {
            //Arrange
            ProductType productType = new ProductType();
            Product product = new Product();
            string id = "A";
            int priceOfA = 50;

            //Act
            product = productType.GetProductType(id);

            //Assert
            Assert.IsNotNull(true);
            Assert.AreEqual(priceOfA, product.Price);

        }

        [TestMethod]
        public void Test_GetTotalPrice()
        {
            //Arrange
            Calculate calculate = new Calculate();
            List<Product> products = new List<Product>();
            var productA = new Product
            {
                Id = "A",
                Price = 50
            };

            var productE = new Product
            {
                Id = "A",
                Price = 50
            };

            var productF = new Product
            {
                Id = "A",
                Price = 50
            };

            var productB = new Product
            {
                Id = "B",
                Price = 30
            };

            var productC = new Product
            {
                Id = "C",
                Price = 20
            };

            var productD = new Product
            {
                Id = "A",
                Price = 15
            };


            products.Add(productA);
            products.Add(productE);
            products.Add(productF);
            products.Add(productB);
            products.Add(productC);
            products.Add(productD);

            int calculatedPrice = 205;


            //Act
            int totalPrice = calculate.GetTotalPrice(products);

            //Assert
            Assert.IsNotNull(true);
            Assert.AreEqual(totalPrice, calculatedPrice);

        }
    }
}