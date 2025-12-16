using System;

class Lecture : Event
{
    private string _speakerName;
    public string GetSpeaker()
    {
        return _speakerName;
    }
    private int _capacity;
    public int GetCapacity()
    {
        return _capacity;
    }

    public Lecture(string speakerName, int capacity, string title, string description, string date, string time, Address address) : base()
    {
        _speakerName = speakerName;
        _capacity = capacity;
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
        Console.WriteLine("Speaker: "+ this.GetSpeaker());
        Console.WriteLine("Capacity: "+ this.GetCapacity());
    }

}