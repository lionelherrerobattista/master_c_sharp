using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations_exercises
{
    internal class Exercises
    {

        public static void ExerciseOne()
        {
            int count = 0;

            for(int i = 1; i < 100; i++)
            {
                if(i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Numbers divisible by 3 between 1 and 100: " + count);
        }

        public static void ExerciseTwo()
        {
            int sum = 0;
            string input;

            Console.WriteLine("Enter a number (or write 'ok' to exit)");
            
            while(true)
            {
                input = Console.ReadLine();

                if (input.ToLower() != "ok")
                {
                    sum += Convert.ToInt32(input);
                }
                else
                {
                    break;
                }

            }

            Console.WriteLine("The sum of the numbers is {0}", sum);
        }

        public static void ExerciseThree()
        {
            Console.WriteLine("Write a number to compute its factorial");

            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = number;

            for(int i = number - 1; i > 0; i--)
            {
                factorial *= i;
            }

            Console.WriteLine("{0}! = {1}", number, factorial);
        }

        public static void ExerciseFour()
        {
            int input;
            int chances = 4;
            Random random = new Random();
            int secretNumber = random.Next(1, 10);

            Console.WriteLine("Guess the number: ");
            for(; chances > 0; chances--)
            {
                Console.Write("(chances left {0}) number: ", chances);
                input = Convert.ToInt32(Console.ReadLine());
                if(input == secretNumber)
                {
                    Console.WriteLine("You won");
                    break;
                }
                
            }

            if (chances == 0)
            {
                Console.WriteLine("You lost");
            }
        }

        public static void ExerciseFive()
        {
            Console.WriteLine("Write a series of numbers separated by comma");
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            var maxNumber = Convert.ToInt32(numbers[0]);

            foreach(var number in numbers)
            {
                if(Convert.ToInt32(number) > maxNumber)
                {
                    maxNumber = Convert.ToInt32(number);
                }
            }

            Console.WriteLine("The max number is {0}", maxNumber);

        }
    }
}
