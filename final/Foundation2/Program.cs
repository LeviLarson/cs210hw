using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Seasame Street", "Pittsburgh", "PA", "USA");

        Address address2 = new Address("1234 Other Road", "Pachuca", "Hidalgo", "Mexico");

        Customer customer1 = new Customer("Mr. Boss", address1);

        Customer customer2 = new Customer("Other Guy", address2);

        Product table = new Product("Table", 1, 24.99, 5);

        Product chair = new Product("Chair", 2, 15.99, 25);

        Product cushion = new Product("Cushion", 3, 8.50, 25);

        List<Product> list1 = new List<Product> {chair, cushion, table, chair};

        List<Product> list2 = new List<Product> {table, chair, chair, chair};

        Order order1 = new Order(list1, customer1);

        Order order2 = new Order(list2, customer2);

        Console.WriteLine("\nOrder 1\n");

        Console.WriteLine(order1.TotalCost());
        order1.PackingLabel();
        order1.ShippingLabel();

        Console.WriteLine("\nOrder2\n");

        Console.WriteLine(order2.TotalCost());
        order2.PackingLabel();
        order2.ShippingLabel();

    }
}