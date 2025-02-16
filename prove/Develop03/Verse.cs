using System.IO;
using System.Runtime.CompilerServices;
public class Verse{
    private List<Word> _words = new List<Word>();
    private List<int> _wordIndexes = new List<int>();
    private bool _isVerseHidden;

public Verse(){

}
    public Verse(string ver){
        string[] array = ver.Split(" ");
        foreach(String word in array){
            _words.Add(new Word(word));
        }
        for(int i = 0; i < _words.Count; i++){
            _wordIndexes.Add(i);
        }
    }

    public bool getHidden(){
        return _isVerseHidden;
    }
    public bool HideRandom(){
        if(_wordIndexes.Count == 0){
            _isVerseHidden = true;
        }
        if(_isVerseHidden == true){
            return false;
        }
        Random random = new Random();
        int word = _wordIndexes[random.Next(0, _wordIndexes.Count - 1)];
        bool success = _words[word].HideWord();
        if(success){
            _wordIndexes.Remove(word);
        }
        if(_wordIndexes.Count == 0){
            _isVerseHidden = true;
        }
        return success;
        
    }

    public string GetDisplay(){
        string finalStr = "";
        foreach(Word word in _words){
            finalStr += word.GetDisplay() + " ";
        }
        finalStr = FormatString(finalStr);
        return finalStr;
    }

    private string FormatString(string str){
        string subStr = "";
        if(str.Length <= 80){
            return str;
        }
        for(int i = 0; i < str.Length; i += 80){ //not gonna lie I took this from my last project but it seemms like a waste
            int length = Math.Min(80, str.Length - i);//to not use it when it is what I needed.
            subStr += str.Substring(i, length) + "\n";
        }
        subStr = subStr.Substring(0, subStr.Length - 2);
        return subStr;
    }
}