using System;

class Program
{
    private static int answerNumber;

    static void Main(string[] args)
    {
       Random randomGenerator = new Random();
       int magicNumber = randomGenerator.Next(1, 100);



        while (magicNumber != answerNumber){

       Console.WriteLine("What is the magic number?");
       Console.Write("What is your guess?");
       answerNumber = int.Parse(Console.ReadLine());

       if (answerNumber == magicNumber){
            Console.WriteLine("You Guessed it");
       }
       else if (answerNumber < magicNumber){
            Console.WriteLine("Lower");

       }
       else if(answerNumber > magicNumber){
            Console.WriteLine("Higher");
       }



       }


    }
}