using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
namespace UnitTestProject2
{
    [TestClass]
    public class ProductUnitTest
    {
        [TestMethod]
        public void Product_Price_Returns_Empty_When_Type_Is_Empty()
        {
            //Arrange
            string type = "";
            decimal price = 0;
            Product p = new Product(type);

            //Act
            price = p.Price;

            //Assert
            Assert.AreEqual(price, 0);
            Assert.AreNotEqual(price, 30);
        }

        [TestMethod]
        public void Product_TypeA_Returns_Price_50()
        {
            //Arrange
            string type = "A";
            decimal price = 0;
            Product p = new Product(type);

            //Act
            price = p.Price;

            //Assert
            Assert.AreEqual(price, 50);
        }

        [TestMethod]
        public void Product_Typeb_smallcase_Returns_Price_0_()
        {
            //Arrange
            string type = "b";
            decimal price = 0;
            Product p = new Product(type);

            //Act
            price = p.Price;

            //Assert
            Assert.AreEqual(price, 0);
        }
    }
}
