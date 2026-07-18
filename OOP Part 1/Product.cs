using System;

namespace OOP_Part_1
{
    internal class Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product(string productID, string productName, double price)
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
        }

        public void UpdatePrice(double newPrice)
        {
            if (newPrice > 0)
            {
                Price = newPrice;
                Console.WriteLine("Price updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid price.");
            }
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine("Product ID: " + ProductID);
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: OMR " + Price);
        }
    }
}