using System;

class Program
{
     static void Main()
    {
       
        var usaAddress = new Address("123 Main St", "Anytown", "CA", "USA");
        var nonUsaAddress = new Address("456 High St", "Winnepeg", "Province", "Canada");

        
        var usaCustomer = new Customer("John Doe", usaAddress);
        var nonUsaCustomer = new Customer("Brother Heyes", nonUsaAddress);

        
        var product1 = new Product("Laptop", 101, 800, 2);
        var product2 = new Product("Mouse", 102, 20, 3);

      
        var order1 = new Order(new List<Product> { product1, product2 }, usaCustomer);
        var order2 = new Order(new List<Product> { product2 }, nonUsaCustomer);

        
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice():F2}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice():F2}\n");
    }
}