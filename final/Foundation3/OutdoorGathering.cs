using System;

class OutdoorGathering : Event
{
    private string _forecast;
    public string GetForecast()
    {
        return _forecast;
    }
    
    public void SetForecast(string forecast)
    {
        _forecast = forecast;
    }
    public OutdoorGathering(string forecast, string title, string description, string date, string time, Address address) : base()
    {
        _forecast = forecast;
        this.SetTitle(title);
        this.SetDescription(description);
        this.SetDate(date);
        this.SetTime(time);
        this.SetAddress(address);

    }

    public void FullDetails()
    {
        Console.WriteLine("Title: "+ this.GetTitle());
        Console.WriteLine(this.GetDescription());
        Console.WriteLine("Date: "+ this.GetDate());
        Console.WriteLine("Time: "+  this.GetTime());
        Address temp = this.GetAddress();
        Console.WriteLine($"Address: \n{temp.GetStreet()} \n{temp.GetCity()}, {temp.GetState()}, {temp.GetCountry()}");
        Console.WriteLine("Event Type: "+ this.GetType());
        Console.WriteLine("Forecast: "+ this.GetForecast());
        Console.WriteLine("There is no Attendee Limit");
    }
}