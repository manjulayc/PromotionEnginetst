using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;

namespace UnitTestProject2
{
    [TestClass]
    public class CartUnittest
    {
        Cart cart;

        [TestInitialize]
        public void Setup()
        {
            cart = new Cart();
        }

        [TestMethod]
        public void Product_Price_Returns_Empty_When_Type_Is_Empty()
        {
            //Arrange
            string type = "";
            decimal price = 0;
            Product p = new Product("");

            //Act
            cart.AddProduct(p);
            price = cart.GetPrice();
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
            cart.AddProduct(p);
            price = cart.GetPrice();
            //Assert
            Assert.AreEqual(price, 50);
        }

        [TestMethod]
        public void Product_TypeAAAB_Returns_160()
        {
            //Arrange
            decimal price = 0;
            Product A = new Product("A");
            Product A1 = new Product("A");
            Product A2 = new Product("A");
            Product B = new Product("B");

            //Act
            cart.AddProduct(A);
            cart.AddProduct(A1);
            cart.AddProduct(A2); 
            cart.AddProduct(B);
            price = cart.GetPrice();

            //Assert
            Assert.AreEqual(price, 160);
        }

        [TestMethod]
        public void Product_TypeABBB_Returns_125()
        {
            //Arrange
            decimal price = 0;
            Product A = new Product("A");
            Product A1 = new Product("B");
            Product A2 = new Product("B");
            Product B = new Product("B");

            //Act
            cart.AddProduct(A);
            cart.AddProduct(A1);
            cart.AddProduct(A2);
            cart.AddProduct(B);
            price = cart.GetPrice();

            //Assert
            Assert.AreEqual(price, 125);
        }

        [TestMethod]
        public void Product_TypeABCD_Returns_110()
        {
            //Arrange
            decimal price = 0;
            Product A = new Product("A");
            Product A1 = new Product("B");
            Product A2 = new Product("C");
            Product B = new Product("D");

            //Act
            cart.AddProduct(A);
            cart.AddProduct(A1);
            cart.AddProduct(A2);
            cart.AddProduct(B);
            price = cart.GetPrice();

            //Assert
            Assert.AreEqual(price, 110);
        }

      
    }

}
