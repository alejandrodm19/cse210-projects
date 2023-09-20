using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> NumbersList = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int NumberAnswer = int.Parse(Console.ReadLine());

        NumberAnswer = -1;
        while (NumberAnswer != 0){
            Console.Write("Enter a list of numbers, type 0 when finished.");
            int UserAnswer = int.Parse(Console.ReadLine());
            NumberAnswer = UserAnswer;

            if (NumberAnswer != 0){

                NumbersList.Add(UserAnswer);
            }


        }

        int sum = 0;
        foreach (int number in NumbersList){

            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float) sum) / NumbersList.Count;
        Console.WriteLine($"The average is: {average}");


        int max = NumbersList[0];

        foreach (int number in NumbersList)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

    }
}