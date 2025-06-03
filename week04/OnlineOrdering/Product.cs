using System;

public class Product
{
    private string _name;
    private int _productId;
    private int _price;
    private int _quantity;

    public Product(string name, int productId, int price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public int CalculateTotalCost()
    {
        return _price * _quantity;
    }

    public string GetDisplayString()
    {
        return $"{_name} (ID: {_productId} - ${_price} x {_quantity} = ${CalculateTotalCost()})";
    }
}