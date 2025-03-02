public class Prompts{
    private List<string> _prompts;

    public Prompts(){

    }
    public Prompts(List<string> prompts){
        this._prompts = prompts;
    }

    public string GetPrompt(){
        Random rand = new Random();
        return _prompts[rand.Next(0, _prompts.Count)];
    }
}