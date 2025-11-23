using System;

public class Reference{

    private string _book;

    private int _chapter;

    private int _verse;

    private int? _endVerse; //https://stackoverflow.com/questions/6967700/why-int-cant-be-null-how-does-nullable-int-int-work-in-c


    public Reference(string book, int chapter, int verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null;
    }

    public Reference(string book, int chapter, int verse, int endVerse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText(){

        if (_endVerse == null){
        return $"{_book} {_chapter}:{_verse}";
        }

        else{
        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }

}