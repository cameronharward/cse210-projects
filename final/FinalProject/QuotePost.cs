public class QuotePost : Post{
    private string _quotedPost;

    public QuotePost(){

    }
    public QuotePost(string name, string desc, string postDesc): base(name, desc){
        this._quotedPost = postDesc;
    }

    public override string FullDisplay(){
        string finalString = $"{_title}\n---------\nQuote\"{_quotedPost}\"\n---------\n{_desc}\n---------\n";
        if(_comments.Count != 0){
            foreach(Comment comment in _comments){
                finalString += comment.Display() + "\n";
            }
        }
        return finalString;
    }
    public override string GetFormat(){
        string saveString = "QuotePost|";
        saveString += _title + "|";
        saveString += _desc + "|";
        saveString += _quotedPost + "|";
        foreach(Comment com in _comments){
            saveString += com.GetFormat();
        }
        return saveString;
    }
}