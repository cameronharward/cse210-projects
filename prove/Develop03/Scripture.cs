using System.Dynamic;
using System.IO;
using System.Runtime.CompilerServices;
public class Scripture{
    private List<Verse> _verses = new List<Verse>();
    private string _reference;

    public Scripture(){

    }
    public Scripture(string reference, List<Verse> verses){
        this._reference = reference;
        this._verses = verses;
    }

    public int GetVerseTotal(){
        return _verses.Count;
    }
    public bool GetVerseHidden(int index){
        return _verses[index].getHidden();
    }
    public string GetFormattedString(){
        string finalStr = " ";

        finalStr += _reference + "\n";
        foreach(Verse verse in _verses){
            finalStr += verse.GetDisplay();
            finalStr += "\n\n";
        }

        return finalStr;
    }

    public bool HideWord(int verseIndex){
        bool success = _verses[verseIndex].HideRandom();

        return success;
    }


}