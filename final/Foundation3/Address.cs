using System;

class Address
{
    private string _street;
    public string GetStreet()
    {
        return _street;
    }
    private string _city;
    public string GetCity()
    {
        return _city;
    }   
     private string _state;

     public string GetState()
    {
        return _state;
    }
    private string _country;
    public string GetCountry()
    {
        return _country;
    }

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsUSACitizen()
    {
        return (_country == "USA");
    }
}