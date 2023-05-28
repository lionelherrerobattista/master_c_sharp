using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    internal class Exercises
    {
        public static void ExerciseOne()
        {
            // Write a program and ask the user to enter a few numbers separated by a hyphen.
            // Work out if the numbers are consecutive.
            // For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
            // display a message: "Consecutive";
            // otherwise, display "Not Consecutive".

            Console.WriteLine("Write a few numbers separated by hyphen: ");
            var numbers = Console.ReadLine();
            var splitString = numbers.Split('-');
            var consecutive = true;

            for (var i = 1; i < splitString.Length; i++)
            {
                if (Int32.Parse(splitString[i]) != (Int32.Parse(splitString[i - 1]) + 1))
                {
                    consecutive = false;
                    break;
                }

            }

            if (consecutive)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not consecutive");
            }
        }

        public static void ExerciseTwo()
        {
            // Write a program and ask the user to enter a few numbers
            // separated by a hyphen.
            // If the user simply presses Enter,
            // without supplying an input, exit immediately
            // otherwise, check to see if there are duplicates.
            // If so, display "Duplicate" on the console. 
            Console.WriteLine("Enter a few numbers separated by hyphen");
            var numbers = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(numbers))
            {
                var splitString = numbers.Split('-');
                var duplicates = false;
                // create list to use remove and contains methods
                var list = new List<string>(splitString);
                // search for duplicates
                foreach (var number in splitString)
                {
                    list.Remove(number);

                    if (list.Contains(number))
                    {
                        duplicates = true;
                        break;
                    }
                }
                if (duplicates)
                {
                    Console.WriteLine("Duplicate");
                }
            }
        }

        public static void ExerciseThree()
        {
            // Write a program and ask the user
            // to enter a time value in the 24-hour time format (e.g. 19:00).
            // A valid time should be between 00:00 and 23:59.
            // If the time is valid, display "Ok";
            // otherwise, display "Invalid Time".
            // If the user doesn't provide any values, consider it as invalid time. 

            Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 19:00)");
            var input = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(input))
            {
                var inputString = input.Split(':');
                var valid = true;

                if (inputString.Length == 2)
                {
                    var hours = byte.Parse(inputString[0]); // compare hours 0 to 24
                    var minutes = byte.Parse(inputString[1]); // compare minutes 0 to 59

                    if ((hours < 0 || hours > 24) || (minutes < 0 || minutes > 59))
                    {
                        valid = false;
                    }
                    
                }
                else
                {
                    valid = false;
                }


                if (valid)
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    Console.WriteLine("Invalid Time");
                }

            }
            else
            {
                Console.WriteLine("Invalid Time");
            }
        }


        public static void ExerciseFour()
        {
            // Write a program and ask the user
            // to enter a few words separated by a space.
            // Use the words to create a variable name with PascalCase.
            // For example, if the user types: "number of students",
            // display "NumberOfStudents".
            // Make sure that the program is not dependent on the input.
            // So, if the user types "NUMBER OF STUDENTS",
            // the program should still display "NumberOfStudents". 
            Console.WriteLine("Write a few words separated by a space");
            var input = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(input))
            {
                var wordList = input.Split(' ');
                var variableName = new StringBuilder();

                foreach (var word in wordList)
                {
                    var firstLetter = word.Substring(0, 1).ToUpper();
                    var auxWord = word.Substring(1).ToLower();
                    variableName.Append(firstLetter + auxWord);
                }

                Console.WriteLine(variableName.ToString());
            }
        }

        public static void ExerciseFive()
        {
            // Write a program and ask the user to enter an English word.
            // Count the number of vowels (a, e, o, u, i) in the word.
            // So, if the user enters "inadequate",
            // the program should display 6 on the console.
            char[] vowels = { 'a', 'e', 'o', 'u', 'i' };

            Console.WriteLine("Write a word to count the amount of vowels");
            var input = Console.ReadLine().ToLower(); // make comparison with lower case
            var vowelCounter = 0;

            if (!String.IsNullOrWhiteSpace(input))
            {
                foreach (var letter in input)
                {
                    if (vowels.Contains(letter))
                    {
                        vowelCounter++;
                    }
                }
            }

            Console.WriteLine("Amount of vowels: " + vowelCounter);

        }
    }
}
