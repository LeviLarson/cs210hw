using System;

class Event
{
    private string _title;
    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string text)
    {
        _title = text;
    }
    private string _description;
    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string text)
    {
        _description = text;
    }
    private string _date;
    public string GetDate()
    {
        return _date;
    }

    public void SetDate(string text)
    {
        _date = text;
    }
    private string _time;
    public string GetTime()
    {
        return _time;
    }
    public void SetTime(string text)
    {
        _time = text;
    }

    private Address _address;
    public Address GetAddress()
    {
        return _address;
    }

    public void SetAddress(Address temp)
    {
        _address = temp;
    }

    public void StandardDetails()
    {
        Console.WriteLine("Title: "+this.GetTitle());
        Console.WriteLine(this.GetDescription());
        Console.WriteLine("Date: "+ this.GetDate());
        Console.WriteLine("Time: "+  this.GetTime());
        Address temp = this.GetAddress();
        Console.WriteLine($"Address: \n{temp.GetStreet()} \n{temp.GetCity()}, {temp.GetState()}, {temp.GetCountry()}");
    }

    public void ShortDescription()
    {
        Console.WriteLine("Event Type: " + this.GetType());
        Console.WriteLine("Title: "+this.GetTitle());
        Console.WriteLine("Date:"+ this.GetDate());
    }


}