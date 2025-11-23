using System;

public class Scripture{

    private Reference _reference;

    private List<Word> _words;

    public Scripture(Reference reference, string text){

        _reference = reference;

        _words = text.Split(' ').Select(word => new Word(word)).ToList(); // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
 
    }

    public string GetDisplayText(){
        string joinedWords = "";

        foreach(Word word in _words){
                joinedWords = joinedWords + " " + word;
        }

        return joinedWords;
        
    }

    public void HideRandomWords(int count){
        var visibleWords = new List<Word>();

        foreach (var word in _words){

            // finds all visible words and puts them in a temp list
            if (!word.IsHidden()){
                visibleWords.Add(word);
            }
            for (int i = 0; i < count && visibleWords.Count > 0; i++){
                //gets random word from visible list
                new _random random;
                int index = random.Next(visibleWords.Count);
                //hides random word
                visibleWords[index].Hide();
                //removes word from temporary list
                visibleWords.RemoveAt(index);
            }
            
        }

    }

}