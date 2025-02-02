using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        PromptManager prompts = new PromptManager();
        Journal journal = new Journal();
        Menu menu = new Menu();
        
        string input = "";
        bool useProgram = true;
        bool hasUnsavedWork = false;



        while(useProgram){
            menu.Display();
            input = Console.ReadLine();
            switch(input)
            {
                case "1": //Display Journal
                    if(journal._entries.Count == 0){
                        System.Console.WriteLine("There is nothing to display yet!");
                        break;
                    }
                    System.Console.WriteLine(journal.GetDisplay());
                    break;
                case "2": //Load Journal
                    System.Console.WriteLine("Filename:");
                    input = Console.ReadLine();
                    if(!File.Exists(input)){
                        System.Console.WriteLine("File does not exist!");
                        break;
                    }
                    if(new FileInfo(input).Length == 0){
                        System.Console.WriteLine("This file is empty! Are you sure you want to do this?(y/n)");
                        string answer = Console.ReadLine();
                        if(answer.ToLower() == "n"){
                            break;
                        }
                    }
                    journal.LoadJournal(input);
                    hasUnsavedWork = false;
                    break;
                case "3": //Save Journal
                    System.Console.WriteLine("What file would you like to save to?");
                    input = Console.ReadLine();
                    journal.SaveJournal(input);
                    hasUnsavedWork = false;
                    break;
                case "4": //Create Entry
                    string prompt = prompts.GetPrompt();
                    System.Console.Write(prompt + " ");

                    string response = Console.ReadLine();
                    response = (string.IsNullOrWhiteSpace(response) || string.IsNullOrEmpty(response)) ? "{user gave no input}" : response;

                    System.Console.Write("Give your entry a name: ");
                    string name = Console.ReadLine();

                    name = (string.IsNullOrWhiteSpace(name) || string.IsNullOrEmpty(name)) ? "unnamed" : name; 
                    //This and the line above make sure that the response and name values cannot be null for the sake of reading and writing info to the file

                    Entry entry = new Entry(name, prompt, response);
                    journal.CreateEntry(entry);
                    hasUnsavedWork = true;
                    break;
                case "5": //Quit
                    if(hasUnsavedWork){
                        System.Console.WriteLine("You have unsaved work!\nAre you sure you want to quit? (y/n)");
                        input = Console.ReadLine();
                        if(input.ToLower() == "y"){
                            useProgram = false;
                            break;
                        }
                        else if(input.ToLower() == "n"){
                            break;
                        }
                        else{
                            System.Console.WriteLine("I don't understand.");
                            break;
                        }
                    }
                    useProgram = false;
                    break;
                default:
                    System.Console.WriteLine("Try one of the available options.");
                    break;
            }
        }
    }
}