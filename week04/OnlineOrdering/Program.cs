using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address("742 Evergreen Terrace", "Springfield", "IL", "USA");
        Address internationalAddress = new Address("88 Stratford High Street", "East London", "London", "United Kingdom");

        Customer customerOne = new Customer("Avery Johnson", usaAddress);
        Customer customerTwo = new Customer("Chinedu Okoye", internationalAddress);

        List<Product> orderOneProducts = new List<Product>
        {
            new Product("Wireless Mouse", "WM-204", 24.99m, 2),
            new Product("Mechanical Keyboard", "MK-510", 89.50m, 1),
            new Product("USB-C Cable", "UC-018", 7.25m, 3),
        };

        List<Product> orderTwoProducts = new List<Product>
        {
            new Product("PlayStation 5 Console", "PS5-001", 499.99m, 1),
        };

        List<Order> orders = new List<Order>
        {
            new Order(customerOne, orderOneProducts),
            new Order(customerTwo, orderTwoProducts),
        };

        int orderNumber = 1;

        foreach (Order order in orders)
        {
            Console.WriteLine($"Order {orderNumber}");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Total Price: ${order.CalculateTotalCost():0.00}");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine();
            orderNumber++;
        }
    }
}
