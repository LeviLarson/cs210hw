using System;

class  Activity
{
    private string _name;
    private string _description;
    private int _duration = 5;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetDuration(int seconds)
    {
        _duration = seconds;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public string GetName()
    {
        return _name;
    }

       public void Start()
    {
        Console.Clear();
        Console.WriteLine($"---{_name}---");
        Console.WriteLine(_description);
        Console.WriteLine("\nEnter duration in seconds: ");
        SetDuration(int.Parse(Console.ReadLine()));

        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3);
    }

    public void End()
    {
        Console.Clear();
        Console.WriteLine("Thank you for participating in the" + _name);
        ShowSpinner(2);
        Console.WriteLine($"\nYou participated in the {_name} for {_duration}");
    }

    public void ShowSpinner(int seconds)
    {
        string[] frames = {"|", "/", "-", "\\"};
        DateTime end = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while(DateTime.Now < end)
        {
            Console.Write(frames[i % frames.Length]);
            Thread.Sleep(200);
            Console.WriteLine("\b");
            i++;
        }   
    }
    
    public void Countdown(int seconds)
    {
        for(int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }

        Console.WriteLine();

    }

    public void Run()
    {
       ShowSpinner(4);
    }
}