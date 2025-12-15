using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment("Levi Larson", "Great Video!");
        Comment comment2 = new Comment("Levi Larson", "I found this very entertaining!");
        Comment comment3 = new Comment("John Doe", "Great visiuals");
        Comment comment4 = new Comment("John Greg", "Building great designs");
        List<Comment> comments1 = new List<Comment>{comment1, comment2, comment3, comment4};
        Video video1 = new Video("My Home PC", "Levi Larson", 27, comments1);

        Comment comment5 = new Comment("Levi Larson", "Great Video!");
        Comment comment6 = new Comment("Levi Larson", "I found this very entertaining!");
        Comment comment7 = new Comment("John Doe", "Great visiuals");
        Comment comment8 = new Comment("John Greg", "Building great designs");
        List<Comment> comments2 = new List<Comment>{comment5, comment6, comment7, comment8};
        Video video2 = new Video("My Home PC", "Levi Larson", 27, comments2);

        Comment comment9 = new Comment("Levi Larson", "Great Video!");
        Comment comment10 = new Comment("Levi Larson", "I found this very entertaining!");
        Comment comment11 = new Comment("John Doe", "Great visiuals");
        Comment comment12 = new Comment("John Greg", "Building great designs");
        List<Comment> comments3 = new List<Comment>{comment9, comment10, comment11, comment12};
        Video video3 = new Video("My Home PC", "Levi Larson", 27, comments3);
        


        Console.WriteLine(video1.GetTitle());
        Console.WriteLine(video1.GetAuthor());
        Console.WriteLine($"Number of Comments: {video1.CountComments()}");
        video1.DisplayComments();

        Console.WriteLine();

        Console.WriteLine(video2.GetTitle());
        Console.WriteLine(video2.GetAuthor());
        Console.WriteLine($"Number of Comments: {video2.CountComments()}");
        video2.DisplayComments();

        Console.WriteLine();

        Console.WriteLine(video3.GetTitle());
        Console.WriteLine(video3.GetAuthor());
        Console.WriteLine($"Number of Comments: {video3.CountComments()}");
        video3.DisplayComments();


    }
}