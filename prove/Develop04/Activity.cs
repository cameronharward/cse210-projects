using System.Collections.Concurrent;

public class Activity{
    private string _name;
    private protected string getName(){
        return _name;
    }
    private protected void SetName(string str){
        this._name = str;
    }
    private string _desc;
    private protected string GetDesc(){
        return _desc;
    }
    private protected void SetDesc(string str){
        this._desc = str;
    }
    private int _duration;
    private protected int GetDur(){
        return _duration;
    }
    private protected void SetDur(int num){
        _duration = num;
    }

    public Activity(){

    }
    public Activity(string name, string desc){
        this._name = name;
        this._desc = desc;
    }

    public void StartActivity(){
        Console.Clear();
        System.Console.WriteLine($"Welcome to the {_name} activity.\n");
        System.Console.WriteLine($"{_desc}\n");
        System.Console.Write("How long, in seconds, would you like for your section?");

        _duration = Convert.ToInt32(Console.ReadLine());


    }
    public void GetReady(){
        Console.Clear();
        System.Console.WriteLine("Get Ready.\n");

        DisplayAnimation(3);

    }
    public void DisplayCountDown(int num){
        Console.Write(num);
        Thread.Sleep(1000);
        for(int i = num - 1; i > 0; i--){
            Console.Write($"\b{i}");
            Thread.Sleep(1000);
            if((i-1) == 0){
                Console.Write("\b ");
            }
        }
    }
    public void DisplayAnimation(int dur){
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(dur);

        Console.Write("/");

        while(DateTime.Now <= futureTime){
            Thread.Sleep(200);
            Console.Write("\b-");
            Thread.Sleep(200);
            Console.Write("\b" + "\\");
            Thread.Sleep(200);
            Console.Write("\b|");
            Thread.Sleep(200);
            Console.Write("\b/");
        }
        Console.Write("\b ");
    }
    public void EndActivity(){
        Console.WriteLine("Well Done!\n");
        DisplayAnimation(5);
        Console.WriteLine($"You have completed another {_duration} seconds of {_name} activity.");
        DisplayAnimation(5);
    }
}