using System;
using System.Reflection.Metadata;

class Program
{
    static void DisplayMessage(){
        System.Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName(){
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }

    static int SquareNumber(int num){
        num *= num;
        return num;
    }

    static void DisplayResult(string name, int squaredNum){
        Console.WriteLine($"{name}, the square of your favorite number is {squaredNum}");
    }

    static void Main(string[] args)
    {
        DisplayMessage();
        string myName = PromptUserName();
        int favNum = PromptUserNumber();
        int numSquared = SquareNumber(favNum);
        DisplayResult(myName, numSquared);
    }


}