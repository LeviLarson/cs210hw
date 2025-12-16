using System;

class Program
{
    static void Main(string[] args)
    {
        Cycling cycling = new Cycling(14, 60, "Nov 3 2025");
        Running running = new Running(10, "Sept 30 2025", 15);
        Swimming swimming = new Swimming("Oct 11 2025", 12, 20);

        List<Activity> list = new List<Activity> {cycling, running, swimming};

        foreach(Activity activity in list)
        {
            Console.WriteLine(activity.GetSummary() + "\n");
        }
    }
}