using System;

class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string speakerName, int capacity) : base()
    {
        _speakerName = speakerName;
        _capacity = capacity;

    }

    public void FullDetails()
    {
        Console.WriteLine();
    }

    public void ShortDescription()
    {
        Console.WriteLine();
    }


}