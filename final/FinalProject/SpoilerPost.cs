public class SpoilerPost : Post{
    private string _spoilerTopic;

    public SpoilerPost(){

    }
    public SpoilerPost(string title, string desc, string sptc): base(title, desc){
        this._spoilerTopic = sptc;
    }
    public override string HalfDisplay()
    {
        return "SPLOILER FOR " + _spoilerTopic;
    }
    public override string GetFormat(){
        string saveString = "SpoilerPost|";
        saveString += _title + "|";
        saveString += _desc + "|";
        saveString += _spoilerTopic + "|";
        foreach(Comment com in _comments){
            saveString += com.GetFormat();
        }
        return saveString;
    }
}