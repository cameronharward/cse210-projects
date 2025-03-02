public class Listing : Activity{
    private Prompts _prompts;

    private int _count;

    public Listing(){

    }
    public Listing(List<string> prompts): base(){
        this._prompts = new Prompts(prompts);
        SetName("Listing");
        SetDesc("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }
    public void RunActivity(){
        StartActivity();
        GetReady();

        System.Console.WriteLine("List as many responses as you can to the following prompt:");
        System.Console.WriteLine(" --- " + _prompts.GetPrompt() + " ---");
        Console.Write("You may begin in: ");
        DisplayCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDur());
        System.Console.WriteLine();

        _count = 0;
        while(DateTime.Now <= futureTime){
            Console.Write("> ");
            string input = Console.ReadLine();
            if(!String.IsNullOrWhiteSpace(input)){
                _count += 1;
            }
        }
        System.Console.WriteLine($"You listed {_count} items!");

        EndActivity();
    }
}