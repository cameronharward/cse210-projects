public class CheckListGoal : Goal{
    private int _finalReward;
    private int _maxCompletes;
    private int _progress;

    public CheckListGoal(){

    }
    public CheckListGoal(string name, string desc, int reward, int finalReward, int max) : base(name, desc, reward){
        _finalReward = finalReward;
        _maxCompletes = max;
        _progress = 0;

    }
    public override void LoadObject(string format){

    }
    public override void UpdateGoal()
    {
        
    }
}