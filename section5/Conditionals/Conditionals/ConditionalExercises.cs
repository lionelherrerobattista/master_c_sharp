using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class ConditionalExercises
    {
        public static void ExerciseOne ()
        {
            Console.WriteLine("Enter a number between 1 and 10: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public static void ExerciseTwo ()
        {
            Console.WriteLine("Enter two numbers: ");
            
            int numberOne = Convert.ToInt32(Console.ReadLine());
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            int maxNumber = (numberOne >= numberTwo) ? numberOne : numberTwo;

            Console.WriteLine("The greater of {0} and {1} is {2}", numberOne, numberTwo, maxNumber);
        }

        public static void ExerciseThree ()
        {
            Console.Write("Enter width of the image: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter height of the image: ");
            int height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("The image is landscape.");
            }
            else
            {
                Console.WriteLine("The image is portrait");
            }
        }

        public static void ExerciseFour ()
        {
            int demeritPoints = 0;
            const int kmPerDemeritPoint = 5;
            
            Console.Write("Enter the speed limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the speed of the car: ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            carSpeed = carSpeed - speedLimit;

            if(carSpeed > 0)
            {
                demeritPoints = carSpeed / kmPerDemeritPoint;               
            }

            if (demeritPoints > 12)
            {
                Console.WriteLine("License suspended");
            }
            else
            {
                Console.WriteLine("Number of demerit points: {0}", demeritPoints);
            }
        }
    }
}
