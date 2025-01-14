using System;

class Program
{
    static void Main(string[] args)
    {
        bool success;
        string letter;
        System.Console.Write("Please enter your grade for the semester: ");
        int grade = int.Parse(Console.ReadLine());

        if(grade >= 90){
            success = true;
            letter = "A";
        }
        else if(grade <=89 && grade >=80){
            success = true;
            letter = "B";
        }
        else if(grade <=79 && grade >= 70){
            success = true;
            letter = "C";
        }
        else if(grade <= 69 && grade >= 60){
            success = false;
            letter = "D";
        }
        else{
            success = false;
            letter = "F";
        }
        Console.Write($"You have finished this class with an {letter} ");
        if(success){
            Console.Write("and you have passed the class!");
        }

        else{
            Console.Write("and you have failed the class. Better luck next time!");
        }
    }
}