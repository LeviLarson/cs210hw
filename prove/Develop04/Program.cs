using System;

class Program
{
    static void Main(string[] args)
    {
        while(true){
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.WriteLine("\nSelect Choice: ");
            string choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                activity = new BreathingActivity();
                break;
                case "2":
                activity = new ReflectionActivity();
                break;
                case "3":
                activty = new ListingActivity();
                case "4":
                return;
                default:
                Console.WriteLine("Invalid Choice. Press Enter.");
                Console.ReadLine();
                continue;
            }
            activity.Run();
        }
    }
}