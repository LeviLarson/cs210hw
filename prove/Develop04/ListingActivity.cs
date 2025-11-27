using System;

class ListingActivity : Activity{

        public void HandleListing(){


        Start();

        Random rand = new Random();
        Console.WriteLine("\nThink if as many responses as you can to the follwing prompt: ");
        Console.WriteLine($"\n{_prompt[rand.Next(_prompt.Count())]}");

        Console.WriteLine("\nYou may begin in...");
        Countdown(5);

        List<string> items = new List<string>{};
        DateTime end = DateTime.Now.AddSeconds(GetDuration());
        while(DateTime.Now < end){
            Console.Write("> ");
            if(Console.KeyAvailable)
            {
                string item = Console.ReadLine();
                if(!string.IsNullOrWhiteSpace(item)){
                    items.Add(item);
                }
            }

            Console.WriteLine($"You listed {items.Count()} items!");

            End();
        }
    }

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."){}
        private List<string> _prompt = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };
        }