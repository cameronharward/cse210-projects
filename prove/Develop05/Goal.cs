public class Goal{
    private string _name;
    private string _desc;
    private bool _completed;
    private int _reward;

    public Goal(){

    }
    public Goal(string name, string desc, int reward){
        _name = name;
        _desc = desc;
        _reward = reward;
        _completed = false;
    }
    public virtual void LoadObject(string format){

    }
    public virtual void UpdateGoal(){
        _completed = true;
    }
    public virtual void Display(){
        string checkmark = _completed ? "X" : "";
        System.Console.WriteLine($"[{checkmark}] {_name} ({_desc})");
    }
    public virtual string GetFormat(){
        return "0";
    }
}