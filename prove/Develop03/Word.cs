public class Word{
    private string _word;
    private bool _isHidden;
    private string _hiddenWord;

    public Word(){

    }
    public Word(string word){
        this._word = word;
        _isHidden = false;
        _hiddenWord = "";
        foreach(Char letter in word){
            _hiddenWord += "_";
        }
    }
    public bool HideWord(){
        if(_isHidden == true){
            return false;
        }
        _isHidden = true;
        return true;
    }
    public string GetDisplay(){
        if(_isHidden == true){
            return _hiddenWord;
        }
        else{
            return _word;
        }
    }

}