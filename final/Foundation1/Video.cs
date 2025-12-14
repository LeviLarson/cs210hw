using System;

class Video
{
    
    private string _title {get; set;}
    private string _author {get; set;}
    private int _length {get; set;}
    private List<Comment> _comments {get; set;}

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

    public void DisplayVideo()
    {
        
    }
}