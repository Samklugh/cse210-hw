using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public decimal CalculateTotalCost()
    {
        decimal total = 0m;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        total += _customer.IsInUSA() ? 5m : 35m;
        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder builder = new StringBuilder();

        foreach (Product product in _products)
        {
            builder.AppendLine($"{product.GetName()} (ID: {product.GetProductId()})");
        }

        return builder.ToString().TrimEnd();
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
