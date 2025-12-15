using System;

class Video
{
    
    public string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public int CountComments()
    {
        //iterate through all of the comments and return temporary variable
        int temp = 0;
        foreach(Comment comment in _comments)
        {
            temp++;
        }
        return temp;
    }

    public void DisplayComments()
    {
        foreach(Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
        }
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
     return _author;   
    }

    public int GetLength()
    {
     return _length;   
    }

}