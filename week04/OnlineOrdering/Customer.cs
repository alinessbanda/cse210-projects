using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetDisplayString()
    {
        return $"{_name}\n{_address.GetDisplayString()}";
    }

    public Address GetAddress()
    {
        return _address;
    }
}