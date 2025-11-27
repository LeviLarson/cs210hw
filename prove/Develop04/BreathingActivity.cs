using System;

class BreathingActivity : Activity
{

    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing. Suggested time is around 30 seconds.")
    {
        
    }
    public void HandleBreathing()
    {
        Start();

        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while(DateTime.Now < end)
        {
            Console.Write("\nBreathe in... ");
            Countdown(3);
            Console.WriteLine("\nBreathe out...");
            Countdown(3);
        }
        
        End();
    }
}