using System;

class Program
{

    private static Scripture scripture;

    private static Reference reference;

    public void SetReference(){

        Console.WriteLine("Book:");
        string book = Console.ReadLine();
        Console.WriteLine("Chapter:");
        int chapter = int.Parse(Console.ReadLine());
        Console.WriteLine("Starting Verse:");
        int verse = int.Parse(Console.ReadLine());
        Console.WriteLine("Ending Verse(if none ENTER):");
        int? endverse = int.Parse(Console.ReadLine());

        if(endverse != null){
            reference = Reference(book, chapter, verse, endverse);
        }
        else{
            reference = Reference(book, chapter, verse);
        }
    }

    static void Main(string[] args)
    {
              while (true)
        {
            Console.WriteLine("\nScripture Memorizer:");
            Console.WriteLine("1. Add/Change Scripture");
            Console.WriteLine("2. Start Memorizing");
            Console.WriteLine("3. Quit");
            Console.Write("Choose an option (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Reference:")
                    Console.ReadLine();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    journal.SaveToFile(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    journal.LoadFromFile(Console.ReadLine());
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.\n");
                    break;
            }

    
        }
    }
}