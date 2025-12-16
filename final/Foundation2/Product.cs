using System;

class Product
{
    private string _name;
    public string GetName()
    {
        return _name;
    }


    private int _productID;
    public int GetProductID()
    {
        return _productID;
    }


    private double _price;
    public double GetPrice()
    {
        return _price;
    }


    private int _quantity;
    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity(int newQuantity)
    {
     _quantity = newQuantity;   
    }

    public Product(string name, int productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

}