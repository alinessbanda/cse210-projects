using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 101, 1200, 1));
        order1.AddProduct(new Product("Mouse", 102, 25, 2));

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetDisplayString());
        Console.WriteLine();

        Payment payment1 = new Payment(1, order1.CalculateOrderTotal(), DateTime.Now, "TXN12345");
        payment1.MarkAsPaid();
        Console.WriteLine("Payment 1:");
        Console.WriteLine(payment1.GetDisplayString());

        Console.WriteLine("\n-----------------------------------\n");

        Address address2 = new Address("45 King St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Johnson", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Tablet", 201, 300, 1));
        order2.AddProduct(new Product("Keyboard", 202, 45, 1));

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetDisplayString());
        Console.WriteLine();

        Payment payment2 = new Payment(2, order2.CalculateOrderTotal(), DateTime.Now, "TXN67890");
        payment2.MarkAsPaid();
        Console.WriteLine("Payment 2:");
        Console.WriteLine(payment2.GetDisplayString());

    }
}