using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> rflPrompts = ["Think of a time you did something really difficult.", "Think of a time you went through something hard.", "Think of a time when someone offended you.", "Think of a time when you succeeded at something.", "Think of a time that you failed at something."];
        List<string> resPrompts = ["How did you feel when it was complete?", "How do you feel your grew from this?", "What is your favorite thing about this experience?", "What is something that this experience made you realize?"];
        List<string> listPrompts = ["When have you felt the Holy Ghost this month?", "When have you felt happiest this month?", "When did someone do something kind to you this month?", "When did you do something kind for someone this month?"];

        bool loop = true;
        Breathing breathing = new Breathing();
        Reflection reflect = new Reflection(rflPrompts, resPrompts);
        Listing list = new Listing(listPrompts);
        Menu menu =  new Menu();

        int breathCount = 0;
        int listCount = 0;
        int reflCount = 0;
        while(loop){
            menu.GetMenu();

            string input = Console.ReadLine();

            switch(input){
                case "1":
                    breathing.RunActivity();
                    breathCount += 1;
                    break;
                case "2":
                    reflect.RunActivity();
                    reflCount += 1;
                    break;
                case "3":
                    listCount += 1;
                    list.RunActivity();
                    break;
                case "4":
                    loop = false;
                    break;
                default:
                    break;
            }
        }
        System.Console.WriteLine($"You did the breathing activity {breathCount} time(s).");
        System.Console.WriteLine($"You did the reflecting activity {reflCount} time(s).");
        System.Console.WriteLine($"You did the listing activity {listCount} time(s).");
        int final = breathCount + reflCount + listCount;
        System.Console.WriteLine($"You completed {final} activities!");
        Thread.Sleep(3000);
    }
}