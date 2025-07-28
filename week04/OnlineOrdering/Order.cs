using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double GetTotalPrice()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        // Add shipping cost
        totalCost += _customer.LivesInUsa() ? 5 : 35;
        return totalCost;
    }
    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Parking Label");
        foreach (var product in _products)
        {
            sb.AppendLine($"{product.GetPackingInfo()}");

        }
        return sb.ToString();

    }
     public string GetShippingLabel()
        {
        return $"Shipping Label: {_customer.GetName()} \n{_customer.GetShippingAddress()}";
        }
}