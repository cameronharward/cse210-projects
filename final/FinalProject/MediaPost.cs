public class MediaPost : Post{
    private string _url;

    public MediaPost(){

    }
    public MediaPost(string name, string desc, string url) : base(name,desc){
        this._url = url;
    }
    public override string FullDisplay()
    {
        string finalString = $"{_title} - {_url}\n---------\n{_desc}\n---------\n";
        if(_comments.Count != 0){
            foreach(Comment comment in _comments){
                finalString += comment.Display() + "\n";
            }
        }
        return finalString;
    }
    public override string GetFormat()
    {
        string saveString = "MediaPost|";
        saveString += _title + "|";
        saveString += _desc + "|";
        saveString += _url + "|";
        foreach(Comment com in _comments){
            saveString += com.GetFormat();
        }
        return saveString;
    }
}