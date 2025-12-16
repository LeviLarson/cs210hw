using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Seasame Street", "Pittsburgh", "PA", "USA");

        Address address2 = new Address("1234 Other Road", "Pachuca", "Hidalgo", "Mexico");

        Lecture lecture = new Lecture("Levi Larson", 23, "ORT", "This event will be about Competitive Ostritch Race Theory", "May 12, 2030", "12:00 AM", address1);

        lecture.StandardDetails();
        Console.WriteLine();
        lecture.FullDetails();
        Console.WriteLine();
        lecture.ShortDescription();

        Reception reception = new Reception("lar22023@byui.edu", "ORT", "This event will be about Competitive Ostritch Race Theory", "May 12, 2030", "12:00 AM", address2);

        reception.StandardDetails();
        Console.WriteLine();
        reception.FullDetails();
        Console.WriteLine();
        reception.ShortDescription();

        OutdoorGathering gathering = new OutdoorGathering("Slightly Cloudy", "ORT", "This event will be about Competitive Ostritch Race Theory", "May 12, 2030", "12:00 AM", address2);

        gathering.StandardDetails();
        Console.WriteLine();
        gathering.FullDetails();
        Console.WriteLine();
        gathering.ShortDescription();
    }
}