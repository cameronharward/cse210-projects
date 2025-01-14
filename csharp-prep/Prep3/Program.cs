using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber;
        int answer;
        string playAgain;
        bool restart = true;
        bool correct = false;

        do
        {
            Random randomGenerator = new Random();
            magicNumber = randomGenerator.Next(1, 100);
            do{
                Console.Write("Try to guess the magic number: ");
                answer = int.Parse(Console.ReadLine());
                if(answer < magicNumber){
                    Console.WriteLine("Higher!");
                }
                else if(answer > magicNumber){
                    Console.WriteLine("Lower!");
                }
                else{
                    Console.WriteLine("Your nailed it!!!");
                    correct = true;
                }

            }while(!correct);

            correct = false;
            Console.Write("Do you want to play again? yes or no: ");
            playAgain = Console.ReadLine();
            if(playAgain == "no"){
                restart = false;
                System.Console.WriteLine("Goodbye!");
            }
        } while(restart);
       
    }
}