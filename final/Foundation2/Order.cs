using System;

class Order
{
    private List<Product> _products {get; set;}
    private Customer _customer {get; set;}

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }



    public double TotalCost()
    {
        double temp = 0.0;
        foreach(Product product in _products)
            {
                temp += product.GetPrice();
                product.SetQuantity(product.GetQuantity() - 1);
            }

        if (_customer.GetAddress().IsUSACitizen())
        {
            return temp + 5;
        }

        else
        {
            return temp + 35;
        }
    }

    public void PackingLabel()
    {
        foreach(Product product in _products)
        {
            Console.WriteLine($"{product.GetName()} - ID:{product.GetProductID()}");
        }
    }

    public void ShippingLabel()
    {

        Address temp = _customer.GetAddress();
      Console.WriteLine(_customer.GetName());
        Console.WriteLine($"{temp.GetStreet()} \n{temp.GetCity()}, {temp.GetState()}, {temp.GetCountry()}");

    }
}