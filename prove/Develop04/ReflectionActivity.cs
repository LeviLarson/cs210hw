using System;
using System.Random;

class ReflectionActivity : Activity{

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") {
        private List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> _followUp = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void HandleReflection(){
        Start();
        Random rand = new Random();
        Console.WriteLine("\nConsider the following prompt: \n");
        // gets a random prompt by counting the length of the 
        Console.WriteLine($"{_prompts[rand.Next(_prompts.Count())]}");
        Console.WriteLine("When you are ready to move on, press enter.")
        Console.ReadLine();

        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while(DateTime.Now < end){
            string f = _followUp[rand.Next(_followUp.Counnt())];
            Console.WriteLine("\n" + f);
            ShowSpinner(5);

            End();
        }
    }



}