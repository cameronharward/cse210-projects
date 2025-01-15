using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        int addToList;
        bool loop = true;

        while(loop){
            Console.Write("Enter number: ");
            addToList = int.Parse(Console.ReadLine());
            
            if(addToList != 0){
                numberList.Add(addToList);
            }
            else{
                loop = false;
            }
        }

        double finalSum = 0.0;
        foreach(int num in numberList){
            finalSum += num;
        }
        double average = finalSum / numberList.Count();

        int smallest = numberList.Min();
        int biggest = numberList.Max();
        System.Console.WriteLine($"The sum is {finalSum}");
        System.Console.WriteLine($"The average is {average}");
        System.Console.WriteLine($"The smallest number is {smallest}");
        System.Console.WriteLine($"The biggest number is {biggest}");
    }
}