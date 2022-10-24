using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PowerLevel()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        ////Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void NineHundred()
        {
            for (int x = 3; x <= 999; x += 3)
            {
                Console.WriteLine(x);
            }
        }
        ////Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void TwoIntsEqual(int num01, int num02)
        {
            if (num01 == num02)
            {
                Console.WriteLine($"Those numbers are equal");
            }
            else
            {
                Console.WriteLine($"Those numbers are not equal");
            }
        }
        ////Write a method to check whether a given number is even or odd
        public static void EvenOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("number is even.");
            }
            else
            {
                Console.WriteLine("number is odd.");
            }
        }
        ////Write a method to check whether a given number is positive or negative
        public static void PositiveNegative(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num} is negative.");
            }
            else
            {
                Console.WriteLine($"{num} is neither negative or postive.");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void VotingAge()
        {
            bool userAge;
            int result;

            do
            {
                Console.WriteLine("Please enter your age:");

                userAge = int.TryParse(Console.ReadLine(), out result);
            } while (!userAge);

            if (result < 18)
            {
                Console.WriteLine("Sorry, you are unable to vote.");
            }
            else
            {
                Console.WriteLine("You are able to vote.");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void Range()
        {
            Console.WriteLine("Please input a number:");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput >= -10 && userInput <= 10)
            {
                Console.WriteLine($"{userInput} is in range of -10 to 10.");
            }
            else
            {
                Console.WriteLine($"{userInput} is not in range of -10 to 10.");
            }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiTable()
        {
            bool cont;
            int userInput;
            do
            {
                Console.WriteLine("Please enter an integer:");
                cont = int.TryParse(Console.ReadLine(), out userInput);
            }while (!cont);

            for (var i = 1; i < 12; i++)
            {
                Console.WriteLine($"{i} x {userInput} = {i * userInput}");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PowerLevel(); NineHundred(); TwoIntsEqual(4, 4); EvenOdd(4); PositiveNegative(25); VotingAge(); Range(); MultiTable();
        }
    }
}
