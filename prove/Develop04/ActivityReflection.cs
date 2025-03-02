public class Reflection : Activity{
    private Prompts _expPrompts;
    private Prompts _reflprompts;

    public Reflection(){

    }
    public Reflection(List<string> expPrompts, List<string> reflPrompts){
        SetName("Reflection");
        SetDesc("This activity will help you reflect on times in your life when you have shown strength and resilience. This will" +
        " help you recognize the power you have and how you can use it in other aspects of your life.");

        this._expPrompts = new Prompts(expPrompts);
        this._reflprompts = new Prompts(reflPrompts);
    }

    public void RunActivity(){

        StartActivity();
        GetReady();

        System.Console.WriteLine("Consider the following prompt:\n");
        System.Console.WriteLine($"  --- {_expPrompts.GetPrompt()} ---\n");
        System.Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        System.Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        DisplayCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDur());

        while(DateTime.Now <= futureTime){
            System.Console.Write("\n> " + _reflprompts.GetPrompt() + " ");
            DisplayAnimation(15);

        }
        System.Console.WriteLine();
        EndActivity();

    }
}