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

     return 0;   
    }

    public string PackingLabel()
    {
        return"";
    }

    public string ShippingLabel()
    {
     return "";   
    }
}