using System.Reflection;

public class Post{
    private protected string _title;
    private protected string _desc;
    private protected List<Comment> _comments = [];

    public Post(){

    }
    public Post(string title, string desc){
        this._title = title;
        this._desc = desc;
    }
    public Post(string title, string desc, List<Comment> comments){
        this._title = title;
        this._desc = desc;
        this._comments = comments;
    }

    public virtual string FullDisplay(){
        string finalString = $"{_title}\n---------\n{_desc}\n---------\n";
        if(_comments.Count != 0){
            foreach(Comment comment in _comments){
                finalString += comment.Display() + "\n";
            }
        }
        return finalString;
    }
    public virtual string HalfDisplay(){
        return $"{_title} - {_comments.Count} Comment(s)";
    }

    public virtual string GetFormat(){
        string saveString = "Post|";
        saveString += _title + "|";
        saveString += _desc + "|";
        foreach(Comment com in _comments){
            saveString += com.GetFormat();
        }
        return saveString;
    }

    public void AddComment(Comment comment){
        _comments.Add(comment);
    }
    public  string GetDesc(){
        string desc = _desc;
        return desc;
    }
}