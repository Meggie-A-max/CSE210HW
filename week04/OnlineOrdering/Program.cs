using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "123 Main Street", "New York", "NY", "USA");

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P001", 750.00m, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25.00m, 2));

        Address address2 = new Address(
            "15 Allen Avenue", "Ikeja", "Lagos", "Nigeria");

        Customer customer2 = new Customer("Mary Johnson", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Keyboard", "P003", 40.00m, 1));
        order2.AddProduct(new Product("Monitor", "P004", 200.00m, 2));

        List<Order> orders = new List<Order> { order1, order2 };

        int orderNumber = 1;

        foreach (Order order in orders)
        {
            Console.WriteLine($"ORDER {orderNumber}");
            Console.WriteLine("--------------------");

            Console.WriteLine("PACKING LABEL:");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("SHIPPING LABEL:");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine($"TOTAL COST: ${order.GetTotalCost():F2}");

            Console.WriteLine();
            orderNumber++;
        }
    }
}