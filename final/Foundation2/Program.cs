using System;

class Program
{
    static void Main()
    {

        Address a1 = new Address("123 Main St", "Phoenix", "AZ", "USA");
        Customer c1 = new Customer("John Smith", a1);

        Order o1 = new Order(c1);
        o1.AddProduct(new Product("Laptop", "L123", 999.99, 1));
        o1.AddProduct(new Product("Mouse", "M456", 25.50, 2));

        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${o1.GetTotalCost()}\n");

        Address a2 = new Address("42 Maple Road", "Toronto", "ON", "Canada");
        Customer c2 = new Customer("Emily Johnson", a2);

        Order o2 = new Order(c2);
        o2.AddProduct(new Product("Headphones", "H111", 85.75, 1));
        o2.AddProduct(new Product("Microphone", "M222", 120.00, 1));
        o2.AddProduct(new Product("USB Cable", "U333", 8.99, 3));

        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${o2.GetTotalCost()}\n");
    }
}
