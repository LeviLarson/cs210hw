using System;

class Program
{
    static void Main(string[] args)
    {
        while(true){
            Activity activity = new Activity("", "");
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.WriteLine("\nSelect Choice: ");
            string choice = Console.ReadLine();

                        
            switch (choice)
            {
                case "1":
                BreathingActivity BreathingActivity = new BreathingActivity();
                BreathingActivity.HandleBreathing();
                break;

                case "2":
                ReflectionActivity ReflectionActivity = new ReflectionActivity();
                ReflectionActivity.HandleReflection();
                break;

                case "3":
                ListingActivity ListingActivity = new ListingActivity();
                ListingActivity.HandleListing();
                break;

                case "4":
                return;
                
                default:
                Console.WriteLine("Invalid Choice. Press Enter.");
                Console.ReadLine();
                continue;
            }
            
        }
    }
}