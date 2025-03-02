public class Breathing : Activity{
    
    public Breathing(){
        SetName("Breathing");
        SetDesc("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

    }

    public void RunActivity(){
        StartActivity();
        GetReady();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDur());

        System.Console.Write("Breath in...");
        DisplayCountDown(3);
        System.Console.WriteLine();

        System.Console.Write("Breath out...");
        DisplayCountDown(3);
        System.Console.WriteLine();

        while(DateTime.Now <= futureTime){
        System.Console.Write("Breath in...");
        DisplayCountDown(3);
        System.Console.WriteLine();

        System.Console.Write("Breath out...");
        DisplayCountDown(3);
        System.Console.WriteLine();
        }

        EndActivity(); 
    }
}