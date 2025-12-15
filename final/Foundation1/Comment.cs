using System;

class Comment{

    private string _name;

    public string GetName()
    {
        return _name;
    }

    private string _text;

    public string GetText()
    {
     return _text;   
    }

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

}