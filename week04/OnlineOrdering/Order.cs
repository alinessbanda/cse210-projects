using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _productList;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _productList = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }

    public int CalculateOrderTotal()
    {
        int total = 0;
        foreach (var product in _productList)
        {
            total += product.CalculateTotalCost();
        }

        int shipping = _customer.IsInUSA() ? 5 : 35;
        return total + shipping;
    }

    public string GetPackingLabelString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Packing Label:");
        foreach (var product in _productList)
        {
            sb.AppendLine(product.GetDisplayString());
        }
        return sb.ToString();
    }

    public string GetShippingLabelString()
    {
        return $"Shipping Label:\n{_customer.GetDisplayString()}";
    }

    public string GetDisplayString()
    {
        return $"{GetPackingLabelString()}\n{GetShippingLabelString()}\nTotal Cost: ${CalculateOrderTotal()}";
    }

}