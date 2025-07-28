using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Address and customer 1
        Address address1 = new Address("H5 Riverstone", "Lagos", "Lagos", "Nigeria");
        Customer customer1 = new Customer("Iyanu", address1);

        //Products for order1
        Product product1 = new Product("Tooth Brush", "TB01", 500, 1);
        Product product2 = new Product("Comb", "CO01", 200, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: #{order1.GetTotalPrice()}.00\n");

        //Address and customer2
        Address address2 = new Address("L78 Sunshine Garden", "Oba-Ile", "Ondo", "Nigeria");
        Customer customer2 = new Customer("Emmanuel", address2);

        //Products for order2
        Product product3 = new Product("Body Cream", "BD01", 1000, 3);
        Product product4 = new Product("Hair Cream", "HC01", 1500, 2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: #{order2.GetTotalPrice()}.00\n");


    }
}