using System;
namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void printThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void printByThree()
        {
            for (int i = 3; i <= 999; i = i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameters and check whether they are equal or not
        public static void isEqual(double a, double b)
        {
            if (a == b)
            {
                Console.WriteLine($"{a} is equal to {b}");
            }
            else
            {
                Console.WriteLine($"{a} is not equal to {b}");
            }
        }

        //Write a method to check whether a given number is even or odd
        public static void evenOrOdd(double a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is even.");
            }
            else
            {
                Console.WriteLine($"{a} is odd.");
            }    
        }

        //Write a method to check whether a given number is positive or negative
        public static void PosNev(double number)
        {
            if (number < 0)
            {
                Console.WriteLine($"{number} is negative.");
            }
            else
            {
                Console.WriteLine($"{number} is positive.");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void goVote()
        {
            int age = 0;
            bool needAge;
            do
            {
                Console.WriteLine("How old are you?");
                var howOld = Console.ReadLine();
                needAge = int.TryParse(howOld, out age);
                
            }
            while ( needAge == false);

            if (age >= 18)
            { 
                Console.WriteLine("It's time for you to vote!");
            }
            else
            {
                Console.WriteLine("Sorry, you're too young to vote.");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void inRange(double number)
        {
            if (number >= -10 && number <= 10)
            {
                Console.WriteLine($"{number} is within the range.");
            }
            else
            {
                Console.WriteLine($"{number} is not within range.");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void multTable(double a)
        {
            for (double mult = 1; mult <= 12; mult++)
            {
                a *= mult;
                Console.WriteLine(a);
                a /= mult;
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            double noOne = 0;
            double noTwo = 0;
            bool trueNumber;
            Console.WriteLine("I need two numbers!");
            do
            {
                var firstOne = Console.ReadLine();
                trueNumber = double.TryParse(firstOne, out noOne);

            }
            while (trueNumber == false);

            do
            {
                var secondOne = Console.ReadLine();
                trueNumber = double.TryParse(secondOne, out noTwo);

            }
            while (trueNumber == false);

            isEqual(noOne, noTwo);
            evenOrOdd(noTwo);
            PosNev(noOne);
            inRange(noOne);
            multTable(noTwo);
            goVote();
            printThousand();
            printByThree();

        }
    }
}
