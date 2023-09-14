using System.Linq.Expressions;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, User!");

            //Random number variables if you choose this route.
            //  var r = new Random();
            //  var favNumber = r.Next(1, 1000);

            int favNumber = 39;
            // bool condition = true;

            Console.WriteLine("What is my favorite number?");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput == favNumber)
            {
                Console.WriteLine("You guessed correct!");
            } else if (userInput > favNumber)
            {
                Console.WriteLine("Incorrect: your number is too high. Try again later.");
            } else
            {
                Console.WriteLine("Incorrect: your number is too low. Try again later.");
            };
         
                                   
            }

        }



    }

