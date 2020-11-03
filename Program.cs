using System;
using System.Collections.Generic;
using System.Linq;
using PromotionEngine;
namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total Number of Products");
            int a = Convert.ToInt32(Console.ReadLine());
            Cart cart = new Cart();

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter the Type of products:A,B,C or D");
                string type = Console.ReadLine();
                Product p = new Product(type);
                cart.AddProduct(p);
            }
           
            int totalPrice = cart.GetPrice();
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }

    }
}
