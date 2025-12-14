using System;

class Product
{
    private string _name {get; set;}
    private int _productID {get; set;}
    private double _price {get; set;}
    private int _quantity {get; set;}

    Product(string name, int productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

}