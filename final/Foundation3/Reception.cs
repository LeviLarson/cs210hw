using System;

class Reception : Event
{
    private string _rsvpEmail;
    public string GetRSVP()
    {
        return _rsvpEmail;
    }

    public void SetRSVP(string mail)
    {
        _rsvpEmail = mail;
    }

        public Reception(string mail, string title, string description, string date, string time, Address address) : base()
    {
        _rsvpEmail = mail;
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
        Console.WriteLine("Event Type"+ this.GetType());
        Console.WriteLine("RSVP at: "+ this.GetRSVP());
    }
}